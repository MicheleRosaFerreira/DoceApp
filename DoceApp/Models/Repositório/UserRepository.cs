//using Dapper;
//using DoceApp.Context;
//using DoceApp.Models.Entidades;
//using DoceApp.Models.Interfaces;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.SharePoint.Client;
//using System.Runtime.CompilerServices;
//using System.Text;

//namespace DoceApp.Repositório
//{
//	//vai implementar a DoceAppContext e IUserrepository
//    public class UserRepository : DoceAppContext, IUserRepository
//	{
//		public ActionResult<List<User>> GetAll()
//		{
//			try
//			{
//				var sqlStatement = new StringBuilder("SELECT * FROM [LOGIN]");
//				sqlStatement.AppendLine($"WHERE [USER_ID] = {UserId}");
//				var connection = GetDoceAppCOnnection();
//				var result = connection.Query<Login>(sqlStatement.ToString()).FirstOrDefault();
//				return result;
//			}
//			catch
//			{
				
//			}
//			throw new NotImplementedException();
//		}

//		public Task Update(User user)
//		{
//			throw new NotImplementedException();
//		}

//		ActionResult<User> IUserRepository.Create(User user)
//		{
//			throw new NotImplementedException();
//		}

//		ActionResult<User> IUserRepository.Delete(int Id)
//		{
//			throw new NotImplementedException();
//		}

//		ActionResult<User> IUserRepository.Get(int Id)
//		{
//			throw new NotImplementedException();
//		}
		
//		ActionResult<User> IUserRepository.GetByCpf(string Cpf)
//		{
//			throw new NotImplementedException();
//		}

//		ActionResult IUserRepository.Update(User user)
//		{
//			throw new NotImplementedException();
//		}
//	}
//}
