using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using TestAutomation.Maps.Menu.Menu;

namespace TestAutomation.Pages.Menu.Menu
{
    public class MenuPage
    {
        IBrowser browser;
        MenuMap _MenuMap;

        public MenuPage(IBrowser Browser)
        {
            this.browser = Browser;
            _MenuMap = new MenuMap(browser);
        }

        /// <summary>
        /// Metodo responsavel clicar no Menu
        /// </summary>
        public void AcessarMenu()
        {
            _MenuMap.AcessarMenu(browser).WaitUntilExists(10);
            _MenuMap.AcessarMenu(browser).Click();
        }
    }
}
