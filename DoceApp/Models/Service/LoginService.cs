using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using DoceApp.Models.Repositório;
using Microsoft.AspNetCore.Mvc;

namespace DoceApp.Models.Service
{//Aqui faço as validações
	public class LoginService : ILoginService
	{
		private readonly ILoginRepository _loginRepository;
		public LoginService()
		{
			_loginRepository = new LoginRepository();
		}

		public ActionResult<Login> GetLogin(int UserId)
		{
			throw new NotImplementedException();
		}
	}
}
