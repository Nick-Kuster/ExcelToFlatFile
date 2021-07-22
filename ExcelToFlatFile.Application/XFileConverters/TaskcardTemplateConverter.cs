using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelToFlatFile.Application.AmosMappers;
using ExcelToFlatFile.Application.Helpers;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Documents;
using ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard;
using Npoi.Mapper;
using NPOI.SS.UserModel;

namespace ExcelToFlatFile.Application.XFileConverters
{
    public class TaskcardTemplateConverter : BaseTemplateConverter
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
            var items = importer.Take<TaskcardTemplate>();
            List<TaskcardTemplate> templateRows = items.Select(x => x.Value).Distinct().ToList();
            validator.ValidateInput(templateRows, $@"{ErrorOutputDirectory}\TaskcardTemplateErrors.csv");
            
            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();

            TaskcardMapper taskcardMapper = new TaskcardMapper();
            _TASKCARD_OUT_TEMPLATE taskcardOut = taskcardMapper.Map(templateRows);
            Directory.CreateDirectory($@"{XFileOutputDirectory}\Taskcards");
            
            File.WriteAllText($@"{XFileOutputDirectory}\Taskcards\350Xmstaskhist.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._350Xmstaskhist));
            File.WriteAllText($@"{XFileOutputDirectory}\Taskcards\351_XMSTASKPEND.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._351_XMSTASKPEND));
            File.WriteAllText($@"{XFileOutputDirectory}\Taskcards\352_XMSTASKPENDINT.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._352_XMSTASKPENDINT));
            File.WriteAllText($@"{XFileOutputDirectory}\Taskcards\354_XMSTASKPRESET.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._354_XMSTASKPRESET));
        }
    }
}