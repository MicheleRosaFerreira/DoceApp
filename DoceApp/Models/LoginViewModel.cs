using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
	public class LoginViewModel 
	{
		public string Nickname { get; set; }
		public string Password  { get; set; }
		public ToastrMessage? ReturnMessage { get; set; }
	}
}
