namespace ExcelToFlatFile.Application.XFileConverters
{
    public class BaseTemplateConverter
    {
        public string InputLocation { get; set; }
        public string OutputDirectory { get; set; }
        public string ErrorOutputDirectory { get; set; }
    }
}