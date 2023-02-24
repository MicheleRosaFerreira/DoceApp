using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    //[Table(" ")]
    public class Login
    {
        //[Required]
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        public bool? AdminUser { get; set; }
       
    }
}
