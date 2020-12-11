using TestAutomation.Maps.Login;
using TestAutomation.Utils;
using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using System.Threading;
using TestAutomation.Maps.Menu;
using System;
using TestAutomation.Data.Acessos;

namespace TestAutomation.Pages.Login
{
    public class LoginPage : BaseTest
    {
        LoginMap loginMap;
        CommonElementsMap commonElementsMap;
        BaseTest _BaseTest;
        Path_DataExecutionPath_Folder _Path_DataExecutionPath_Folder;

        public LoginPage(IBrowser browser)
        {
            this.browser = browser;
            loginMap = new LoginMap();
            commonElementsMap = new CommonElementsMap();
            _BaseTest = new BaseTest();
            _Path_DataExecutionPath_Folder = Acessos.Retorna_Path_DataExecutionPath_Folder();
        }

        /// <summary>
        /// Metodo responsavel por fazer o login
        /// </summary>
        public void Login(string url, string login, string senha)
        {
            if (loginMap.ConfiguracoesIe().Exists())
            {
                loginMap.ConfiguracoesIe().Close();
            }
            browser.Navigate(url);
            loginMap.CampoLogin(browser).SetValue(login);
            loginMap.CampoSenha(browser).SetValue(senha);
            //_evidence.PrintScreen("Usuarios");
            _BaseTest.GenerateEvidence("Usuarios", _Path_DataExecutionPath_Folder.path_DataExecutionPath_Folder);
            loginMap.EntrarButton(browser).Click();
            loginMap.PagInicial(browser).WaitUntilExists(50);
            Thread.Sleep(5000);
            commonElementsMap.BotaoMenu(browser).Click();
            //_evidence.PrintScreen("Menu");
            _BaseTest.GenerateEvidence("Menu", _Path_DataExecutionPath_Folder.path_DataExecutionPath_Folder);
            Thread.Sleep(2000);
        }
    }
}
