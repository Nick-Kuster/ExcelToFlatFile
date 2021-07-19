using ExcelToFlatFileFramework.Domain.InTemplates;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelToFlatFile.Application.AmosMappers;
using ExcelToFlatFile.Application.Helpers;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartReq;
using Npoi.Mapper;
using NPOI.SS.UserModel;

namespace ExcelToFlatFileFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"C:\Documentation\AMOS\XFileConversion\Part Template - For Import.xlsx";

            IWorkbook workbook;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                workbook = WorkbookFactory.Create(file);
            }
            
            var importer = new Mapper(workbook);
            var items = importer.Take<PartTemplate>();
            List<PartTemplate> tests = items.Select(x => x.Value).Distinct().ToList();
            InputValidator validator = new InputValidator();
            validator.ValidateInput(tests, @"C:\Documentation\AMOS\XFileConversion\Output\Errors\PartTemplateErrors.csv");
            
            PartDefinitionMapper partDefinitionMapper = new PartDefinitionMapper();
            PartDefinitionOutTemplate partDefinitionOut = partDefinitionMapper.Map(tests);
            PartReqMapper partReqMapper = new PartReqMapper();
            PartReqOutTemplate partReqOut = partReqMapper.Map(tests);

            ConvertOutTemplateToStringHelper outputTemplateStringHelper = new ConvertOutTemplateToStringHelper();
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Part Definition\122_XROTABLE.txt",  outputTemplateStringHelper.ConvertToString(partDefinitionOut._122_XROTABLE));
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Part Definition\407_XHISTORY.txt", outputTemplateStringHelper.ConvertToString(partDefinitionOut._407_XHISTORY));
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Part Req\_148_XPARTREQHI.txt", outputTemplateStringHelper.ConvertToString(partReqOut._148_XPARTREQHI));
            File.WriteAllText(@"C:\Documentation\AMOS\XFileConversion\Output\Part Req\_149_XPARTREQPE.txt", outputTemplateStringHelper.ConvertToString(partReqOut._149_XPARTREQPE));
        }
    }
}

