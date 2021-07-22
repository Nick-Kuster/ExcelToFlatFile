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
    public class CheckTemplateConverter : BaseTemplateConverter
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
            var items = importer.Take<ChecksTemplate>();
            List<ChecksTemplate> templateRows = items.Select(x => x.Value).Distinct().ToList();
            validator.ValidateInput(templateRows, $@"{ErrorOutputDirectory}\\ChecksTemplateErrors.csv");
            
            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();

            CheckMapper checkMapper = new CheckMapper();
            _CHECKS_OUT_TEMPLATE checkOut = checkMapper.Map(templateRows);
            Directory.CreateDirectory($@"{XFileOutputDirectory}\Checks");
            File.WriteAllText($@"{XFileOutputDirectory}\Checks\294_XCHECKHI.txt",  outputTemplateStringHelper.ConvertToString(checkOut._294_XCHECKHI));
        }
    }
}