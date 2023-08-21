using DoceApp.Interface;
using DoceApp.Models;
using DoceApp.Models.Entidades;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace DoceApp.Controllers
{
	public class MenuController : Controller
	{
		private readonly IConfectioneryService _confectioneryService;
		public MenuController(IConfectioneryService confectioneryService)
		{
			_confectioneryService = confectioneryService;
		}



		//public IActionResult Menu()
		//{
		//	var confectioneryId = new List<Confectionery>();
		//	//var confectionery = _confectioneryService.GetConfectionery);
		//	//var homeviewConfectionery = new MenuViewModel(confectionery);
		//	//return View(homeviewConfectionery);
		//}
	}
}
