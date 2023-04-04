using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
	public class LoginViewModel : Login
	{
		public ToastrMessage? ReturnMessage { get; set; }
	}
}
