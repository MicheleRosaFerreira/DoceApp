using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    [Table("Login")]
    public class Login
    {
        [Required]
        [DataType(DataType.Text)]
        public string User { get; private set; }
        [Required]
		[DataType(DataType.Password)]
		[RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])(?:([0-9a-zA-Z$*&@#])(?!\\1)){8,}$")]
		public string Password { get; private set; }
        public bool Admin { get; private set; }
		[DataType(DataType.DateTime)]
		public DateTime dataHora { get; }
        public Login(string user, string password, bool admin )
        {
            User = user;
            Password = password;
            Admin = admin;
        }
    }
}
