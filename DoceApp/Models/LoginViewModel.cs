using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
	public class LoginViewModel
	{
		//[Required]
		//[RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])(?:([0-9a-zA-Z$*&@#])(?!\\1)){8,}$")]
		public string Nickname { get; set; }
        public string Password { get; set; }
        public ToastrMessage ReturnMessage { get; set; }
    }
}
