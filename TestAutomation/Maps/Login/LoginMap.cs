using HP.LFT.SDK;
using HP.LFT.SDK.Web;

namespace TestAutomation.Maps.Login
{
    class LoginMap
    {
        /// <summary>
        /// mapeamento popup "Configurar o Internet Explorer 11"
        /// </summary>
        public HP.LFT.SDK.StdWin.IDialog ConfiguracoesIe()
        {
            return Desktop.Describe<HP.LFT.SDK.StdWin.IDialog>(new HP.LFT.SDK.StdWin.DialogDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                NativeClass = @"#32770",
                Text = @"Internet Explorer 11"
            });
        }

        /// <summary>
        /// Mapeamento referente ao campo de Login
        /// </summary>
        public IEditField CampoLogin(IBrowser browser)
        {
            return browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"Login",
                TagName = @"INPUT",
                Type = @"text"
            });
        }

        /// <summary>
        /// Mapeamento referente ao campo Senha
        /// </summary>
        public IEditField CampoSenha(IBrowser browser)
        {
            return browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"Senha",
                TagName = @"INPUT",
                Type = @"password"
            });

        }

        /// <summary>
        /// Mapeamento referente ao botão Entrar
        /// </summary>
        public IButton EntrarButton(IBrowser browser)
        {
            return browser.Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"submit",
                Name = @"Entrar",
                TagName = @"INPUT"
            });
        }

        /// <summary>
        /// mapeamento da tela inicial, para espera
        /// </summary>
        public IWebElement PagInicial(IBrowser browser)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"principal"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                TagName = @"BODY",
                XPath = @"//BODY"
            });
        }
    }
}
