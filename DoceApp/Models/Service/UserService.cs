using DoceApp.Controllers;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using DoceApp.Models.Repositório;
using System.ComponentModel.DataAnnotations;
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
			_userRepository.Create(user);
			return user; 
		}

		public string EncryptPassword(string password)
		{
			var encodedValue = Encoding.UTF8.GetBytes(password);

			return encodedValue.ToString();
		}
	}
}
