﻿using DoceApp.Interface;
using DoceApp.Models;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace DoceApp.Controllers
{
    public class UserController : Controller
	{
		private readonly ILoginService _loginService;

		private readonly IUserService _userService;
		public UserController(ILoginService loginService , IUserService userService)
		{
			_loginService = loginService;
			_userService = userService;
		}

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

		[HttpPost]
		public IActionResult Login(LoginViewModel login)
		{
			if (!ModelState.IsValid)
			{
				return View(login);
			}
			var verifyUser = _loginService.GetLogin(login);

			if (verifyUser != null && verifyUser.Password == login.Password)
			{
				return RedirectToAction("Home", "HomePage");
			}
			login.ReturnMessage = new ToastrMessage("error","Falha ao efetuar login","Usuário ou senha incorretos");
			return View(login);
		}

		[HttpPost]
		public IActionResult RegisterUser(UserViewModel userRegister)
		{
			if (!ModelState.IsValid)
			{
				return View(userRegister);
			}

			var user = new Users(userRegister.Name, userRegister.Cpf.Replace("[^0-9,]", ""),userRegister.Birthdate, userRegister.Email);
			

			var register = _userService.Create(user);

			if (register != null && userRegister.Password == userRegister.ConfirmPassword)
			{
				
				userRegister.ReturnMessage = new ToastrMessage("sucess", " ", "Usuário cadastrado com sucesso!");
				return View(userRegister);
			}

			userRegister.ReturnMessage = new ToastrMessage("error", "Falha ao realizar cadastro ", "Verifique as informações e tente novamente!");
			return View(userRegister);
		}


		//[HttpPost]
		//public IActionResult MailMessage(EmailViewModel mail )
		//{
		//	LoginViewModel login = new LoginViewModel();
		//	var verifyMail = UserEmail.FirstOrDefault(e => e.Email == mail.Email);

		//	MailMessage mailMessage = new MailMessage($"{verifyMail.Email}", $"{verifyMail.Email}");
		//	mailMessage.Subject = "Recuperação de Senha";
		//	mailMessage.IsBodyHtml = true;
		//	mailMessage.Body = "<p>\r\nOlá,\r\nHouve um pedido para alterar sua senha!\r\n\r\nSe você não fez esta solicitação, ignore este e-mail.\r\n\r\nCaso contrário, clique neste link para alterar sua senha: [link] </p>";
		//	//caso meu textp ou assunto tenham algum tipo de caracter especial, o navegador irá reconhecer e transmitilos corretamente.
		//	mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
		//	mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

		//	SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
		//	smtpClient.UseDefaultCredentials = false;
		//	smtpClient.Credentials = new NetworkCredential($"{verifyMail.Email}", " "); //email e senha do email que vamos usar como remetente
		//	smtpClient.EnableSsl = true; // vai criptografar o trafego ele oferece segurança de comunicação ao usuario quando acessarem ambiente virtual.
		//    smtpClient.Send(mailMessage);
		//	return View("Email", mail);


		//}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
	