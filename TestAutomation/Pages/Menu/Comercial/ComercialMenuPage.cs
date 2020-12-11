using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using TestAutomation.Maps.Menu.Comercial;

namespace TestAutomation.Pages.Menu.Comercial
{
    public class ComercialMenuPage
    {
        IBrowser browser;
        ComercialMenuMap ComercialMenuMap;

        public ComercialMenuPage(IBrowser Browser)
        {
            this.browser = Browser;
            ComercialMenuMap = new ComercialMenuMap(browser);
        }

        /// <summary>
        ///Clica na opção do menu Comercial
        /// </summary>
        public void ClicaMenuComercial()
        {
            ComercialMenuMap.MenuComercial().WaitUntilExists(50);
            ComercialMenuMap.MenuComercial().Click();
        }

        /// <summary>
        ///Clica na opção do menu de acordo com string passada
        /// </summary>
        public void ClicaSubMenuComercial(string submenu)
        {
            ComercialMenuMap.SubMenuComercial(submenu).WaitUntilExists(50);
            ComercialMenuMap.SubMenuComercial(submenu).Click();
        }

        /// <summary>
        ///Clica na opção do item de menu Normativa de Vendas
        /// </summary>
        public void ClicaItemMenuComercial(string itemMenu)
        {
            ComercialMenuMap.ItemMenuComercial(itemMenu).WaitUntilExists(50);
            ComercialMenuMap.ItemMenuComercial(itemMenu).Click();
        }
    }
}