namespace DoceApp.Models
{
	public class PeopleViewModel
	{
		public string Name { get; set; }	
		public string Email { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string ErrorType { get; internal set; }
	}
}
