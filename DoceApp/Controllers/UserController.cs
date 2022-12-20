//using DoceApp.Interface;
using DoceApp.Models;
using DoceApp.Models.Entidades;
//using DoceApp.Models.Service;
//using DoceApp.Repositório;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

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

			if (login?.UserName != loginUser.User || login?.Password != loginUser.Password) 
			{
				login = login != null ? login : new LoginViewModel();
				login.ErrorType = "E";
				return View("Login", login);
			}
			return RedirectToAction("Home", "HomePage");
		}
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		public IActionResult RegisterUser(People people)
		{
			var registerPeople = new People();
			registerPeople.Name = "Michele Rosa Firmino Ferreira";
			registerPeople.Email = "michele.ferreira@gmail.com";
			registerPeople.Login.User = "michele.ferreira";
			registerPeople.Login.Password = "Michelerf1504@";
		}

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