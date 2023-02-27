using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
	public class RegisterViewModel
	{
		public string Name { get; set; }	
		public string Email { get; set; }
		public string Nickname { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }	
		public ToastrMessage ReturnMessage { get;  set; }
	}
}

/*
 
 create tabke login(
	a 
	b
	admin bit not null default 0
)
 */
