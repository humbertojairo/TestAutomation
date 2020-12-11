using HP.LFT.SDK.Web;

namespace TestAutomation.Maps.Menu.Menu
{
    public class MenuMap
    {
        readonly IBrowser browser;
        public MenuMap(IBrowser Browser)
        {
            this.browser = Browser;
        }

        /// <summary>
        /// Mapeamento referente ao botão de abrir o Menu
        /// </summary>
        public IImage AcessarMenu(IBrowser browser)
        {
            return browser.Describe<IImage>(new ImageDescription
            {
                Alt = string.Empty,
                Index = 2,
                TagName = @"IMG",
                Type = HP.LFT.SDK.Web.ImageType.Normal
            });
        }
    }
}
