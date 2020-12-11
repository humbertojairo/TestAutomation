using HP.LFT.SDK.Web;

namespace TestAutomation.Maps.Menu.Comercial
{
    public class ComercialMenuMap
    {
        readonly IBrowser browser;
        public ComercialMenuMap(IBrowser Browser)
        {
            this.browser = Browser;
        }

        /// <summary>
        /// Mapeamento referente ao menu principal "Comercial".
        /// </summary>
        public IWebElement MenuComercial()
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"menu"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"Comercial",
                TagName = @"A",
                XPath = @"//DIV[@id=""menuSistema""]/H1[11]/A[1]"
            });
        }

        #region Submenu Normativa de Vendas
        /// <summary>
        /// Mapeamento referente ao SubMenu "Normativa de Vendas"
        /// </summary>
        public IWebElement SubMenuComercial(string submenu)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"menu"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"" + submenu + "",
                TagName = @"A"
            });
        }

        /// <summary>
        /// Mapeamento referente ao Item de menu "Cadastro Normativa de Vendas"
        /// </summary>
        public IWebElement ItemMenuComercial(string itemMenu)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"menu"
            })
            .Describe<ILink>(new LinkDescription
            {
                InnerText = @"" + itemMenu + "",
                TagName = @"A"
            });
        }
        #endregion Submenu Normativa de Vendas
    }
}