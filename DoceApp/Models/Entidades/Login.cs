using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    //[Table("Logar")]
    public class Login
    {
        //[Required]
        public string? User { get; set; }
        //[Required]
        //[RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])(?:([0-9a-zA-Z$*&@#])(?!\\1)){8,}$")]
        public string? Password { get; set; }
        public bool? AdminUser { get; set; }
        public DateTime? dataHora { get; set; }
        public string ErrorType { get; set; }
        public Login()
        {
            ErrorType = "A";
        }
    }
}
