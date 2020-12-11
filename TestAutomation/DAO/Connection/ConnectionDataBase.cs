using OGS.Framework.Utility;

namespace TestAutomation.DAO.Connection
{
    public class ConnectionDataBase
    {
        readonly string _host;
        readonly string _port;
        readonly string _serviceName;
        readonly string _user;
        readonly string _password;
        readonly string[] RecebeResultado = null;

        public ConnectionDataBase(string Host, string Port, string ServiceName, string User, string Password)
        {
            this._host = Host;
            this._port = Port;
            this._serviceName = ServiceName;
            this._user = User;
            this._password = Password;
        }

        /// <summary>
        /// Responsavel por executar instruções de Select
        /// </summary>
        /// <param name="QuerySelect">Instrução já carregada com os valores</param>
        /// <returns></returns>
        public string ExecutaSelect(string QuerySelect)
        {
            var DataBase = new DataBase(_host, _port, _serviceName, _user, _password);
            DataBase.ConnectDataBase();
            string RecebeSelect = DataBase.SelectCommand(QuerySelect, RecebeResultado);
            DataBase.CloseConnection();
            return RecebeSelect;
        }

        /// <summary>
        /// Responsavel por executar instruções de Insert
        /// </summary>
        /// <param name="QueryInsert">Instrução já carregada com os valores</param>
        /// <returns></returns>
        public string ExecutaInsert(string QueryInsert)
        {
            var DataBase = new DataBase(_host, _port, _serviceName, _user, _password);
            DataBase.ConnectDataBase();
            int RecebeSelect = DataBase.InsertCommand(QueryInsert);
            DataBase.CloseConnection();
            return RecebeSelect.ToString();
        }

        /// <summary>
        /// Responsavel por executar instruções de Insert
        /// </summary>
        /// <param name="QueryUpdate">Instrução já carregada com os valores</param>
        /// <returns></returns>
        public string ExecutaUpdate(string QueryUpdate)
        {
            var DataBase = new DataBase(_host, _port, _serviceName, _user, _password);
            DataBase.ConnectDataBase();
            int RecebeSelect = DataBase.InsertCommand(QueryUpdate);
            DataBase.CloseConnection();
            return RecebeSelect.ToString();
        }
    }
}
