﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Entidades
{
    public class Loginn
    {
        
        public int UserId { get; set; }

        [Required(ErrorMessage="O campo nome de usuário é obrigatório.")]
		[DisplayName("Nome de usuário")]
		[RegularExpression("^[A-Za-z][A-Za-z0-9_]{7,29}$")]
		public string Nickname { get; set; }

        [Required(ErrorMessage ="Favor preencher o campo senha.")]
        [DisplayName("Digite a sua senha")]
		[RegularExpression("/^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])[0-9a-zA-Z$*&@#]{8,}$/")]
		public string Password { get; set; }
        public bool AdminUser { get; set; }
		public ToastrMessage ReturnMessage { get; set; }


	}
}