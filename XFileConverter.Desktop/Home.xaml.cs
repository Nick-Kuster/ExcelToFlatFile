using System.Configuration;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace XFileConverter.Desktop
{
    public partial class Home : Page
    {
        public Home()
        {
           
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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
            var x = 1;
        }
    }
}