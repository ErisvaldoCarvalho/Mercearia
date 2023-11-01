namespace Models
{
    public static class Constantes
    {
        public static Usuario UsuarioLogado { get; set; }
        public static string NomeDoSistema { get { return "O meu resolve"; } }
        public static string NomeDaSoftwareHouse { get { return "Eris Sistemas"; } }

        public static bool UsarEntityFramework { get { return true; } }

        public static string Unverbose(string _texto)
        {
            //TODO: Montar o dicionário aqui
            return _texto;
        }

        public static string Verbose(string _texto)
        {
            //TODO: Montar o dicionário aqui
            return _texto;
        }
    }
}
