using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Utils;
using TestAutomation.Pages.Login;
using TestAutomation.Data.Acessos;
using TestAutomation.Pages.Menu.Menu;
using TestAutomation.Pages.Menu.Comercial;
using TestAutomation.Pages.Comercial.Normativa_de_Vendas.Cadastro_de_Normativa_de_Vendas;
using TestAutomation.DAO.Operations.Comercial.Normativa_de_Vendas.Cadastro_de_Normativa_de_Vendas._94308;

namespace TestAutomation.Scenarios.Comercial.Normativa_de_Vendas.Cadastro_de_Normativa_de_Vendas._94307
{
    [TestClass]
    public class UI001_1_NovaNormativaDeVendas : BaseTest
    {
        Acessos acessos;

        public UI001_1_NovaNormativaDeVendas()
        {
            acessos = new Acessos();
            acessos.AmbientesCaseTestAutomation();
        }

        [TestMethod]
        public void UI0001_1_NovaNormativaDeVendas()
        {
            Console.WriteLine("Comercial");
            Console.WriteLine("92461 - UI001.1 - Cadastro Normativa de Venda - Nova Normativa de Vendas (Informe uma normativa de vendas a ser copiada)- Validar funcionalidades (Smoke Test)");

            //Faz login
            LoginPage login = new LoginPage(browser);
            login.Login(acessos.UrlTestAutomation, acessos.UsuarioTestAutomation, acessos.SenhaTestAutomation);

            //Acessa o Menu
            MenuPage menu = new MenuPage(browser);
            menu.AcessarMenu();

            //Entra em Comercial >> Normativa de Vendas >> Normativa de Vendas
            ComercialMenuPage comercialMenuPage = new ComercialMenuPage(browser);
            comercialMenuPage.ClicaMenuComercial();
            comercialMenuPage.ClicaSubMenuComercial("Normativa de Vendas");
            comercialMenuPage.ClicaItemMenuComercial("Cadastro de Normativa de Vendas");

            //Acessa janela Nova normativa de vendas
            CadastrodeNormativadeVendasPage cadastrodeNormativadeVendasPage = new CadastrodeNormativadeVendasPage(browser);
            cadastrodeNormativadeVendasPage.AcessaNovaNormativadeVendas("Nova normativa de vendas");

            //Preenche código normativa de vendas origem
            CadastrodeNormativadeVendasDao cadastrodeNormativadeVendasDao = new CadastrodeNormativadeVendasDao();
            cadastrodeNormativadeVendasPage.PreencheCodigoNormativadeVendasOrigem(cadastrodeNormativadeVendasDao.RetornaQuery());

            //Preenche código normativa de vendas origem
            cadastrodeNormativadeVendasPage.PreencheNovaNormativadeVendas("Teste automatizado nova normativa");

            //Clica no botão Continuar
            cadastrodeNormativadeVendasPage.ClicaBotaoContinuar();

            //Altera campo Nome
            cadastrodeNormativadeVendasPage.AlteraNome();

            //Confirmar 
            cadastrodeNormativadeVendasPage.ConfirmarAlteracao();
        }
    }
}