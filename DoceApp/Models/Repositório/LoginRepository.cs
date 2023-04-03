using Microsoft.AspNetCore;
using DoceApp.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.SharePoint.Client;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using DoceApp.Context;
using DoceApp.Models.Repositório;
using Microsoft.EntityFrameworkCore;

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
        public Login GetLogin(string nickname)
        {
            return _context.Login.FirstOrDefault(l => l.Nickname == nickname);

            //public ActionResult<Loginn> GetLoginNickname(string nickName)
            //{

            //}
        }
    }
}
