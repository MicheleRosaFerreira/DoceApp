using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    public class Login
    {
        
        public int UserId { get; set; }

        [Required(ErrorMessage="O campo nome de usuário é obrigatório.")]
		[DisplayName("Nome de usuário")]
		public string Nickname { get; set; }

        [Required(ErrorMessage ="Favor preencher o campo senha.")]
        [DisplayName("Digite a sua senha")]
        public string Password { get; set; }
        public bool AdminUser { get; set; }
       
    }
}
