using System.Net.Mail;

namespace DoceApp.Models.Service
{
	public class EmailService
	{
		public static async Task Execute(string Email, string Texto, string Message)
		{

			if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Message))
			{
				System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
				client.Host = "email-ssl.com.br ";
				client.EnableSsl = true;
				client.Credentials = new System.Net.NetworkCredential("michelerfferreira@gmail.com", "Michelerf0309@");
				MailMessage mail = new MailMessage();
				mail.Sender = new System.Net.Mail.MailAddress("michelerfferreira@gmail.com");
				mail.From = new MailAddress("michelerfferreira@gmail.com");
				mail.To.Add(new MailAddress(Email, "RECEBEDOR"));
				mail.Subject = "Recuperação de senha";
				mail.Body = "Nome:  " + Email + " <br/> Mensagem : " + Message;
				mail.IsBodyHtml = true;
				mail.Priority = MailPriority.High;
				try
				{
					client.Send(mail);
				}
				catch (System.Exception erro)
				{
					//trata erro
				}
				finally
				{
					mail = null;
				}
			}

		}
	}
}

