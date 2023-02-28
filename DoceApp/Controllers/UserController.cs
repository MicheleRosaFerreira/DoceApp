//using DoceApp.Interface;
using DoceApp.Models;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
//using DoceApp.Models.Service;
//using DoceApp.Repositório;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Mail;
using System.Net;

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
		public IActionResult RegisterUser()
		{
			return View();
		}
		public IActionResult Email()
		{
			return View();
		}


		public static List<Login> registredUsers = new List<Login>()
		{
			new Login()
			{
				Nickname = "michele.ferreira",
				Password = "Michelerf0309@",
				AdminUser = true
			}
		};


		public static List<User> UserEmail = new List<User>()
		{
			new User()
			{
				Email = "michele.ferreira@gamil.com",
			}
		};
		[HttpPost]
		public IActionResult PostLogin(LoginViewModel login)
		{
			var verify = registredUsers.FirstOrDefault(r => r.Nickname == login.Nickname && r.Password == login.Password);

			if (verify == null)
			{
				login.ReturnMessage = new ToastrMessage("error", "Falha ao realizar login", "Senha ou usuário incorretos!");

				return View("Login", login);
			}

			return RedirectToAction("Home", "HomePage");
		}

		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public IActionResult Register(RegisterViewModel register)
		{
			var verifyUser = registredUsers.FirstOrDefault(u => u.Nickname == register.Nickname);
			if (verifyUser != null)
			{
				register.ReturnMessage = new ToastrMessage("error", "Falha ao realizar cadastro", "Usuário já cadastrado!");

				return View("RegisterUser", register);
			}
			if (register.Password != register.ConfirmPassword)
			{
				register.ReturnMessage = new ToastrMessage("error", " ", "As senhas são diferentes");
				return View("RegisterUser", register);
			}

			if (string.IsNullOrEmpty(register.Nickname))
			{
				register.ReturnMessage = new ToastrMessage("error", "Falha ao realizar cadastro", "O campo usuário é obrigatório.");
				return View("RegisterUser", register);
			}
			if (string.IsNullOrEmpty(register.Name))
			{
				register.ReturnMessage = new ToastrMessage("error", " ", "Campo nome é obrigatório!");
				return View("RegisterUser", register);
			}
			register.ReturnMessage = new ToastrMessage("success", " ", "Usuário Cadastrado com sucesso!");
			return View("RegisterUser", register);
		}
	
		
		[HttpPost]
		public async Task SendEmail(EmailViewModel email)
		{
			var verifyEmail = UserEmail.FirstOrDefault(e => e.Email == email.Email);
		
		}
	}
}



//public IActionResult Privacy()
//		{
//			return View();
//		}

//		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//		public IActionResult Error()
//		{
//			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//		}
//	}