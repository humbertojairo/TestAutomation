using Newtonsoft.Json;
using TestAutomation.Utils;
using System.IO;

namespace TestAutomation.Data.Acessos
{
    public struct Path_DataExecutionPath_Folder
    {
        public string path_DataExecutionPath_Folder { get; set; }
    }

    public class Acessos
    {
        Acessos acessos;
        private readonly string NomeAmbienteTestAutomation = "TestAutomation";

        #region Gets e Sets Json
        #endregion

        #region TestAutomation
        public string UrlTestAutomation { get; set; }
        public string UsuarioTestAutomation { get; set; }
        public string SenhaTestAutomation { get; set; }
        public string HostDbTestAutomation { get; set; }
        public string PortDbTestAutomation { get; set; }
        public string ServiceNameDbTestAutomation { get; set; }
        public string UserDbTestAutomation { get; set; }
        public string SenhaDbTestAutomation { get; set; }
        public string ClasseRedeMaster { get; set; }
        public string EstabelecimentoServicosDeAltaComplexidade { get; set; }
        public string MesAniversarioContratoDez { get; set; }
        #endregion

        public void AmbientesCaseTestAutomation()
        {
            acessos = new Acessos();
            acessos = RetornaAcessosJSON();

            switch (NomeAmbienteTestAutomation.ToUpper())
            {
                case "TestAutomation":
                    #region Acessosl
                    UrlTestAutomation = acessos.UrlTestAutomation;
                    UsuarioTestAutomation = acessos.UsuarioTestAutomation;
                    SenhaTestAutomation = acessos.SenhaTestAutomation;
                    ClasseRedeMaster = acessos.ClasseRedeMaster;
                    EstabelecimentoServicosDeAltaComplexidade = acessos.EstabelecimentoServicosDeAltaComplexidade;
                    MesAniversarioContratoDez = acessos.MesAniversarioContratoDez;
                    #endregion
                    #region Acessos do Banco de Dados
                    HostDbTestAutomation = acessos.HostDbTestAutomation;
                    PortDbTestAutomation = acessos.PortDbTestAutomation;
                    ServiceNameDbTestAutomation = acessos.ServiceNameDbTestAutomation;
                    UserDbTestAutomation = acessos.UserDbTestAutomation;
                    SenhaDbTestAutomation = acessos.SenhaDbTestAutomation;
                    #endregion
                    break;
            }
        }

        public static Acessos RetornaAcessosJSON()
        {
            var jsonString = File.ReadAllText(Config.CarregaRaizProjeto() + Path.DirectorySeparatorChar + "Data" + Path.DirectorySeparatorChar + "Acessos" + Path.DirectorySeparatorChar + "JsonAcessos.json");
            return JsonConvert.DeserializeObject<Acessos>(jsonString);
        }

        public void GravaJson_DataExecutionPath_Folder(string DataExecutionPath_Folder)
        {
            Path_DataExecutionPath_Folder _Path_DataExecutionPath_Folder;
            var jsonString = File.ReadAllText(Config.CarregaRaizProjeto() + Path.DirectorySeparatorChar + "Data" + Path.DirectorySeparatorChar + "Acessos" + Path.DirectorySeparatorChar + "Path_DataExecutionPath_Folder.json");
            _Path_DataExecutionPath_Folder = JsonConvert.DeserializeObject<Path_DataExecutionPath_Folder>(jsonString);
            _Path_DataExecutionPath_Folder.path_DataExecutionPath_Folder = DataExecutionPath_Folder;
            string JsonSerialize = JsonConvert.SerializeObject(_Path_DataExecutionPath_Folder);
            File.WriteAllText(Config.CarregaRaizProjeto() + Path.DirectorySeparatorChar + "Data" + Path.DirectorySeparatorChar + "Acessos" + Path.DirectorySeparatorChar + "Path_DataExecutionPath_Folder.json", JsonSerialize);
        }

        public static Path_DataExecutionPath_Folder Retorna_Path_DataExecutionPath_Folder()
        {
            var jsonString = File.ReadAllText(Config.CarregaRaizProjeto() + Path.DirectorySeparatorChar + "Data" + Path.DirectorySeparatorChar + "Acessos" + Path.DirectorySeparatorChar + "Path_DataExecutionPath_Folder.json");
            return JsonConvert.DeserializeObject<Path_DataExecutionPath_Folder>(jsonString);
        }
    }
}