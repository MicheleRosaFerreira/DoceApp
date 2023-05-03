using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DoceApp.Models.Entidades
{
    [Table("LOGIN")]
    public class Login
    {
        [Key]
        public int User_Login_Id { get; set; }
        [ForeignKey("USER")]
        public int User_Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [DisplayName("Nome de usuário")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [DisplayName("Digite a sua senha")]
        [JsonIgnore]//impede que a propriedade de senha seja serializada e retornada em respostas de API.

		public string Password { get; set; }

		public User users { get; set; }

		//public bool AdminUser { get; set; }

		public Login()
		{

		}
        public Login(string nickname,string password)
        {
            Nickname = nickname;
            Password = password;
        }


	}
}
