using System.IO;
using System.Windows;
using System.Windows.Navigation;
using ExcelToFlatFile.Application.XFileConverters;
using Newtonsoft.Json;

namespace XFileConverter.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Loaded += MainWindow_Loaded;
            InitializeComponent();
        }
        
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string json = File.ReadAllText("Settings.json");
            Settings settings = JsonConvert.DeserializeObject<Settings>(json);
            CheckTemplate.Text = settings?.CheckTemplate ?? "";
            DocumentTemplate.Text = settings?.DocumentTemplate ?? "";
            PartsTemplate.Text = settings?.PartsTemplate ?? "";
            TaskcardTemplate.Text = settings?.TaskcardTemplate ?? "";
            XfileOutputDir.Text = settings?.XfileOutputDir ?? "";
            ErrorFileDir.Text = settings?.ErrorFileDir ?? "";
        }

        private void btnSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            var settings = new Settings
            {
                CheckTemplate = CheckTemplate.Text,
                DocumentTemplate = DocumentTemplate.Text,
                PartsTemplate = PartsTemplate.Text,
                TaskcardTemplate = TaskcardTemplate.Text,
                XfileOutputDir = XfileOutputDir.Text,
                ErrorFileDir = ErrorFileDir.Text
            };
            string json = JsonConvert.SerializeObject(settings);
            
            File.WriteAllText("Settings.json", json);
        }
        private void btnConverToXFiles_Click(object sender, RoutedEventArgs e)
        {
            CheckTemplateConverter checkTemplateConverter = new CheckTemplateConverter()
            {
                TemplateLocation = CheckTemplate.Text,
                ErrorOutputDirectory = ErrorFileDir.Text,
                XFileOutputDirectory = XfileOutputDir.Text
            };
            DocumentTemplateConverter documentTemplateConverter = new DocumentTemplateConverter()
            {
                TemplateLocation = DocumentTemplate.Text,
                ErrorOutputDirectory = ErrorFileDir.Text,
                XFileOutputDirectory = XfileOutputDir.Text
            };
            PartTemplateConverter partTemplateConverter = new PartTemplateConverter()
            {
                TemplateLocation = PartsTemplate.Text,
                ErrorOutputDirectory = ErrorFileDir.Text,
                XFileOutputDirectory = XfileOutputDir.Text
            };;
            TaskcardTemplateConverter taskcardTemplateConverter = new TaskcardTemplateConverter()
            {
                TemplateLocation = TaskcardTemplate.Text,
                ErrorOutputDirectory = ErrorFileDir.Text,
                XFileOutputDirectory = XfileOutputDir.Text
            };;
            
            checkTemplateConverter.Convert();
            documentTemplateConverter.Convert();
            partTemplateConverter.Convert();
            taskcardTemplateConverter.Convert();
        }
    }
}