using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using TestAutomation.Utils;
using System;
using System.Threading;
using TestAutomation.Maps.Comercial.Normativa_de_Vendas.Cadastro_de_Normativa_de_Vendas;
using System.Windows.Forms;

namespace TestAutomation.Pages.Comercial.Normativa_de_Vendas.Cadastro_de_Normativa_de_Vendas
{
    public class CadastrodeNormativadeVendasPage
    {
        readonly IBrowser browser;
        CadastrodeNormativadeVendasMap _cadastrodeNormativadeVendasMap;
        readonly Config _config;

        public CadastrodeNormativadeVendasPage(IBrowser Browser)
        {
            //this._acessos = Acessos;
            this.browser = Browser;
            _cadastrodeNormativadeVendasMap = new CadastrodeNormativadeVendasMap(browser);
            _config = new Config();

        }

        /// <summary>
        /// Valida janela aberta Nova Normativa de Vendas
        /// </summary>
        public void ValidaNovaNormativadeVendas()
        {
            try
            {
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Nova normativa de vendas").WaitUntil(ClickNovaNormativadeVendas => _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Nova normativa de vendas").Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Nova normativa de vendas").IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Nova normativa de vendas").Click();
                _cadastrodeNormativadeVendasMap.ValidaPopupNovaNormativadeVendas().Click();
                if (!_cadastrodeNormativadeVendasMap.ValidaPopupNovaNormativadeVendas().InnerText.Equals("Nova Normativa de Vendas"))
                    throw new Exception("Nao foi possivel encontrar a janela Nova Normativa de Vendas");
                SendKeys.SendWait("%{F4}");
            }
            catch (Exception Ex)
            {
                SendKeys.SendWait("%{F4}");
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Valida janela aberta Normativa de Vendas com reajuste de preços
        /// </summary>
        public void ValidaNormativadeVendascomReajustedePrecos()
        {
            try
            {
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas com reajuste de preços").WaitUntil(ClickNovaNormativadeVendas => _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas com reajuste de preços").Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas com reajuste de preços").IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas com reajuste de preços").Click();
                _cadastrodeNormativadeVendasMap.ValidaPopupNovaNormativadeVendas().Click();
                if (!_cadastrodeNormativadeVendasMap.ValidaPopupNovaNormativadeVendas().InnerText.Equals("Nova Normativa de Vendas"))
                    throw new Exception("Nao foi possivel encontrar a janela Nova Normativa de Vendas");
                SendKeys.SendWait("%{F4}");
            }
            catch (Exception Ex)
            {
                SendKeys.SendWait("%{F4}");
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Valida janela aberta Normativa de Vendas em Andamento
        /// </summary>
        public void ValidaNormativadeVenddasemAndamento()
        {
            try
            {
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas em andamento").WaitUntil(ClickNovaNormativadeVendas => _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas em andamento").Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas em andamento").IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas("Normativa de vendas em andamento").Click();
                _cadastrodeNormativadeVendasMap.ValidaPopupNormativadeVendasemAndamento().Click();
                if (!_cadastrodeNormativadeVendasMap.ValidaPopupNormativadeVendasemAndamento().InnerText.Equals("Pesquisa Normativa de Vendas em Andamento"))
                    throw new Exception("Nao foi possivel encontrar a janela Pesquisa Normativa de Vendas em Andamento");
                SendKeys.SendWait("%{F4}");
                Thread.Sleep(2000);
            }
            catch (Exception Ex)
            {
                SendKeys.SendWait("%{F4}");
                Thread.Sleep(2000);
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Acessa janela Nova Normativa de Vendas
        /// </summary>
        public void AcessaNovaNormativadeVendas(string normativa)
        {
            try
            {
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas(normativa).WaitUntil(ClickNovaNormativadeVendas => ClickNovaNormativadeVendas.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && ClickNovaNormativadeVendas.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.ClickNovaNormativadeVendas(normativa).Click();
                
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Preenche campo Código Normativa de Vendas Origem
        /// </summary>
        public void PreencheCodigoNormativadeVendasOrigem(string cod_campanha)
        {
            try
            {
                _cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("cod_campanha").WaitUntil(InputCodigoNormativadeVendasOrigem => InputCodigoNormativadeVendasOrigem.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputCodigoNormativadeVendasOrigem.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("cod_campanha").SetValue(cod_campanha);
                if (!_cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("cod_campanha").Value.Equals(cod_campanha))
                    throw new Exception("Nao foi possivel encontrar o código normativa de vendas Origem");
            }
            catch (Exception Ex)
            {
                SendKeys.SendWait("%{F4}");
                Thread.Sleep(2000);
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Preenche campo Nova normativa de vendas
        /// </summary>
        public void PreencheNovaNormativadeVendas(string normativa)
        {
            try
            {
                _cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("nome_campanha_nova").WaitUntil(InputCodigoNormativadeVendasOrigem => InputCodigoNormativadeVendasOrigem.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputCodigoNormativadeVendasOrigem.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("nome_campanha_nova").SetValue(normativa);
                if (!_cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("nome_campanha_nova").Value.Equals(normativa))
                    throw new Exception("Nao foi possivel preencher o campo Nova normativa de vendas");
            }
            catch (Exception Ex)
            {
                SendKeys.SendWait("%{F4}");
                Thread.Sleep(2000);
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Preenche campo Nova normativa de vendas
        /// </summary>
        public void ClicaBotaoContinuar()
        {
            try
            {
                _cadastrodeNormativadeVendasMap.ButtonContinuar().WaitUntil(ButtonContinuar => ButtonContinuar.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && ButtonContinuar.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.ButtonContinuar().Click();
                _cadastrodeNormativadeVendasMap.ButtonOk().WaitUntil(ButtonContinuar => ButtonContinuar.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && ButtonContinuar.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.ButtonOk().Click();

                if (!_cadastrodeNormativadeVendasMap.ValidarAcessoTelaDadosBasicos().InnerText.Equals("Dados Básicos"))
                    throw new Exception("Nao foi possivel confirmar inclusão de nova normativa de vendas");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }


        /// <summary>
        /// Preenche campo Nome
        /// </summary>
        public void AlteraNome()
        {
            try
            {
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "nome_campanha").WaitUntil(InputDadosBasicos => InputDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "nome_campanha").SetValue("Testes automatizados");
                if (_cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "dt_ini_campanha").Value.Equals(""))
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "dt_ini_campanha").SetValue(DateTime.Now.ToString("dd/MM/yyyy"));

                if (!_cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "nome_campanha").Value.Equals("Testes automatizados"))
                    throw new Exception("Nao foi possivel confirmar inclusão de nova normativa de vendas");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Confirmar alteração
        /// </summary>
        public void ConfirmarAlteracao()
        {
            try
            {
                
                _cadastrodeNormativadeVendasMap.ButtonIncluirAlterar("Alterar").WaitUntil(ButtonAlterar => ButtonAlterar.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && ButtonAlterar.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.ButtonIncluirAlterar("Alterar").Click();
                Thread.Sleep(20000);
                if (!_cadastrodeNormativadeVendasMap.LabelMensagens().InnerText.Equals("Operação realizada com sucesso."))
                    throw new Exception("Nao foi possivel confirmar inclusão de nova normativa de vendas");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Selecionar opção Tipo Contratação
        /// </summary>
        public void SelecionaTipoContratacao(string tipoContratacao)
        {
            try
            {
                if (tipoContratacao.Equals("Individual"))
                {
                    _cadastrodeNormativadeVendasMap.SelectRadioTipoContratacao().WaitUntil(SelectRadioTipoContratacao => SelectRadioTipoContratacao.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectRadioTipoContratacao.IsVisible.Equals(true));
                    _cadastrodeNormativadeVendasMap.SelectRadioTipoContratacao().DoubleClick();
                }
                else if (tipoContratacao.Equals("Coletivos"))
                {
                    _cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("nome_campanha_nova").WaitUntil(InputCodigoNormativadeVendasOrigem => InputCodigoNormativadeVendasOrigem.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputCodigoNormativadeVendasOrigem.IsVisible.Equals(true));
                    _cadastrodeNormativadeVendasMap.InputCodigoNormativadeVendasOrigem("nome_campanha_nova").Click();
                    Thread.Sleep(3000);
                    Keyboard.PressKey(Keyboard.Keys.Tab);
                    Keyboard.PressKey(Keyboard.Keys.Tab);
                    Keyboard.PressKey(Keyboard.Keys.Right);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Preencher dados
        /// </summary>
        public void PreencherDados(string tipoContratacao, string plano)
        {
            try
            {
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "nome_campanha").WaitUntil(InputDadosBasicos => InputDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "nome_campanha").SetValue("Teste Inclusão Automatizado");
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I1", "cod_operadora").Select("AMIL");
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I1", "cod_inspetoria_ts").Select("BAHIA - SALVADOR");
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "dt_ini_campanha").SetValue(DateTime.Now.ToString("dd/MM/yyyy"));
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "dt_fim_campanha").SetValue(DateTime.Now.ToString("dd/MM/yyyy"));
                if (tipoContratacao.Equals("Individual"))
                    _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I1", "cod_tipo_contrato_saude").Select("600APF");
                else if (tipoContratacao.Equals("Coletivos"))
                    _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I1", "cod_tipo_contrato_saude").Select("600APME");
                _cadastrodeNormativadeVendasMap.CheckDadosBasicos("I1", "ind_tipo_venda_1").DoubleClick();
                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Planos Oferecidos").Click();
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I2", "cod_plano_1").WaitUntil(InputDadosBasicos => InputDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputDadosBasicos.IsVisible.Equals(true));
                if (tipoContratacao.Equals("Individual"))
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I2", "cod_plano_1").SetValue("589601");
                else if (tipoContratacao.Equals("Coletivos"))
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I2", "cod_plano_1").SetValue("63183");

                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Preços").Click();
                Thread.Sleep(30000);
                _cadastrodeNormativadeVendasMap.SelectDadosBasicosPlano().WaitUntil(SelectDadosBasicosPlano => _cadastrodeNormativadeVendasMap.SelectDadosBasicosPlano().Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && _cadastrodeNormativadeVendasMap.SelectDadosBasicosPlano().IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicosPlano().Select(plano);
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("frmPreco_1", "ind_tipo_valor").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("frmPreco_1", "ind_tipo_valor").Select("Per capita");
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("frmPreco_1", "val_taxa_adesao").WaitUntil(InputDadosBasicos => InputDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("frmPreco_1", "val_taxa_adesao").SetValue("100");
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("frmPreco_1", "val_taxa_adesao_agr").SetValue("100");
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("frmPreco_1", "val_taxa_adesao_dep").SetValue("100");
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("frmPreco_1", "val_adesao_familiar").SetValue("100");
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("frmPreco_1", "val_per_capita").SetValue("1350");
                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Cobertura").Click();
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I4", "cod_plano").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I4", "cod_plano").Select(plano);
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I4", "cod_grupo_cobertura_1").Select("Padrão");
                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Carência").Click();
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I5", "cod_plano").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I5", "cod_plano").Select(plano);
                _cadastrodeNormativadeVendasMap.ButtonAdicionar("I5").Click();
                if (tipoContratacao.Equals("Individual"))
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I5", "cod_grupo_carencia_1_2").SetValue("2");
                else if (tipoContratacao.Equals("Coletivos"))
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I5", "cod_grupo_carencia_1_2").SetValue("4");
                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Dependência").Click();
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I6", "cod_plano").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I6", "cod_plano").Select(plano);
                _cadastrodeNormativadeVendasMap.ButtonAdicionar("I6").Click();
                if (tipoContratacao.Equals("Individual"))
                {
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I6", "cod_dependencia_1_6").SetValue("8");
                    _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I6", "ind_tipo_dependente_1_6").Select("Dependente");
                }
                else if (tipoContratacao.Equals("Coletivos"))
                {
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I6", "cod_dependencia_1_5").SetValue("8");
                    _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I6", "ind_tipo_dependente_1_5").Select("Dependente");
                }
                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Benefícios/Vantagens").Click();
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I7", "cod_plano").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I7", "cod_plano").Select(plano);
                _cadastrodeNormativadeVendasMap.ButtonAdicionar("I7").Click();
                if (tipoContratacao.Equals("Individual"))
                {
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I7", "cod_aditivo_1_2").SetValue("286");
                    _cadastrodeNormativadeVendasMap.CheckDadosBasicos("I7", "ind_titular_1_2").DoubleClick();
                    _cadastrodeNormativadeVendasMap.CheckDadosBasicos("I7", "ind_dependente_1_2").DoubleClick();
                }
                else if (tipoContratacao.Equals("Coletivos"))
                {
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I7", "cod_aditivo_1_1").SetValue("286");
                    _cadastrodeNormativadeVendasMap.CheckDadosBasicos("I7", "ind_titular_1_1").DoubleClick();
                    _cadastrodeNormativadeVendasMap.CheckDadosBasicos("I7", "ind_dependente_1_1").DoubleClick();
                }
                _cadastrodeNormativadeVendasMap.ButtonIncluirAlterar("Incluir").Click();
                if (tipoContratacao.Equals("Individual"))
                {
                    _cadastrodeNormativadeVendasMap.ClicaSubMenu("Reembolso").Click();
                    _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I8", "cod_plano").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                    _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I8", "cod_plano").Select(plano);
                    _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I8", "sigla_tabela_reembolso_1").Select("AMILPAR - REEMBOLSO");
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I8", "prazo_reembolso_1").SetValue("15");
                    _cadastrodeNormativadeVendasMap.InputDadosBasicos("I8", "cod_grupo_reembolso_1").SetValue("1");
                }
                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Participação").Click();
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I9", "cod_plano").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I9", "cod_plano").Select(plano);
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I9", "val_max_desc_benef_1").SetValue("10");
                _cadastrodeNormativadeVendasMap.ClicaSubMenu("Opcionais").Click();
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I10", "cod_aditivo_1").WaitUntil(SelectDadosBasicos => SelectDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelectDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I10", "cod_aditivo_1").Select("ACIDENTE TRABALHO");
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I10", "cod_tipo_contratacao_1").Select("Por Beneficiário");
                _cadastrodeNormativadeVendasMap.SelectDadosBasicos("I10", "ind_tipo_preco_1").Select("Isento");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Confirmar dados
        /// </summary>
        public void ConfirmarDados()
        {
            try
            {
                Thread.Sleep(10000);
                _cadastrodeNormativadeVendasMap.ButtonIncluirAlterar("Alterar").Click();
                if (!_cadastrodeNormativadeVendasMap.Mensagem().InnerText.Equals("Operação realizada com sucesso."))
                    throw new Exception("Nao foi possivel confirmar inclusão/alteração de nova normativa de vendas");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Seleciona normativa de vendas em andamento
        /// </summary>
        public void SelecionaNormativadeVendasemAndamento()
        {
            try
            {
                _cadastrodeNormativadeVendasMap.SelecionaNormativadeVendasemAndamento().WaitUntil(SelecionaNormativadeVendasemAndamento => SelecionaNormativadeVendasemAndamento.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && SelecionaNormativadeVendasemAndamento.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.SelecionaNormativadeVendasemAndamento().Click();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Fecha popup de pendências em normativa de vendas em andamento
        /// </summary>
        public void FechaPopupPendencias()
        {
            try
            {
                Thread.Sleep(5000);
                if (_cadastrodeNormativadeVendasMap.ClicaPopupPendencias(_config.Return_NewBrowser("Pendências")).Exists())
                {
                    _config.Close_NewWindow(_config.Return_NewBrowser("Pendências"));
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }

        /// <summary>
        /// Altera datas do período
        /// </summary>
        public void AlterarPeriodo()
        {
            try
            {
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "dt_ini_campanha").WaitUntil(InputDadosBasicos => InputDadosBasicos.Exists(uint.Parse(Constantes.tempo_espera_minute_InSeconds.ToString())).Equals(true) && InputDadosBasicos.IsVisible.Equals(true));
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "dt_ini_campanha").SetValue(DateTime.Now.ToString("dd/MM/yyyy"));
                _cadastrodeNormativadeVendasMap.InputDadosBasicos("I1", "dt_fim_campanha").SetValue(DateTime.Now.ToString("dd/MM/yyyy"));
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                throw new Exception(Ex.ToString());
            }
        }
    }
}