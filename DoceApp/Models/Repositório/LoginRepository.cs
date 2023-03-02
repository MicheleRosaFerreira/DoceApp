using Dapper;
using DoceApp.Context;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DoceApp.Models.Repositório
{
	//Aqui faço o select no banco de dados 
	public class LoginRepository : DoceAppContext, ILoginRepository
	{
		public ActionResult<Login>GetLogin(int UserId)
		{
			try
			{
				var sqlStatement = new StringBuilder("SELECT * FROM [LOGIN]");
				sqlStatement.AppendLine($"WHERE [USER_ID] = {UserId}");
				var connection = GetDoceAppCOnnection();
				var result = connection.Query<Login>(sqlStatement.ToString()).FirstOrDefault();
				return result;
			}
			catch (Exception)
			{
				throw new Exception("Usuario não encontrado");
			}
			finally
			{
				Dispose();
			}
		}
	}
}
