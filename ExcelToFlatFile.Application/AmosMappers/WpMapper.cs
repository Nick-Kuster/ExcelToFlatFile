using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates;
using Newtonsoft.Json;
using XFileConverter.Desktop;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class WpMapper : BaseMapper<WPImportInput, WpImportOutput>
    {
        private VariableSettings _varSettings;

        public override WpImportOutput Map(List<WPImportInput> input)
        {
            if (File.Exists("VariableSettings.json"))
            {
                string variableSettingsJson = File.ReadAllText("VariableSettings.json");
                _varSettings = JsonConvert.DeserializeObject<VariableSettings>(variableSettingsJson);
            }

            var workOrders = new List<Workorder>();
            var workPackageId = Guid.NewGuid().ToString();
            foreach (WPImportInput wpRow in input)
            {
                //var partRequests = new List<PartRequest>();
                //AddPartRequestIfNeeded(wpRow.Part1, wpRow.PartDescription1, wpRow.RequiredQuantity1, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part2, wpRow.PartDescription2, wpRow.RequiredQuantity2, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part3, wpRow.PartDescription3, wpRow.RequiredQuantity3, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part4, wpRow.PartDescription4, wpRow.RequiredQuantity4, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part5, wpRow.PartDescription5, wpRow.RequiredQuantity5, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part6, wpRow.PartDescription6, wpRow.RequiredQuantity6, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part7, wpRow.PartDescription7, wpRow.RequiredQuantity7, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part8, wpRow.PartDescription8, wpRow.RequiredQuantity8, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part9, wpRow.PartDescription9, wpRow.RequiredQuantity9, partRequests);
                //AddPartRequestIfNeeded(wpRow.Part10, wpRow.PartDescription10, wpRow.RequiredQuantity10, partRequests);

                var workOrder = new Workorder()
                {
                    Uuid = Guid.NewGuid().ToString(),
                    AssignmentUuid = workPackageId,
                    AtaChapter = wpRow.AtaCode,
                    DocumentTitle = wpRow.WorkOrderNumber,
                    DocumentType = "-",
                    DueDate = wpRow.DueDate.ConvertToFormattedDateString("yyyy-MM-dd"),
                    WorkSteps = new WorkSteps()
                    {
                        WorkStep = new WorkStep()
                        {
                            Uuid = Guid.NewGuid().ToString(),
                            Description = wpRow.ProblemDescription,
                            Headline = wpRow.Headline,
                            //RequiredParts = partRequests.Any() ? new RequiredParts()
                            //{
                            //    PartRequest = partRequests
                            //} : null,
                            References = !string.IsNullOrEmpty(wpRow.FileUrl) ? new References()
                            {
                                Reference = new Reference()
                                {
                                    Uuid = Guid.NewGuid().ToString(),
                                    Description = wpRow.WorkOrderNumber,
                                    Category = "CR",
                                    Type = "WO",
                                    ReferenceProp = wpRow.WorkOrderNumber,
                                    TypeDescription = wpRow.WorkOrderNumber,
                                    Remarks = wpRow.WorkOrderNumber,
                                    DownloadableLink = new DownloadableLink()
                                    {
                                        Url = wpRow.FileUrl,
                                        FileName = wpRow.FileUrl.Split('/').Last()
                                    }
                                }
                            } : null,
                            ResourceRequirements = new ResourceRequirements
                            {
                                ResourceRequirement = new ResourceRequirement
                                {
                                    Uuid = Guid.NewGuid().ToString(),
                                    ResourceType = "Staff",
                                    TotalHours = wpRow.Quantity * wpRow.Duration * 60,
                                    Quantity = wpRow.Quantity,
                                    Duration = wpRow.Duration * 60
                                }
                            }
                        }
                    },
                    WorkorderSource = "S"
                };
                workOrders.Add(workOrder);
            }
            var output = new WpImportOutput()
            {
                OutputXml = new AmosTransportEnvelope()
                {
                    Header = new Header()
                    {
                        Date = DateTime.UtcNow.ToString("O"),
                        ReceiverId = "AAT",
                        SenderId = "AAT"
                    },
                    Payload = new Payload()
                    {
                        Type = "transferMROWorkpackage",
                        Version = "2.3",
                        TransferMroWorkpackage = new TransferMroWorkpackage()
                        {
                            Version = "2.3",
                            Workpackage = new Workpackage()
                            {
                                Uuid = workPackageId,
                                WorkpackageHeader = new WorkpackageHeader()
                                {
                                    Station = _varSettings.Station,
                                    ShortDescription = _varSettings.ShortDescription,
                                    Aircraft = new Aircraft()
                                    {
                                        Text = _varSettings.Aircraft,
                                        Base = "transferAircraft"
                                    },
                                    ExpectedEndDate = _varSettings.EndDate.ConvertToFormattedDateString("yyyy-MM-dd"),
                                    ExpectedEndTime = _varSettings.EndTime,
                                    ExpectedStartDate = _varSettings.StartDate.ConvertToFormattedDateString("yyyy-MM-dd"),
                                    ExpectedStartTime = _varSettings.StartTime,
                                    WorkpackageName = _varSettings.WorkPackageName
                                },
                                Workorders = new Workorders()
                                {
                                    Workorder = workOrders
                                }
                            }
                        }
                    }
                }
            };

            return output;
        }
        private void AddPartRequestIfNeeded(string partNumber, string partDescription, string quantity, List<PartRequest> partRequestList)
        {
            if (!string.IsNullOrEmpty(partNumber) && !string.IsNullOrEmpty(partDescription) && !string.IsNullOrEmpty(quantity))
            {
                partRequestList.Add(new PartRequest()
                {
                    Uuid = Guid.NewGuid().ToString(),
                    PartNo = partNumber,
                    Description = partDescription,
                    NeededQuantity = new NeededQuantity()
                    {
                        Text = quantity,
                        Uom = "EA"
                    }
                });
            }
        }
    }
}
