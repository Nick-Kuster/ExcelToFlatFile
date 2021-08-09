using System.IO;
using System.Windows;
using System.Windows.Forms;
using ExcelToFlatFile.Application.TemplateGenerators;
using ExcelToFlatFile.Application.XFileConverters;
using ExcelToFlatFileFramework.Domain.InTemplates;
using Newtonsoft.Json;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

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
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = GeneratedTemplatesDirectory.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                GeneratedTemplatesDirectory.Text = dialog.FileName;
            }
            //var dialog = new FolderBrowserDialog();
            //DialogResult result = dialog.ShowDialog();
            //if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            //{
            //    GeneratedTemplatesDirectory.Text = dialog.SelectedPath;
            //}
        }

        private void btnErrorFileLocation_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = ErrorFileDir.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ErrorFileDir.Text = dialog.FileName;
            }
        }

        private void btnXfileOutputLocation_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = XfileOutputDir.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                XfileOutputDir.Text = dialog.FileName;
            }
        }

        private void btnTaskcardTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Path.GetDirectoryName(TaskcardTemplate.Text);
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TaskcardTemplate.Text = dialog.FileName;
            }
        }

        private void btnPartsTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Path.GetDirectoryName(PartsTemplate.Text);
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                PartsTemplate.Text = dialog.FileName;
            }
        }

        private void btnDocumentTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Path.GetDirectoryName(DocumentTemplate.Text);
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DocumentTemplate.Text = dialog.FileName;
            }
        }

        private void btnCheckTemplateLocation_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Path.GetDirectoryName(CheckTemplate.Text);
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
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