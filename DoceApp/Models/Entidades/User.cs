﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoceApp.Models.Entidades
{
	public class User
	{
		[Key]
		public int User_Id { get; set; }
		public string Name { get; set; }
		public string Cpf { get; set; }
		public DateTime Birthdate { get; set; }
		public string Email { get; set; }
		public Login userLogin { get; set; }

		public User()
		{

		}
		public User(string name, string cpf, DateTime bithdate, string email, string nickName, string password)
		{
			Name = name;
			Cpf = cpf;
			Birthdate = bithdate;
			Email = email;
			userLogin = new Login(nickName,password);
		}
		public User(UserViewModel userViewModel)
		{
			Name = userViewModel.Name;
			Cpf = userViewModel.Cpf;
			Birthdate = userViewModel.Birthdate;
			Email = userViewModel.Email;
			userLogin = new Login(userViewModel.Nickname, userViewModel.Password);
		}
	}
}
 