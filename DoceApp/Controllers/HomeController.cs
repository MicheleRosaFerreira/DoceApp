using DoceApp.Models;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace DoceApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Home()
		{
			var departaments = new List<Departament>
			{
				new Departament("Bolos", "https://images.vexels.com/media/users/3/151613/isolated/preview/71680abcac6aa750c99fa2589a48998b-icone-plano-de-fatia-de-bolo-de-cereja.png"),
				new Departament("Doces","https://images.vexels.com/media/users/3/134502/isolated/lists/85a0e269ec34077eb658ae3f4e87058b-doce-de-cupcake-de-sobremesa.png"),
				new Departament("Pirulito Chocolate","https://images.vexels.com/media/users/3/151619/isolated/lists/c65c86d961b55e39629446a8430a5580-icone-de-pirulito-de-bola-de-chocolate.png")
			};

			var homeview = new HomeViewModel(departaments);

			return View(homeview);
		}
	}
}
