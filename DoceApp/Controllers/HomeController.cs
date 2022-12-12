using DoceApp.Models;
using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoceApp.Controllers
{
    public class HomeController : Controller
    {
		const string SessionUser = "User";
	

        public Login Usuario { get; set; }
      
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
		public IActionResult RealizarLogin(Login login)
        {
            if (login?.User != Usuario.User || login?.Password != Usuario.Password)
            {
                return View("Login", login);
            }

			HttpContext.Session.SetString("User", SessionUser);

			return View("Cadastrar");
        }        
        

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        [Route("login/cadastrar")]
        public IActionResult RealizarCadastro(People cadastro)
        {
            if (cadastro.Name && cadastro.Email && cadastro.)
            {

            }
            return View("Login");
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