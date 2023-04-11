using DoceApp.Context;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Text;


namespace DoceApp.Repositório
{
	//vai implementar a ContexBase e IUserRepository
	public class UserRepository : IUserRepository
	{
		private readonly ContextBase _context;
		public UserRepository(ContextBase context)
		{
			_context = context;
		}
		public User Create(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
			return user;
		}
	}
}
