using Microsoft.AspNetCore;
using Dapper;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.SharePoint.Client;
using MySqlConnector;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace DoceApp.Models.Repositório
{
	//Aqui faço o select no banco de dados 
	public class LoginRepository : ILoginRepository
	{
		private readonly string connectionstring;
		public LoginRepository(IConfiguration configuration)
		{
			Configuration = configuration;
			connectionstring = configuration.GetConnectionString("DoceApp");
		}

		public IConfiguration Configuration { get; } 

		public ActionResult<Loginn> GetLogin(int UserId)
		{
			string sql = ($"SELECT [NICKNAME] FROM LOGIN WHERE [USER_ID] = {UserId}"); 

			using (var con = new SqlConnection(connectionstring))
			{
				return con.QueryFirstOrDefault<Loginn>(sql);
			}
		}

		public ActionResult<Loginn> GetLoginNickname(string nickName)
		{
			string sql = ($"SELECT * FROM LOGIN WHERE [NICKNAME] = {nickName}");

			using (var con = new SqlConnection(connectionstring))
			{
				return con.QueryFirstOrDefault<Loginn>(sql);
			}
		}
	}
}
	
	
