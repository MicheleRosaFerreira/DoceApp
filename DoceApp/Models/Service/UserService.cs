using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using DoceApp.Models.Repositório;
using System.ComponentModel.DataAnnotations;

namespace DoceApp.Models.Service
{
	public class UserService :IUserService
	{
		private readonly IUserRepository _userRepository;
		public UserService()
		{
			//_userRepository = new UserRepository();
		
		}
		
		public Task<List<User>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<User> Get(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<User> Create(User user)
		{
			try
			{
				
			}
			catch (Exception ex)
			{
				throw new Exception();
			}
			throw new NotImplementedException();
		}

		public Task Update(User user)
		{
			throw new NotImplementedException();
		}

		public Task<User> Delete(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<User> GetByCpf(string cpf)
		{
			throw new NotImplementedException();
		}
	}
}