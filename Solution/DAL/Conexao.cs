namespace DAL
{
    public static class Conexao
    {
		private static string stringDeConexao = @"User Id = Erisvaldo;Initial Catalog=Mercearia;Data Source=.\SQLEXPRESS2019;Password=123;Integrated Security=SSPI;TrustServerCertificate=True";

		public static string StringDeConexao
		{
			get { return stringDeConexao; }
		}
	}
}
