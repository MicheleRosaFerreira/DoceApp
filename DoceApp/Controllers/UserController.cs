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
using System.Net.Mail;
using System.Text;

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
		public IActionResult Register(RegisterViewModel register)
		{  

			//var verifyUser = registredUsers.FirstOrDefault(u => u.Nickname == register.Nickname);

			//if (verifyUser != null)
			//{
			//	register.ReturnMessage = new ToastrMessage("error", "Falha ao realizar cadastro", "Usuário já cadastrado!");

			//	return View("RegisterUser", register);
			//}
			if (string.IsNullOrEmpty(register.Password))
			{
				register.ReturnMessage = new ToastrMessage("error", " ", "Favor preencher o campo senha");

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
			if (register.Email == null)
			{
				register.ReturnMessage = new ToastrMessage("error", " ", "Campo Email é obrigatório!");
				return View("RegisterUser", register);
			}






			register.ReturnMessage = new ToastrMessage("success", " ", "Usuário Cadastrado com sucesso!");
			return View("RegisterUser", register);
		}


		[HttpPost]
		public IActionResult MailMessage(EmailViewModel mail )
		{
			LoginViewModel login = new LoginViewModel();
			var verifyMail = UserEmail.FirstOrDefault(e => e.Email == mail.Email);

			MailMessage mailMessage = new MailMessage($"{verifyMail.Email}", $"{verifyMail.Email}");
			mailMessage.Subject = "Recuperação de Senha";
			mailMessage.IsBodyHtml = true;
			mailMessage.Body = "<p>\r\nOlá,\r\nHouve um pedido para alterar sua senha!\r\n\r\nSe você não fez esta solicitação, ignore este e-mail.\r\n\r\nCaso contrário, clique neste link para alterar sua senha: [link] </p>";
			//caso meu textp ou assunto tenham algum tipo de caracter especial, o navegador irá reconhecer e transmitilos corretamente.
			mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
			mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");
			
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential($"{verifyMail.Email}", " "); //email e senha do email que vamos usar como remetente
			smtpClient.EnableSsl = true; // vai criptografar o trafego ele oferece segurança de comunicação ao usuario quando acessarem ambiente virtual.
		    smtpClient.Send(mailMessage);
			return View("Email", mail);


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