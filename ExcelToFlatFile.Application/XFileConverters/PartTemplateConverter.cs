using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelToFlatFile.Application.AmosMappers;
using ExcelToFlatFile.Application.Helpers;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartReq;
using Npoi.Mapper;
using NPOI.SS.UserModel;

namespace ExcelToFlatFile.Application.XFileConverters
{
    public class PartTemplateConverter : BaseTemplateConverter
    {
        public void Convert()
        {
            var fileName = TemplateLocation;

            IWorkbook workbook;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                workbook = WorkbookFactory.Create(file);
            }
            
            InputValidator validator = new InputValidator();
            var importer = new Mapper(workbook);
            var items = importer.Take<PartTemplate>();
            List<PartTemplate> templateRows = items.Select(x => x.Value).Distinct().ToList();
            validator.ValidateInput(templateRows, $@"{ErrorOutputDirectory}\PartTemplateErrors.csv");
            
            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();

            PartDefinitionMapper partDefinitionMapper = new PartDefinitionMapper();
            _PART_DEFINITION_OUT_TEMPLATE partDefinitionOut = partDefinitionMapper.Map(templateRows);
            Directory.CreateDirectory($@"{XFileOutputDirectory}\Part Definition");
            File.WriteAllText($@"{XFileOutputDirectory}\Part Definition\122_XROTABLE.txt",  outputTemplateStringHelper.ConvertToString(partDefinitionOut._122_XROTABLE));
            File.WriteAllText($@"{XFileOutputDirectory}\Part Definition\407_XHISTORY.txt", outputTemplateStringHelper.ConvertToString(partDefinitionOut._407_XHISTORY));
            
            PartReqMapper partReqMapper = new PartReqMapper();
            _PART_REQ_OUT_TEMPLATE partReqOut = partReqMapper.Map(templateRows);
            Directory.CreateDirectory($@"{XFileOutputDirectory}\Part Req");
            File.WriteAllText($@"{XFileOutputDirectory}\Part Req\_148_XPARTREQHI.txt", outputTemplateStringHelper.ConvertToString(partReqOut._148_XPARTREQHI));
            File.WriteAllText($@"{XFileOutputDirectory}\Part Req\_149_XPARTREQPE.txt", outputTemplateStringHelper.ConvertToString(partReqOut._149_XPARTREQPE));
        }
    }
}