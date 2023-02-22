namespace DoceApp.Models
{
	public class LoginViewModel
	{

        public string User { get; set; }
        public string Password { get; set; }
        public string ErrorType { get; internal set; }
    }
}
