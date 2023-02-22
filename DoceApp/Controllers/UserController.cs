//using DoceApp.Interface;
using DoceApp.Models;
using DoceApp.Models.Entidades;
//using DoceApp.Models.Service;
//using DoceApp.Repositório;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.Linq.Expressions;

namespace DoceApp.Controllers
{
	public class UserController : Controller
	{
		//private readonly ILogin _loginRepository;


		//public UserController(ILogin loginRepository)
		//{
		//	_loginRepository = loginRepository;
		//}
		//public string Mensage(string mensage)
		//{
		//	return mensage;
		//}
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult PostLogin(LoginViewModel login)
		{
            var loginUser = new Login();
            loginUser.User = "michele.ferreira";
            loginUser.Password = "Michelerf0309@";
            loginUser.AdminUser = true;

            if (login?.User != loginUser.User || login?.Password != loginUser.Password)
            {
                login = login != null ? login : new LoginViewModel();
                login.ErrorType = "A";
                return View("Login", login);
            }
            return RedirectToAction("Home", "HomePage");
        }
        public IActionResult RegisterUser()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Register(RegisterViewModel registerViewModel)
		{
			var registerPeople = new RegisterPeople();
			registerPeople.Name = string.Empty;
			registerPeople.Email = string.Empty;
			registerPeople.User = "michele.ferreira";
			registerPeople.Password = string.Empty;
			registerPeople.ConfirmPassword = string.Empty;

			/*REGEX VALIDAÇÃO NOME:
			°A-Za-z: maiúsculas e minúsculas sem acento.
			°áàâãéèêíïóôõöúçñ: vogais acentuadas do português, cedilha e umas outras de lambuja, minúsculas.
            °ÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ: vogais acentuadas do português, cedilha e umas outras de lambuja, maiúsculas .
			°espaços.
			*/
			if (registerViewModel.User.IsNullOrEmpty())
			{
				registerViewModel = registerViewModel != null ? registerViewModel : new RegisterViewModel();
				registerViewModel.ErrorType = "J";
				return View("RegisterUser", registerViewModel);
			}
			return RedirectToAction("Login","Login");
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}