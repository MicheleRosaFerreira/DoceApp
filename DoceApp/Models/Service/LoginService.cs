﻿using DoceApp.Controllers;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using DoceApp.Models.Repositório;
using DoceApp.Models.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Online.SharePoint.SPLogger;
using Microsoft.SharePoint.Client;
using System.Text;

namespace DoceApp.Models.Service
{
    public class LoginService : ILoginService
	{
		private readonly ILoginRepository _loginRepository;
		public LoginService(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}
		// Não pode existir um usuário repetido no banco de dados e, o nome de usuário não pode ser maior que 11.
		public dynamic GetLogin(Login login)
		{
			var getUser = _loginRepository.GetLogin(login.Nickname, login.Password);
			var token = TokenService.GenerateToken(login);

			return new
			{
				login = login,
				token = token,
			};
		}
	}
}
