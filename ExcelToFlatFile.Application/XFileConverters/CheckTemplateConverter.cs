using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelToFlatFile.Application.AmosMappers;
using ExcelToFlatFile.Application.Helpers;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Checks;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition;
using Npoi.Mapper;
using NPOI.SS.UserModel;

namespace ExcelToFlatFile.Application.XFileConverters
{
    public class CheckTemplateConverter
    {
        public void Convert()
        {
            var fileName = @"C:\Documentation\AMOS\XFileConversion\Part Template - For Import.xlsx";

            IWorkbook workbook;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                workbook = WorkbookFactory.Create(file);
            }
            
            InputValidator validator = new InputValidator();
            var importer = new Mapper(workbook);
            var items = importer.Take<ChecksTemplate>();
            List<ChecksTemplate> templateRows = items.Select(x => x.Value).Distinct().ToList();
            validator.ValidateInput(templateRows, @"C:\Documentation\AMOS\XFileConversion\Output\Errors\ChecksTemplateErrors.csv");
            
            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();

            CheckMapper checkMapper = new CheckMapper();
            ChecksOutTemplate checkOut = checkMapper.Map(templateRows);
            
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Checks\294_XCHECKHI.txt",  outputTemplateStringHelper.ConvertToString(checkOut._294_XCHECKHI));
        }
    }
}