using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelToFlatFile.Application.AmosMappers;
using ExcelToFlatFile.Application.Helpers;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Checks;
using ExcelToFlatFileFramework.Domain.OutTemplates.Documents;
using Npoi.Mapper;
using NPOI.SS.UserModel;

namespace ExcelToFlatFile.Application.XFileConverters
{
    public class DocumentTemplateConverter
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
            var items = importer.Take<DocumentTemplate>();
            List<DocumentTemplate> templateRows = items.Select(x => x.Value).Distinct().ToList();
            validator.ValidateInput(templateRows, @"C:\Documentation\AMOS\XFileConversion\Output\Errors\DocumentTemplateErrors.csv");
            
            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();

            DocumentMapper documentMapper = new DocumentMapper();
            _DOCUMENT_OUT_TEMPLATE documentOut = documentMapper.Map(templateRows);
            
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Documents\268_XDHISTS.txt",  outputTemplateStringHelper.ConvertToString(documentOut._268_XDHISTS));
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Documents\269_XDPENDS.txt",  outputTemplateStringHelper.ConvertToString(documentOut._269_XDPENDS));
        }
    }
}