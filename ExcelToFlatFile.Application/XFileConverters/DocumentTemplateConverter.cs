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
    public class DocumentTemplateConverter : BaseTemplateConverter
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
            var items = importer.Take<DocumentTemplate>();
            List<DocumentTemplate> templateRows = items.Select(x => x.Value).Distinct().ToList();
            validator.ValidateInput(templateRows, $@"{ErrorOutputDirectory}\DocumentTemplateErrors.csv");
            
            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();

            DocumentMapper documentMapper = new DocumentMapper();
            _DOCUMENT_OUT_TEMPLATE documentOut = documentMapper.Map(templateRows);
            
            Directory.CreateDirectory($@"{XFileOutputDirectory}\Documents");
            File.WriteAllText($@"{XFileOutputDirectory}\Documents\268_XDHISTS.txt",  outputTemplateStringHelper.ConvertToString(documentOut._268_XDHISTS));
            File.WriteAllText($@"{XFileOutputDirectory}\Documents\269_XDPENDS.txt",  outputTemplateStringHelper.ConvertToString(documentOut._269_XDPENDS));
        }
    }
}