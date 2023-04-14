using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoceApp.Models.Entidades
{
	public class Users
	{
		[Key]
		public int User_Id { get; set; }
		public string Name { get; set; }
		public string Cpf { get; set; }
		public DateTime Birthdate { get; set; }
		public string Email { get; set; }

		public Login userLogin { get; set; }
		public Users()
		{
				
		}
		public Users(string name , string cpf, DateTime bithdate,string email)
		{
			Name = name;
			Cpf = cpf;
			Birthdate = bithdate;
			Email = email;
		}
	}
}
 