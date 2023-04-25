﻿using DoceApp.Models.Entidades;

namespace DoceApp.Models.Interfaces
{
	public interface IUserService
	{
		//Task<List<User>> GetAll();
		//Task<User> Get(int Id);
		//Task <User> GetByCpf(string cpf);
		User Create(User user);
		//Task Update(User user);
		//Task<User> Delete(int Id);
		string EncryptPassword(string password);
	}
}
