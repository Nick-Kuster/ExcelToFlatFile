using System.IO;
using System.Windows;
using ExcelToFlatFile.Application.TemplateGenerators;
using ExcelToFlatFile.Application.XFileConverters;
using ExcelToFlatFileFramework.Domain.InTemplates;
using Microsoft.Win32;
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
            if (File.Exists("Settings.json"))
            {
                string settingsjson = File.ReadAllText("Settings.json");
                Settings settings = JsonConvert.DeserializeObject<Settings>(settingsjson);
                CheckTemplate.Text = settings?.CheckTemplate ?? "";
                DocumentTemplate.Text = settings?.DocumentTemplate ?? "";
                PartsTemplate.Text = settings?.PartsTemplate ?? "";
                TaskcardTemplate.Text = settings?.TaskcardTemplate ?? "";
                XfileOutputDir.Text = settings?.XfileOutputDir ?? "";
                ErrorFileDir.Text = settings?.ErrorFileDir ?? "";
                GeneratedTemplatesDirectory.Text = settings?.GeneratedTemplatesDir ?? "";
            }

            if (File.Exists("VariableSettings.json"))
            {
                string variableSettingsjson = File.ReadAllText("VariableSettings.json");
                VariableSettings variable = JsonConvert.DeserializeObject<VariableSettings>(variableSettingsjson);
                AcRegistr.Text = variable.AcRegistr;
                AircraftNumber.Text = variable.AircraftNumber;
                MsIssue.Text = variable.MsIssue;
                MsName.Text = variable.MsName;
                MsRevision.Text = variable.MsRevision;
            }
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
                ErrorFileDir = ErrorFileDir.Text,
                GeneratedTemplatesDir = GeneratedTemplatesDirectory.Text
            };
            string json = JsonConvert.SerializeObject(settings);
            
            File.WriteAllText("Settings.json", json);

            SaveSettingsText.Text = "Settings Saved!";
        }
        private void btnSaveVariables_Click(object sender, RoutedEventArgs e)
        {
            var settings = new VariableSettings()
            {
                AcRegistr = AcRegistr.Text,
                AircraftNumber = AircraftNumber.Text,
                MsIssue = MsIssue.Text,
                MsName = MsName.Text,
                MsRevision = MsRevision.Text
            };
            string json = JsonConvert.SerializeObject(settings);
            
            File.WriteAllText("VariableSettings.json", json);

            SaveVariableSettingsText.Text = "Variable Values Saved!";
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
            };
            TaskcardTemplateConverter taskcardTemplateConverter = new TaskcardTemplateConverter()
            {
                TemplateLocation = TaskcardTemplate.Text,
                ErrorOutputDirectory = ErrorFileDir.Text,
                XFileOutputDirectory = XfileOutputDir.Text
            };
            
            checkTemplateConverter.Convert();
            documentTemplateConverter.Convert();
            partTemplateConverter.Convert();
            taskcardTemplateConverter.Convert();
            LoadingText.Text = "Templates Converted";
        }

        private void btnGenerateTemplates_Click(object sender, RoutedEventArgs e)
        {
            string templateDirectory = GeneratedTemplatesDirectory.Text;
            TemplateGenerator.Generate<ChecksTemplate>("Checks Template", templateDirectory);
            TemplateGenerator.Generate<DocumentTemplate>("Document Template", templateDirectory);
            TemplateGenerator.Generate<PartTemplate>("Part Template", templateDirectory);
            TemplateGenerator.Generate<TaskcardTemplate>("Taskcard Template", templateDirectory);

            GenerateTemplatesText.Text = "Templates have been generated!";
        }

        private void btnTemplateGenerationLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if(result== true)
            {
                GeneratedTemplatesDirectory.Text = dialog.FileName;
            }
        }

        private void btnErrorFileLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                ErrorFileDir.Text = dialog.FileName;
            }
        }

        private void btnXfileOutputLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                XfileOutputDir.Text = dialog.FileName;
            }
        }

        private void btnTaskcardTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                TaskcardTemplate.Text = dialog.FileName;
            }
        }

        private void btnPartsTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                PartsTemplate.Text = dialog.FileName;
            }
        }

        private void btnDocumentTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                DocumentTemplate.Text = dialog.FileName;
            }
        }

        private void btnCheckTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                CheckTemplate.Text = dialog.FileName;
            }
        }

        private void btnRevertSettings_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Settings.json"))
            {
                string settingsjson = File.ReadAllText("Settings.json");
                Settings settings = JsonConvert.DeserializeObject<Settings>(settingsjson);
                CheckTemplate.Text = settings?.CheckTemplate ?? "";
                DocumentTemplate.Text = settings?.DocumentTemplate ?? "";
                PartsTemplate.Text = settings?.PartsTemplate ?? "";
                TaskcardTemplate.Text = settings?.TaskcardTemplate ?? "";
                XfileOutputDir.Text = settings?.XfileOutputDir ?? "";
                ErrorFileDir.Text = settings?.ErrorFileDir ?? "";
                GeneratedTemplatesDirectory.Text = settings?.GeneratedTemplatesDir ?? "";
            }

            if (File.Exists("VariableSettings.json"))
            {
                string variableSettingsjson = File.ReadAllText("VariableSettings.json");
                VariableSettings variable = JsonConvert.DeserializeObject<VariableSettings>(variableSettingsjson);
                AcRegistr.Text = variable.AcRegistr;
                AircraftNumber.Text = variable.AircraftNumber;
                MsIssue.Text = variable.MsIssue;
                MsName.Text = variable.MsName;
                MsRevision.Text = variable.MsRevision;
            }
        }
    }
}