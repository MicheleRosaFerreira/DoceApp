using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Repositório;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;

namespace DoceApp.Models.Service
{
	public class UserService
	{
		private readonly PeopleRepository _peopleRepository;
		public Login? Usuario { get; set; }
		public UserService(PeopleRepository peopleRepository)
		{
			_peopleRepository = peopleRepository;
		}
		public string Mensagem(string mensagem)
		{
			return mensagem;
		}

		public async Task CreatePeople(People people)
		{
			var peopleCreate = await _peopleRepository.Create(people);
			if (people.Name.IsNullOrEmpty() && people.Email == string.Empty)
				{
					Mensagem("Campos de preenchimento obrigatório!");
				}
			return await peopleCreate;
		}
	}
}