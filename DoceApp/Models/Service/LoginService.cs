using DoceApp.Controllers;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using DoceApp.Models.Repositório;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Online.SharePoint.SPLogger;

namespace DoceApp.Models.Service
{
    public class LoginService : ILoginService
	{
		private readonly ILoginRepository _loginRepository;
		public LoginService(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}
		// Não pode existir um usuário repetido no banco de dados e, o nome de usuário não pode ser maior que 11.
		public Login GetLogin(Login login)
		{
			var getUser = _loginRepository.GetLogin(login.Nickname);
			return getUser;
		}
	}
}
