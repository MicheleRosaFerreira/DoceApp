using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    //[Table("People")]
    public class RegisterPeople
    {
        public int Id { get;  set; }
        public string? Name { get;  set; }
        public string? Email { get;  set; }   
        public string? User { get;  set; }
		public string? Password { get; set; }
		public string? ConfirmPassword { get; set; }
		public string ErrorType { get; set; }
		public RegisterPeople()
		{
			ErrorType = "J";
		}

	}
}
