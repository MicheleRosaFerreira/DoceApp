using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoceApp.Models.Entidades
{
	public class User
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "O campo nome é obrigatório.")]
		[DisplayName("Digite seu nome.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "O campo CPF é obrigatório.")]
		[DisplayName("Digite seu Cpf.")]
		[RegularExpression("/^(([0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2})|([0-9]{11}))$/")]
		public string Cpf { get; set; }

		[Required(ErrorMessage =("Campo obrigatório"))]
		[DisplayName("Digite sua data de nascimento.")]
		public DateTime Bithdate { get; set; }

		[Required(ErrorMessage = ("Campo obrigatório"))]
		[DisplayName("Digite seu endereço de email.")]
		[EmailAddress(ErrorMessage = "Endereço de email inválido.")]
		public string Email  { get; set; }
	
	}
}
 