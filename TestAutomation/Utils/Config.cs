using HP.LFT.SDK.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace TestAutomation.Utils
{
    public class Config
    {
        IBrowser NewBrowser = null;
        BrowserDescription description;
        public Config()
        {
            description = new BrowserDescription();
        }
        

        public static string CarregaRaizProjeto()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string ProjectDirectoryBin = Directory.GetParent(workingDirectory).Parent.FullName;
            return ProjectDirectoryBin;
        }

        public static string CarregaPath_BinFolder()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string ProjectDirectoryBin = Directory.GetParent(workingDirectory).FullName;
            return ProjectDirectoryBin;
        }

        public static void EsperaPaginaCarregar(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constantes.tempo_espera_minute_InSeconds));
            wait.Until(wd => (IJavaScriptExecutor)wd).ExecuteScript("return document.readyState").Equals("complete");
        }

        public IBrowser Return_NewBrowser(string WindowTitle)
        {
            if (description.Title == null)
            {
                description.Title = WindowTitle;
                NewBrowser = BrowserFactory.Attach(description);
                return NewBrowser;
            }
            else
                return NewBrowser;
        }

        public void Close_NewWindow(IBrowser browser)
        {
            browser.Close();
        }
    }
}
