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
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
			byte[] hash = md5.ComputeHash(inputBytes);
			
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++)
			{
				sb.Append(hash[i].ToString("X2"));
			}
			return sb.ToString();
		}
	}
}
