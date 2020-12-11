using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TestAutomation.Utils
{
    public class Evidence
    {
        string ScreenshotPath_Folder;
        string StoryPath_Folder;
        string ScenarioPath_Folder;
        string DataExecution_Folder;
        string ImagePath;

        public void PrintScreen(string Description, string DataExecution_Folder)
        {
            ImagePath = GenerateImagePath(Description, DataExecution_Folder);
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 40);
            Graphics graphics = Graphics.FromImage(printscreen);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            printscreen.Save(ImagePath, ImageFormat.Jpeg);
        }

        public void Teeste(string UserStory_Name, string Scenario_Name)
        {
                ScreenshotPath_Folder = GenerateFolderScreenshots();
                StoryPath_Folder = GenerateFolderStory(UserStory_Name);
                ScenarioPath_Folder = GenerateFolderScenario(Scenario_Name, UserStory_Name);
            if (DataExecution_Folder == "" || DataExecution_Folder == null)
                DataExecution_Folder = GenerateFolder_DateExecution(Scenario_Name, UserStory_Name);
        }

        public string Tesste_return(string UserStory_Name, string Scenario_Name)
        {
            Teeste(UserStory_Name, Scenario_Name);
            if (!System.IO.Directory.Exists(ScreenshotPath_Folder))
                System.IO.Directory.CreateDirectory(ScreenshotPath_Folder);
            if (!System.IO.Directory.Exists(StoryPath_Folder))
                System.IO.Directory.CreateDirectory(StoryPath_Folder);
            if (!System.IO.Directory.Exists(ScenarioPath_Folder))
                System.IO.Directory.CreateDirectory(ScenarioPath_Folder);
            if (!System.IO.Directory.Exists(DataExecution_Folder))
                System.IO.Directory.CreateDirectory(DataExecution_Folder);
            return DataExecution_Folder;
        }

        private string GenerateFolderScreenshots()
        {
            return Config.CarregaPath_BinFolder() + Path.DirectorySeparatorChar + "ScreenShots";
        }

        private string GenerateFolderStory(string UserStory_Name)
        {
            return GenerateFolderScreenshots() + Path.DirectorySeparatorChar + UserStory_Name;
        }

        private string GenerateFolderScenario(string Scenario_Name, string UserStory_Name)
        {
            return GenerateFolderStory(UserStory_Name) + Path.DirectorySeparatorChar + Scenario_Name;
        }

        private string GenerateFolder_DateExecution(string Scenario_Name, string UserStory_Name)
        {
            return GenerateFolderScenario(Scenario_Name, UserStory_Name) + Path.DirectorySeparatorChar + "Data_" + DateTime.Now.ToString("ddMMyyyyHHmmssff");
        }

        private string GenerateImagePath(string description, string DataExecution_Folder)
        {
            return DataExecution_Folder + Path.DirectorySeparatorChar + description + ".jpg";
        }

        public string GenerateTxtLogPath(string description, string Scenario_Name, string UserStory_Name)
        {
            if (DataExecution_Folder != "" && DataExecution_Folder != null)
                return DataExecution_Folder + Path.DirectorySeparatorChar + description + ".txt";
            else
            {
                DataExecution_Folder = GenerateFolder_DateExecution(Scenario_Name, UserStory_Name);
                if (!System.IO.Directory.Exists(DataExecution_Folder))
                    System.IO.Directory.CreateDirectory(DataExecution_Folder);
                return DataExecution_Folder + Path.DirectorySeparatorChar + description + ".txt";
            }
        }
    }
}
