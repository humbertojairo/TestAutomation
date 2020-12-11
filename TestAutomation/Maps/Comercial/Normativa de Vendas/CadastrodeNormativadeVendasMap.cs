using HP.LFT.SDK.Web;

namespace TestAutomation.Maps.Comercial.Normativa_de_Vendas.Cadastro_de_Normativa_de_Vendas
{
    public class CadastrodeNormativadeVendasMap
    {
        readonly IBrowser browser;
        public CadastrodeNormativadeVendasMap(IBrowser Browser)
        {
            this.browser = Browser;
        }

        /// <summary>
        /// Mapeamento referente ao link "Nova Normativa de Vendas"
        /// </summary>
        public ILink ClickNovaNormativadeVendas(string normativadeVendas)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"pesquisa"
            })
            .Describe<ILink>(new LinkDescription
            {
                InnerText = @"" + normativadeVendas + "",
                TagName = @"A"
            });
        }

        /// <summary>
        /// Mapeamento referente ao popup "Cadastro Normativa de Vendas"
        /// </summary>
        public IWebElement ValidaPopupNovaNormativadeVendas()
        {
            return browser.Describe<HP.LFT.SDK.StdWin.IWindow>(new HP.LFT.SDK.StdWin.WindowDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                WindowClassRegExp = @"Internet Explorer_TridentDlgFrame",
                WindowTitleRegExp = @"Nova Normativa de Vendas -- Caixa de diálogo Página da Web"
            })
            .Describe<IPage>(new PageDescription { })
            .Describe<IFrame>(new FrameDescription
            {
                Name = @"principal2"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                TagName = @"FONT",
                XPath = @"//FIELDSET[@id=""tbl_inc_abre_table""]/CENTER[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/FONT[1]"
            });
        }

        /// <summary>
        /// Mapeamento referente ao popup "Cadastro Normativa de Vendas"
        /// </summary>
        public IWebElement ValidaPopupNormativadeVendasemAndamento()
        {
            return browser.Describe<HP.LFT.SDK.StdWin.IWindow>(new HP.LFT.SDK.StdWin.WindowDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                WindowClassRegExp = @"Internet Explorer_TridentDlgFrame",
                WindowTitleRegExp = @"Pesquisa Normativa de Vendas em Andamento -- Caixa de diálogo Página da Web"
            })
            .Describe<IPage>(new PageDescription { })
            .Describe<IFrame>(new FrameDescription
            {
                Name = @"principal2"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                TagName = @"FONT",
                XPath = @"//FIELDSET[@id=""tbl_inc_abre_table""]/CENTER[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/FONT[1]"
            });
        }

        /// <summary>
        /// Mapeamento referente ao campo "Código normativa de vendas origem"
        /// </summary>
        public IEditField InputCodigoNormativadeVendasOrigem(string campanha)
        {
            return browser.Describe<HP.LFT.SDK.StdWin.IWindow>(new HP.LFT.SDK.StdWin.WindowDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                WindowClassRegExp = @"Internet Explorer_TridentDlgFrame",
                WindowTitleRegExp = @"Nova Normativa de Vendas -- Caixa de diálogo Página da Web"
            })
            .Describe<IPage>(new PageDescription { })
            .Describe<IFrame>(new FrameDescription
            {
                Name = @"principal2"
            })
            .Describe<IEditField>(new EditFieldDescription
            {
                Name = @"" + campanha + "",
                TagName = @"INPUT",
                Type = @"text"
            });
        }

        /// <summary>
        /// Mapeamento referente ao botão Continuar
        /// </summary>
        public IImage ButtonContinuar()
        {
            return browser.Describe<HP.LFT.SDK.StdWin.IWindow>(new HP.LFT.SDK.StdWin.WindowDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                WindowClassRegExp = @"Internet Explorer_TridentDlgFrame",
                WindowTitleRegExp = @"Nova Normativa de Vendas -- Caixa de diálogo Página da Web"
            })
            .Describe<IPage>(new PageDescription { })
            .Describe<IFrame>(new FrameDescription
            {
                Name = @"toolbar2"
            })
            .Describe<IImage>(new ImageDescription
            {
                Alt = @"Continuar",
                TagName = @"IMG",
                Type = ImageType.Normal
            });
        }

        /// <summary>
        /// Mapeamento referente ao botão Ok
        /// </summary>
        public HP.LFT.SDK.StdWin.IButton ButtonOk()
        {
            return browser.Describe<HP.LFT.SDK.StdWin.IWindow>(new HP.LFT.SDK.StdWin.WindowDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                WindowClassRegExp = @"Internet Explorer_TridentDlgFrame",
                WindowTitleRegExp = @"Nova Normativa de Vendas -- Caixa de diálogo Página da Web"
            })
            .Describe<HP.LFT.SDK.StdWin.IDialog>(new HP.LFT.SDK.StdWin.DialogDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                NativeClass = @"#32770",
                Text = @"Mensagem da página da web"
            })
            .Describe<HP.LFT.SDK.StdWin.IButton>(new HP.LFT.SDK.StdWin.ButtonDescription
            {
                NativeClass = @"Button",
                Text = @"OK"
            });
        }

        /// <summary>
        /// Mapeamento referente ao texto no topo da tela Dados Básicos
        /// </summary>
        public IWebElement ValidarAcessoTelaDadosBasicos()
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"I1"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"Dados Básicos",
                TagName = @"FONT"
            });
        }

        /// <summary>
        /// Mapeamento referente aos campos Edit de Dados Básicos
        /// </summary>
        public IEditField InputDadosBasicos(string frame, string campo)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"" + frame + ""
            })
            .Describe<IEditField>(new EditFieldDescription
            {
                Name = @"" + campo + "",
                TagName = @"INPUT",
                Type = @"text"
            });
        }

        /// <summary>
        /// Mapeamento referente aos campos Check de Dados Básicos
        /// </summary>
        public ICheckBox CheckDadosBasicos(string frame, string campo)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"" + frame + ""
            })
            .Describe<ICheckBox>(new CheckBoxDescription
            {
                Name = @"" + campo + "",
                TagName = @"INPUT",
                Type = @"checkbox"
            });
        }

        /// <summary>
        /// Mapeamento referente aos campos de Select de Dados Básicos
        /// </summary>
        public IListBox SelectDadosBasicos(string frame, string campo)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"" + frame + ""
            })
            .Describe<IListBox>(new ListBoxDescription
            {
                Name = @"" + campo + "",
                TagName = @"SELECT"
            });
        }

        /// <summary>
        /// Mapeamento referente aos campos de Select de Dados Básicos
        /// </summary>
        public IListBox SelectDadosBasicosPlano()
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"I3"
            })
            .Describe<IListBox>(new ListBoxDescription
            {
                Name = @"cod_plano",
                TagName = @"SELECT",
                XPath = @"//FIELDSET[@id=""tbl_inc_abre_table""]/CENTER[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/FORM[1]/TABLE[2]/TBODY[1]/TR[1]/TD[2]/SELECT[1]"
            });
        }

        /// <summary>
        /// Mapeamento referente ao botão alterar
        /// </summary>
        public IImage ButtonIncluirAlterar(string opcao)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"toolbarsubmenu"
            })
            .Describe<IImage>(new ImageDescription
            {
                Alt = @"" + opcao + "",
                TagName = @"IMG",
                Type = HP.LFT.SDK.Web.ImageType.Normal
            });
        }

        /// <summary>
        /// Mapeamento referente a mensagens na tela
        /// </summary>
        public IWebElement LabelMensagens()
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"pesquisa"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"Operação realizada com sucesso.",
                TagName = @"DIV"
            });
        }

        /// <summary>
        /// Mapeamento referente ao botão Ok
        /// </summary>
        public IRadioGroup SelectRadioTipoContratacao()
        {
            return browser.Describe<HP.LFT.SDK.StdWin.IWindow>(new HP.LFT.SDK.StdWin.WindowDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                WindowClassRegExp = @"Internet Explorer_TridentDlgFrame",
                WindowTitleRegExp = @"Nova Normativa de Vendas -- Caixa de diálogo Página da Web"
            })
            .Describe<IPage>(new PageDescription { })
            .Describe<IFrame>(new FrameDescription
            {
                Name = @"principal2"
            })
            .Describe<IRadioGroup>(new RadioGroupDescription
            {
                Name = @"tipo_contratacao",
                TagName = @"INPUT"
            });
        }

        /// <summary>
        /// Mapeamento referente ao botão Ok
        /// </summary>
        public ILink ClicaSubMenu(string subMenu)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"submenu"
            })
            .Describe<ILink>(new LinkDescription
            {
                InnerText = @"" + subMenu + "",
                TagName = @"A"
            });
        }

        /// <summary>
        /// Mapeamento referente ao botão Ok
        /// </summary>
        public IButton ButtonAdicionar(string frame)
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"" + frame + ""
            })
            .Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"button",
                Name = @"Adicionar",
                TagName = @"INPUT"
            });
        }

        /// <summary>
        /// Mapeamento referente a mensagem Operação realizada com sucesso.
        /// </summary>
        public IWebElement Mensagem()
        {
            return browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"pesquisa"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                InnerText = @"Operação realizada com sucesso.",
                TagName = @"DIV"
            });
        }

        /// <summary>
        /// Mapeamento referente a grade de Pesquisa de Vendas em Andamento
        /// </summary>
        public IWebElement SelecionaNormativadeVendasemAndamento()
        {
            return browser.Describe<HP.LFT.SDK.StdWin.IWindow>(new HP.LFT.SDK.StdWin.WindowDescription
            {
                IsChildWindow = false,
                IsOwnedWindow = true,
                WindowClassRegExp = @"Internet Explorer_TridentDlgFrame",
                WindowTitleRegExp = @"Pesquisa Normativa de Vendas em Andamento -- Caixa de diálogo Página da Web"
            })
            .Describe<IPage>(new PageDescription { })
            .Describe<IFrame>(new FrameDescription
            {
                Name = @"principal2"
            })
            .Describe<ILink>(new LinkDescription
            {
                //InnerText = @"419218 - BLUE 400 NAC QP PF LIMINAR",
                TagName = @"A",
                XPath = @"//FIELDSET[@id=""tbl_inc_abre_table""]/CENTER[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/TABLE[1]/TBODY[1]/TR[1]/TD[1]/FORM[1]/TABLE[1]/TBODY[1]/TR[2]/TD[2]/A[1]"
            });
        }

        /// <summary>
        /// Mapemento referente ao popup Pendência
        /// </summary>
        /// <returns></returns>
        public IWebElement ClicaPopupPendencias(IBrowser Browser)
        {
            return Browser.Describe<IFrame>(new FrameDescription
            {
                Name = @"toolbar2"
            })
            .Describe<IWebElement>(new WebElementDescription
            {
                TagName = @"DIV",
                XPath = @"//DIV[1]"
            });
        }
    }
}