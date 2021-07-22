namespace ExcelToFlatFile.Application.XFileConverters
{
    public class BaseTemplateConverter
    {
        public string TemplateLocation { get; set; }
        public string XFileOutputDirectory { get; set; }
        public string ErrorOutputDirectory { get; set; }
    }
}