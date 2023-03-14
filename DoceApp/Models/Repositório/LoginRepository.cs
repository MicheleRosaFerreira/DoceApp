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
using DoceApp.Context;

namespace DoceApp.Models.Repositório
{
	//Aqui faço o select no banco de dados 
	public class LoginRepository : ILoginRepository
	{
        private readonly ContextBase _context;
        public LoginRepository(ContextBase context)
        {
            _context = context;
        }
        public ActionResult<Loginn> GetLogin(int UserId)
		{
            return  _context.logins.Find(UserId);
        }

		//public ActionResult<Loginn> GetLoginNickname(string nickName)
		//{
			
		//}
	}
}
	
	
