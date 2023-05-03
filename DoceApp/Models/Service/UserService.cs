using DoceApp.Controllers;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using DoceApp.Models.Repositório;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace DoceApp.Models.Service
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;

		}
		
		public User Create(User user)
		{
			user.Cpf = user.Cpf.Replace(".", "").Replace("-","");
			user.userLogin.Password = EncryptPassword(user.userLogin.Password);
			_userRepository.Create(user);
			return user;
		}

		public string EncryptPassword(string password)
		{  
		    // Cria uma nova intância do objeto que implementa o algoritmo para
		   // criptografia MD5
			MD5 md5 = MD5.Create();

			// Criptografa o valor passado
			byte[] inputBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(password));

			// Cria um StringBuilder para passarmos os bytes gerados para ele
			StringBuilder sb = new StringBuilder();

			// Converte cada byte em um valor hexadecimal e adiciona ao

			// string builder

			// and format each one as a hexadecimal string.

			for (int i = 0; i < inputBytes.Length; i++)
			{
				sb.Append(inputBytes[i].ToString("X2"));
			}
			return sb.ToString();
		}
	}
}
