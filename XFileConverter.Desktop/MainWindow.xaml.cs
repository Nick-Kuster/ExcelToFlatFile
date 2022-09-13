using System.IO;
using System.Windows;
using ExcelToFlatFile.Application.Converters;
using ExcelToFlatFile.Application.TemplateGenerators;
using ExcelToFlatFileFramework.Domain.InTemplates;
using Newtonsoft.Json;
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
                InputFile.Text = settings?.InputFile ?? "";
                OutputDirectory.Text = settings?.OutputDirectory ?? "";
                ErrorFileDir.Text = settings?.ErrorFileDir ?? "";
                GeneratedTemplatesDirectory.Text = settings?.GeneratedTemplatesDir ?? "";
            }

            if (File.Exists("VariableSettings.json"))
            {
                string variableSettingsjson = File.ReadAllText("VariableSettings.json");
                VariableSettings variable = JsonConvert.DeserializeObject<VariableSettings>(variableSettingsjson);
                Aircraft.Text = variable.Aircraft;
                Station.Text = variable.Station;
                WorkPackageName.Text = variable.WorkPackageName;
                ShortDescription.Text = variable.ShortDescription;
                StartDate.Text = variable.StartDate;
                StartTime.Text = variable.StartTime;
                EndDate.Text = variable.EndDate;
                EndTime.Text = variable.EndTime;
            }
        }

        private void btnSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            var settings = new Settings
            {
                InputFile = InputFile.Text,
                OutputDirectory = OutputDirectory.Text,
                ErrorFileDir = ErrorFileDir.Text,
                GeneratedTemplatesDir = GeneratedTemplatesDirectory.Text
            };
            string json = JsonConvert.SerializeObject(settings);
            
            File.WriteAllText("Settings.json", json);

            SaveSettingsText.Text = "Settings Saved!";
        }
        private void btnSaveVariables_Click(object sender, RoutedEventArgs e)
        {
            var settings = new VariableSettings
            {
                Aircraft = Aircraft.Text,
                Station = Station.Text,
                WorkPackageName = WorkPackageName.Text,
                ShortDescription = ShortDescription.Text,
                StartDate = StartDate.Text,
                StartTime = StartTime.Text,
                EndDate = EndDate.Text,
                EndTime = EndTime.Text
            };
            string json = JsonConvert.SerializeObject(settings);
            
            File.WriteAllText("VariableSettings.json", json);

            SaveVariableSettingsText.Text = "Variable Values Saved!";
        }
        private void btnConverToXFiles_Click(object sender, RoutedEventArgs e)
        {
            WpTemplateConverter wpTemplateConverter = new WpTemplateConverter()
            {
                OutputDirectory = OutputDirectory.Text,
                ErrorOutputDirectory = ErrorFileDir.Text,
                InputLocation = InputFile.Text
            };
            wpTemplateConverter.Convert();
            LoadingText.Text = "Templates Converted";
        }

        private void btnGenerateTemplates_Click(object sender, RoutedEventArgs e)
        {
            string templateDirectory = GeneratedTemplatesDirectory.Text;
            TemplateGenerator.Generate<WPImportInput>("WP Template", templateDirectory);

            GenerateTemplatesText.Text = "Templates have been generated!";
        }

        private void btnTemplateGenerationLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                InitialDirectory = GeneratedTemplatesDirectory.Text ?? "", IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                GeneratedTemplatesDirectory.Text = dialog.FileName;
            }
        }

        private void btnErrorFileLocation_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            if (!string.IsNullOrWhiteSpace(ErrorFileDir.Text))
            {
                dialog.InitialDirectory = ErrorFileDir.Text;
            }

            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ErrorFileDir.Text = dialog.FileName;
            }
        }

        private void btnOutput_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            if (!string.IsNullOrWhiteSpace(OutputDirectory.Text))
            {
                dialog.InitialDirectory = OutputDirectory.Text;
            }

            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                OutputDirectory.Text = dialog.FileName;
            }
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            if (!string.IsNullOrWhiteSpace(InputFile.Text))
            {
                dialog.InitialDirectory = Path.GetDirectoryName(InputFile.Text);
            }
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                InputFile.Text = dialog.FileName;
            }
        }

        private void btnRevertSettings_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Settings.json"))
            {
                string settingsjson = File.ReadAllText("Settings.json");
                Settings settings = JsonConvert.DeserializeObject<Settings>(settingsjson);
                InputFile.Text = settings?.InputFile ?? "";
                OutputDirectory.Text = settings?.OutputDirectory ?? "";
                ErrorFileDir.Text = settings?.ErrorFileDir ?? "";
                GeneratedTemplatesDirectory.Text = settings?.GeneratedTemplatesDir ?? "";
            }

            if (File.Exists("VariableSettings.json"))
            {
                string variableSettingsjson = File.ReadAllText("VariableSettings.json");
                VariableSettings variable = JsonConvert.DeserializeObject<VariableSettings>(variableSettingsjson);
                Aircraft.Text = variable.Aircraft;
                Station.Text = variable.Station;
                WorkPackageName.Text = variable.WorkPackageName;
                ShortDescription.Text = variable.ShortDescription;
                StartDate.Text = variable.StartDate;
                StartTime.Text = variable.StartTime;
                EndDate.Text = variable.EndDate;
                EndTime.Text = variable.EndTime;
            }
        }
    }
}