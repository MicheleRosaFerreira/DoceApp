//using DoceApp.Interface;
//using DoceApp.Models.Entidades;
//using DoceApp.Repositório;
//using Microsoft.IdentityModel.Tokens;
//using System.ComponentModel.DataAnnotations;

//namespace DoceApp.Models.Service
//{
//	public class UserService
//	{
//		public readonly PeopleRepository _peopleRepository;
//		public UserService(PeopleRepository peopleRepository)
//		{
//			_peopleRepository = peopleRepository;
//		}
//		public string Mensagem(string mensage)
//		{
//			return mensage;
//		}
//		public async Task CreatePeople(People people)
//		{
			
//			if (people.Name.IsNullOrEmpty() && people.Email == string.Empty)
//				{
//					Mensagem("Campos de preenchimento obrigatório!");
//				}
//			await _peopleRepository.Create(people);
//		}
//	}
//}