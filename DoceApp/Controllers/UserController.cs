using DoceApp.Models;
using DoceApp.Models.Entidades;
using DoceApp.Repositório;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoceApp.Controllers
{
	public class UserController : Controller
	{
		private readonly PeopleRepository _peopleRepository;
		public UserController(PeopleRepository peopleRepository)
		{
			_peopleRepository = peopleRepository;
		}
		//public string Mensagem(string mensagem)
		//{
		//	return mensagem;
		//}
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult Cadastrar()
		{
			return View();
		}

		public IActionResult RealizarCadastro(People people)
		{
			if (people == null)
			{
				return BadRequest("Não foi possivel cadastrar esse Usuário!");
			}
			else 
			{
				return Ok("Usuario cadastrado com sucesso");
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