using HP.LFT.SDK.Web;
using HP.LFT.SDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TestAutomation.Data.Acessos;

namespace TestAutomation.Utils
{
    public class BaseTest
    {
        public IBrowser browser;
        public OpenQA.Selenium.IWebDriver driver;
        BrowserType navegador = BrowserType.InternetExplorer;
        Evidence _Evidence;
        Acessos _Acessos;
        public string _UserStory;
        public string _Scenario_Name;
        private static TestContext _testContext;
        string DataExecutionPath_Folder;
        public BaseTest()
        {
            _Acessos = new Acessos();
            _Evidence = new Evidence();
        }

        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }

        [ClassInitialize]
        public static void GlobalSetup(TestContext context)
        {
            _testContext = context;
        }

        [TestInitialize]
        public void BeforeTest()
        {
            _Evidence = new Evidence();
            DataExecutionPath_Folder = _Evidence.Tesste_return(_UserStory, _Scenario_Name);
            _Acessos.GravaJson_DataExecutionPath_Folder(DataExecutionPath_Folder);
            switch (navegador)
            {
                case BrowserType.InternetExplorer:
                    SDK.Init(new SdkConfiguration());
                    //Reporter.Init(new ReportConfiguration());
                    browser = BrowserFactory.Launch(navegador);
                    browser.Sync();
                    //Thread.Sleep(5000);
                    break;
                case BrowserType.Chrome:
                    driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Constantes.tempo_espera_TwoMinutes_InSeconds);
                    break;
            }
        }

        [TestCleanup]
        public void AfterTest()
        {
            File.CreateText(_Evidence.GenerateTxtLogPath(_testContext.CurrentTestOutcome.ToString(), _Scenario_Name, _UserStory));

            switch (navegador)
            {
                case BrowserType.InternetExplorer:
                    browser.Close();
                    //Reporter.GenerateReport();
                    SDK.Cleanup();
                    break;
                case BrowserType.Chrome:
                    if (driver == null)
                        return;
                    driver.Close();
                    driver = null;
                    break;
            }
        }

        public void AlteraNavegador(BrowserType Navegador)
        {
            navegador = Navegador;
        }

        public void GenerateEvidence(string Description, string DataExecution_Folder)
        {
            _Evidence.PrintScreen(Description, DataExecution_Folder);
        }
    }
}
