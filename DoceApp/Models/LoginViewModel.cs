using DoceApp.Models.Entidades;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoceApp.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "O nome de usuário é obrigatório.")]
		[DisplayName("Nome de usuário")]
		public string Nickname { get; set; }

		[Required(ErrorMessage = "Favor preencher o campo senha.")]
		[DisplayName("Digite a sua senha")]
		public string Password { get; set; }
        public ToastrMessage ReturnMessage { get; set; }
    }
}
