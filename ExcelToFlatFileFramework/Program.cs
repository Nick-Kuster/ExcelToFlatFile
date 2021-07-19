using ExcelToFlatFile.Application.XFileConverters;

namespace ExcelToFlatFileFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CheckTemplateConverter checkTemplateConverter = new CheckTemplateConverter();
            DocumentTemplateConverter documentTemplateConverter = new DocumentTemplateConverter();
            PartTemplateConverter partTemplateConverter = new PartTemplateConverter();
            TaskcardTemplateConverter taskcardTemplateConverter = new TaskcardTemplateConverter();
            
            checkTemplateConverter.Convert();
            documentTemplateConverter.Convert();
            partTemplateConverter.Convert();
            taskcardTemplateConverter.Convert();
        }
    }
}

