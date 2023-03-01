using Dapper;
using DoceApp.Context;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoceApp.Repositório
{
	//vai implementar a DoceAppContext e IUserrepository
    public class UserRepository : DoceAppContext,IUserRepository
	{

		public Task<User> Create(User user)
		{
			try
			{
				var connection = GetDoceAppCOnnection();
				connection.Open();
				var sqlStatement = @"INSERT INTO PESSOA (
				 NAME
				,CPF
				,BITHDARTE
				,EMAIL 
				VALUES(@Name,@Cpf,@Bithdate,@Email
				)";
				connection.Execute(sqlStatement, user);
				return Task.FromResult(user);
			}
			 catch (Exception ex)
			{
				throw new NotImplementedException();
			}
			finally
			{
				Dispose();
			}
		}

		public Task<User> Delete(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<User> Get(int Id)
		{
			throw new NotImplementedException();
		}

		public Task Update(User user)
		{
			throw new NotImplementedException();
		}

		Task<List<User>> IUserRepository.GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
