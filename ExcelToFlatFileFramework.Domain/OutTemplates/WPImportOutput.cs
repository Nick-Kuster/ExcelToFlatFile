using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ExcelToFlatFileFramework.Domain.OutTemplates
{
    public class WpImportOutput
    {
        public AmosTransportEnvelope OutputXml { get; set; }
    }

    [XmlRoot(ElementName = "date")]
    public class Date
    {
        [XmlAttribute(AttributeName = "timezone")]
        public string Timezone { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "header")]
    public class Header
    {
        [XmlElement(ElementName = "senderID")]
        public string SenderId { get; set; }
        [XmlElement(ElementName = "receiverID")]
        public string ReceiverId { get; set; }
        [XmlElement(ElementName = "date")]
        public string Date { get; set; }
    }

    [XmlRoot(ElementName = "aircraft")]
    public class Aircraft
    {
        [XmlAttribute(AttributeName = "base")]
        public string Base { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "workpackageHeader")]
    public class WorkpackageHeader
    {
        [XmlElement(ElementName = "aircraft")]
        public Aircraft Aircraft { get; set; }
        [XmlElement(ElementName = "workpackageName")]
        public string WorkpackageName { get; set; }
        [XmlElement(ElementName = "station")]
        public string Station { get; set; }
        [XmlElement(ElementName = "expectedStartDate")]
        public string ExpectedStartDate { get; set; }
        [XmlElement(ElementName = "expectedStartTime")]
        public string ExpectedStartTime { get; set; }
        [XmlElement(ElementName = "expectedEndDate")]
        public string ExpectedEndDate { get; set; }
        [XmlElement(ElementName = "expectedEndTime")]
        public string ExpectedEndTime { get; set; }
        [XmlElement(ElementName = "shortDescription")]
        public string ShortDescription { get; set; }
    }

    [XmlRoot(ElementName = "neededQuantity")]
    public class NeededQuantity
    {
        [XmlAttribute(AttributeName = "UOM")]
        public string Uom { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "partRequest")]
    public class PartRequest
    {
        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }
        [XmlElement(ElementName = "partNo")]
        public string PartNo { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "neededQuantity")]
        public NeededQuantity NeededQuantity { get; set; }
    }

    [XmlRoot(ElementName = "requiredParts")]
    public class RequiredParts
    {
        [XmlElement(ElementName = "partRequest")]
        public List<PartRequest> PartRequest { get; set; }
    }

    [XmlRoot(ElementName = "downloadableLink")]
    public class DownloadableLink
    {
        [XmlElement(ElementName = "url")] 
        public string Url { get; set; }
        [XmlElement(ElementName = "filename")] 
        public string FileName { get; set; }
    }

    [XmlRoot(ElementName = "reference")]
    public class Reference
    {
        [XmlAttribute(AttributeName = "uuid")] 
        public string Uuid { get; set; }
        [XmlElement(ElementName = "category")] 
        public string Category { get; set; }
        [XmlElement(ElementName = "type")] 
        public string Type { get; set; }
        [XmlElement(ElementName = "reference")] 
        public string ReferenceProp { get; set; }
        [XmlElement(ElementName = "typeDescription")] 
        public string TypeDescription { get; set; }
        [XmlElement(ElementName = "description")] 
        public string Description { get; set; }
        [XmlElement(ElementName = "remarks")] 
        public string Remarks { get; set; }
        [XmlElement(ElementName = "downloadableLink")]
        public DownloadableLink DownloadableLink { get; set; }
    }

    [XmlRoot(ElementName = "references")]
    public class References
    {
        [XmlElement(ElementName = "reference")]
        public Reference Reference { get; set; }
    }

    [XmlRoot(ElementName = "resourceRequirements")]
    public class ResourceRequirements
    {
        [XmlElement(ElementName = "resourceRequirement")]
        public ResourceRequirement ResourceRequirement { get; set; }
    }

    [XmlRoot(ElementName = "resourceRequirement")]
    public class ResourceRequirement
    {
        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }
        [XmlElement(ElementName = "resourceType")]
        public string ResourceType { get; set; }
        [XmlElement(ElementName = "totalHours")]
        public int TotalHours { get; set; }
        [XmlElement(ElementName = "quantity")]
        public int Quantity { get; set; }
        [XmlElement(ElementName = "duration")]
        public int Duration { get; set; }
        [XmlElement(ElementName = "constraints")]
        public Constraints Constraints { get; set; }
    }

    [XmlRoot(ElementName = "constraints")]
    public class Constraints
    {
        [XmlElement(ElementName = "constraint")]
        public Constraint Constraint { get; set; }
    }

    [XmlRoot(ElementName = "constraint")]
    public class Constraint
    {
        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }
        [XmlElement(ElementName = "propertyType")]
        public string PropertyType { get; set; }
        [XmlElement(ElementName = "valueString")]
        public string ValueString { get; set; }
    }
    

    [XmlRoot(ElementName = "workStep")]
    public class WorkStep/* : IXmlSerializable*/
    {
        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }
        [XmlElement(ElementName = "headline")]
        public string Headline { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "requiredParts")]
        public RequiredParts RequiredParts { get; set; }
        [XmlElement(ElementName="references")] 
        public References References { get; set; }
        [XmlElement(ElementName = "resourceRequirements")]
        public ResourceRequirements ResourceRequirements { get; set; }
    }

    [XmlRoot(ElementName = "workSteps")]
    public class WorkSteps
    {
        [XmlElement(ElementName = "workStep")]
        public WorkStep WorkStep { get; set; }
    }

    [XmlRoot(ElementName = "workorder")]
    public class Workorder
    {

        [XmlAttribute(AttributeName = "assignmentUuid")]
        public string AssignmentUuid { get; set; }
        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }
        [XmlElement(ElementName = "documentType")]
        public string DocumentType { get; set; }
        [XmlElement(ElementName = "workorderSource")]
        public string WorkorderSource { get; set; }
        [XmlElement(ElementName = "documentTitle")]
        public string DocumentTitle { get; set; }
        [XmlElement(ElementName = "ataChapter")]
        public string AtaChapter { get; set; }
        [XmlElement(ElementName = "dueDate")]
        public string DueDate { get; set; }
        [XmlElement(ElementName = "workSteps")]
        public WorkSteps WorkSteps { get; set; }

    }

    [XmlRoot(ElementName = "workorders")]
    public class Workorders
    {
        [XmlElement(ElementName = "workorder")]
        public List<Workorder> Workorder { get; set; }
    }

    [XmlRoot(ElementName = "workpackage")]
    public class Workpackage
    {
        [XmlElement(ElementName = "workpackageHeader")]
        public WorkpackageHeader WorkpackageHeader { get; set; }
        [XmlElement(ElementName = "workorders")]
        public Workorders Workorders { get; set; }
        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }
    }

    [XmlRoot(ElementName = "transferMROWorkpackage")]
    public class TransferMroWorkpackage
    {
        [XmlElement(ElementName = "workpackage")]
        public Workpackage Workpackage { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "payload")]
    public class Payload
    {
        [XmlElement(ElementName = "transferMROWorkpackage")]
        public TransferMroWorkpackage TransferMroWorkpackage { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "amosTransportEnvelope")]
    public class AmosTransportEnvelope
    {
        [XmlElement(ElementName = "header")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "payload")]
        public Payload Payload { get; set; }
        [XmlAttribute(AttributeName = "dsig", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Dsig { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        
    }
}
