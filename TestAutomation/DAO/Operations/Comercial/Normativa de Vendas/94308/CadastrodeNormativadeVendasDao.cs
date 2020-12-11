using TestAutomation.DAO.Connection;

namespace TestAutomation.DAO.Operations.Comercial.Normativa_de_Vendas.Cadastro_de_Normativa_de_Vendas._94308
{
    public class CadastrodeNormativadeVendasDao
    {
        ConnectionDataBase _ConnectionDataBase;

        private readonly string selectCodCampanha = "select * from( " +
                                           "select distinct cv.cod_campanha " +
                                           "from ts.campanha_vendas cv, " +
                                           "     ts.nc_tipo_venda nc, " +
                                           "     ts.nc_unidade nu, " +
                                           "     ts.situacao_campanha sc " +
                                           "where cv.cod_nc_ts = nc.cod_nc_ts(+) " +
                                           "  and cv.cod_nc_ts = nu.cod_nc_ts(+) " +
                                           "  and cv.ind_situacao = sc.ind_situacao " +
                                           "order by dbms_random.random) " +
                                           "   where rownum = 1";

        public string SelectCodCampanha { get { return selectCodCampanha; } }

        public string RetornaQuery()
        {
            _ConnectionDataBase = new ConnectionDataBase("scan", "1521", "lgpd", "app", "123456");
            string selectCodCampanha = _ConnectionDataBase.ExecutaSelect(string.Format(SelectCodCampanha));
            return selectCodCampanha;
        }
    }
}