﻿using DoceApp.Interface;
using DoceApp.Models;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DoceApp.Controllers
{
	public class UserController : Controller
	{
		private readonly ILoginRepository _loginRepository;


		public UserController(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
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
		public  IActionResult GetLogin(Loginn login)
		{
			
			if (ModelState.IsValid)
			{
				var verifyUser = _loginRepository.GetLoginNickname(login.Nickname);

				if (verifyUser != null)
				{
					return Ok(verifyUser);
				}
				else
				{
					NoContent();
					//return View("Login", login);
				}
			}
			return RedirectToAction("Home", "HomePage");
		}
	
		[HttpPost]
		public IActionResult Register(RegisterViewModel register)
		{
			if (ModelState.IsValid)
			{
				register.ReturnMessage = new ToastrMessage("success", " ", "Usuário Cadastrado com sucesso!");
				return Ok();
			}
			if (register.Password != register.ConfirmPassword)
			{
				register.ReturnMessage = new ToastrMessage("error", " ", "As senhas são diferentes");

				return View("RegisterUser", register);
			}
			register.ReturnMessage = new ToastrMessage("error", "Falha ao realizar cadastro ", "Tente novamente em alguns instantes.");
			return View("RegisterUser", register);
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
	