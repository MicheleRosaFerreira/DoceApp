using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;

namespace DoceApp.Models.Service
{
	public class LoginService : ILoginService
	{
		public Login GetLogin(Login login)
		{
			if(login.Nickname == null || login.Nickname.Length > 11) 
			{
				login.ReturnMessage = new ToastrMessage("error","Falha ao realizar login","Usuário ou senha incorretos");
			}
			
			return login;
		}
	}
}
