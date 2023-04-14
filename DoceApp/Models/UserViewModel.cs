using DoceApp.Models.Entidades;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoceApp.Models
{
    public class UserViewModel
    {

		[Required(ErrorMessage = "O campo nome é obrigatório.")]
		[DisplayName("Digite seu nome.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Preencha o campo cpf")]
		[DisplayName("Digite seu Cpf.")]
		//[RegularExpression("/^([0-9]{3}[0-9]{3}[0-9]{3}[0-9]{2})|([0-9]{11})$/", ErrorMessage = "Cpf inválido")]
		public string Cpf { get; set; }

		[Required(ErrorMessage = ("Campo obrigatório"))]
		[DisplayName("Digite sua data de nascimento.")]
		public DateTime Birthdate { get; set; }

		[Required(ErrorMessage = ("Campo obrigatório"))]
		[DisplayName("Digite seu endereço de email.")]
		[RegularExpression("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)([_]?)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$", ErrorMessage = "E-mail inválido")]
		public string Email { get; set; }
		[Required(ErrorMessage = ("Campo obrigatório"))]
		public string Nickname { get; set; }

		[MaxLength(8)]
		[Required(ErrorMessage = ("Campo obrigatório"))]
		public string Password { get; set; }
		[MaxLength(8)]
		[Required(ErrorMessage = ("Campo obrigatório"))]
		public string ConfirmPassword { get; set; }
		public ToastrMessage? ReturnMessage { get; set; }
    }
}
