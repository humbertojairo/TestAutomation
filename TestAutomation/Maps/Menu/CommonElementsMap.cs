using HP.LFT.SDK;
using HP.LFT.SDK.Web;

namespace TestAutomation.Maps.Menu
{
    public class CommonElementsMap
    {
        /// <summary>
        /// mapeamento do botao do menu 
        /// </summary>
        public IWebElement BotaoMenu(IBrowser browser)
        {
            return browser.Describe<IImage>(new ImageDescription
            {
                TagName = @"IMG",
                XPath = @"//DIV[@id=""mostraMenu""]/IMG[1]"
            });

        }

        /// <summary>
        /// mapeamento do botao Alterar
        /// </summary>
        public IWebElement BotaoAlterar(IBrowser browser)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"toolbar"
            })
            .Describe<IImage>(new ImageDescription
            {
                Alt = @"Alterar",
                XPath = @"//SPAN[@id=""btn_acao_alterar""]/IMG[1]"
            });
        }

        /// <summary>
        /// mapeamento do botao Voltar
        /// </summary>
        public IWebElement BotaoVoltar(IBrowser browser)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"toolbar"
            })
            .Describe<IImage>(new ImageDescription
            {
                Alt = @"Voltar"
            });
        }

        /// <summary>
        /// mapeamento da mensagem "Operação realizada com sucesso"
        /// </summary>
        public IWebElement MsgOperacaoRealizadaComSucesso(IBrowser browser)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"principal"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"Operação realizada com sucesso",
                XPath = @"//DIV[@id=""txt_msg""]"
            });
        }
    }
}
