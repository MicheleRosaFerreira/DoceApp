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
		private readonly LoginRepository _loginRepository;
		public LoginService(LoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}
		// Não pode existir um usuário repetido no banco de dados e, o nome de usuário não pode ser maior que 11.
		public bool GetLogin(LoginViewModel login)
		{
			var _login = _loginRepository.GetLogin(login.Nickname);
			if (_login == null)
			{
				login.ReturnMessage = new ToastrMessage("error","Falha ao realizar login","Usuário não cadastrado!");
			}
		    if(_login != null && login.Password == _login.Password) 
			{
				return true;
			}

			return false;
		}
	}
}
