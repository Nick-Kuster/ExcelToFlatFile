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
    public class TaskcardTemplateConverter
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
            var items = importer.Take<TaskcardTemplate>();
            List<TaskcardTemplate> templateRows = items.Select(x => x.Value).Distinct().ToList();
            validator.ValidateInput(templateRows, @"C:\Documentation\AMOS\XFileConversion\Output\Errors\TaskcardTemplateErrors.csv");
            
            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();

            TaskcardMapper taskcardMapper = new TaskcardMapper();
            _TASKCARD_OUT_TEMPLATE taskcardOut = taskcardMapper.Map(templateRows);
            
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Taskcards\350Xmstaskhist.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._350Xmstaskhist));
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Taskcards\351_XMSTASKPEND.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._351_XMSTASKPEND));
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Taskcards\352_XMSTASKPENDINT.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._352_XMSTASKPENDINT));
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Taskcards\354_XMSTASKPRESET.txt",  outputTemplateStringHelper.ConvertToString(taskcardOut._354_XMSTASKPRESET));
        }
    }
}