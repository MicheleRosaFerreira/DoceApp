using DoceApp.Models;
using DoceApp.Models.Entidades;
using DoceApp.Models.Service;
using DoceApp.Repositório;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoceApp.Controllers
{
	public class UserController : Controller
	{
		//public readonly UserService _userService;
		//public UserController(UserService userService)
		//{
		//	_userService = userService;
		//}

		public string Mensagem(string mensage)
		{
			return mensage;
		}
		public IActionResult Login()
		{
			
			return View();
		}

		public IActionResult Cadastrar()
		{
			return View();
		}
		//[HttpPost]
		//public IActionResult RealizarCadastro(People people)
		//{
				
			
		//}

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