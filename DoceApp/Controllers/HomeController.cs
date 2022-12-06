using DoceApp.Entidades;
using DoceApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoceApp.Controllers
{
    public class HomeController : Controller
    {
		const string SessionUser = "User";
		const string SessionPassword = "Password";

        public Login Usuario { get; set; }
        public HomeController()
        {
            Usuario = new Login("michele.ferreira", "abcd345", true);
        }

        public IActionResult Login()
        {
            return View();
        }
      
        public IActionResult RealizarLogin(LoginViewModel login)
        {
            if (login?.User != Usuario.User || login?.Password != Usuario.Password)
            {
                return View("Login", login);
            }

			HttpContext.Session.SetString("User", SessionUser);

			return View("Home");
        }        
        

        public IActionResult Cadastrar()
        {
            return View();
        }

		//public IActionResult RealizarCadastro(CadastroViewModel cadastro)
		//{
  //          //terminar aqui
		//	return View("Home");
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