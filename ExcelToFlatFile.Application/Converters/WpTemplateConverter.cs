using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using ExcelToFlatFile.Application.AmosMappers;
using ExcelToFlatFile.Application.Helpers;
using ExcelToFlatFile.Application.XFileConverters;
using ExcelToFlatFileFramework.Domain.Helpers;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates;
using Npoi.Mapper;
using NPOI.SS.UserModel;

namespace ExcelToFlatFile.Application.Converters
{
    public class WpTemplateConverter : BaseTemplateConverter
    {
        public void Convert()
        {
            var fileName = InputLocation;

            IWorkbook workbook;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                workbook = WorkbookFactory.Create(file);
            }

            InputValidator validator = new InputValidator();
            var importer = new Mapper(workbook);
            var items = importer.Take<WPImportInput>();
            List<WPImportInput> templateRows = items.Select(x => x.Value).ToList();
            validator.ValidateInput(templateRows, $@"{ErrorOutputDirectory}\\TemplateErrors.csv");


            WpMapper wpMapper = new WpMapper();
            WpImportOutput wpOutput = wpMapper.Map(templateRows);
            Directory.CreateDirectory($@"{OutputDirectory}");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AmosTransportEnvelope));

            using (var sww = new Utf8StringWriter())
            {
                using (var writer = XmlWriter.Create(sww))
                {
                    xmlSerializer.Serialize(writer, wpOutput.OutputXml);
                    string xml = sww.ToString();
                    Directory.CreateDirectory(OutputDirectory);
                    File.WriteAllText($@"{OutputDirectory}\WP Import.xml", xml);
                }
            }
        }
    }
}
