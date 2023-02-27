using Microsoft.Extensions.Options;

namespace DoceApp.Models.Entidades
{
	public class EmailSender
	{
		public string Email { get; set; }
		public string Texto { get; set; }
		public string Mensagem { get; set; }
	}
}
