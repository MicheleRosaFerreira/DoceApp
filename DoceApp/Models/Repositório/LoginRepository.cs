using Dapper;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Text;

namespace DoceApp.Models.Repositório
{
	//Aqui faço o select no banco de dados 
	public class LoginRepository : ILoginRepository
	{
		private IConfiguration _configuration;
		private string _conexao { get { return _configuration.GetConnectionString("DoceApp"); } }
		public LoginRepository(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public ActionResult<Loginn> GetLogin(int UserId)
		{
			try 
			{
				using (var conection = new MySqlConnection(_conexao))
				{
					var sqlStatement = new StringBuilder("SELECT * FROM [LOGIN]");
					sqlStatement.AppendLine($"WHERE [USER_ID] = {UserId}");
					var result = conection.QueryFirstOrDefault<Loginn>(sqlStatement.ToString());
					return result;
				}
			}
			catch (Exception)
			{
				throw new Exception("Usuario não encontrado");
			}
		}
		public ActionResult<Loginn> GetLoginNickname(string nickName)
		{
			try
			{
				using (var conection = new MySqlConnection(_conexao))
				{
					var sqlStatement = new StringBuilder("SELECT * FROM [LOGIN]");
					sqlStatement.AppendLine($"WHERE [NICKNAME] = {nickName}");
					var result = conection.QueryFirstOrDefault<Loginn>(sqlStatement.ToString());
					return result;
				}
			}
			catch (Exception)
			{
				throw new Exception("Usuário não encontrado");
			}
		}
	}
}
	
	
