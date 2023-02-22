namespace DoceApp.Models
{
	public class RegisterViewModel
	{
		public string Name { get; set; }	
		public string Email { get; set; }
		public string User { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string ErrorType { get; internal set; }
	}
}
