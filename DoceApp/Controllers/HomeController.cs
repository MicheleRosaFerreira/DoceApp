using DoceApp.Models;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoceApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IDepartamentService _departamentService;
		public HomeController(IDepartamentService departamentService)
		{
			_departamentService = departamentService;
		}
		public IActionResult Home()
		{
			var departaments = _departamentService.GetAllDepartament();
			var homeView = new HomeViewModel(departaments);
			return View(homeView);
		}
	}
}
