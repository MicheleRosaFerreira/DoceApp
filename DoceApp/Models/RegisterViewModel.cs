using DoceApp.Models.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DoceApp.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "O campo nome é obrigatório.")]
		[DisplayName("Digite seu nome.")]
		public string Name { get; set; }

		[Required(ErrorMessage = ("Campo obrigatório"))]
		[DisplayName("Digite seu endereço de email.")]
		[EmailAddress(ErrorMessage = "Endereço de email inválido.")]
		public string Email { get; set; }

		[Required(ErrorMessage = ("Campo obrigatório"))]
		[DisplayName("Digite sua data de nascimento.")]
		public string Cpf { get; set; }

		[Required(ErrorMessage = "O campo nome de usuário é obrigatório.")]
		[DisplayName("Nome de usuário")]
		public string Nickname { get; set; }
		[Required(ErrorMessage = "Favor preencher o campo senha.")]
		[DisplayName("Digite a sua senha")]
		[RegularExpression("/^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])[0-9a-zA-Z$*&@#]{8,}$/")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Favor preencher confirmação de senha.")]
		[DisplayName("Digite a sua senha")]
		[RegularExpression("/^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])[0-9a-zA-Z$*&@#]{8,}$/")]
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
