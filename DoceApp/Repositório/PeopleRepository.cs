using DoceApp.Context;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DoceApp.Repositório
{
	public class PeopleRepository : IPeople
	{
		public readonly DoceAppContext _doceAppContext;
		public PeopleRepository(DoceAppContext doceAppContext)
		{
			_doceAppContext = doceAppContext;
		}
		public async Task<People> Create(People people)
		{
			_doceAppContext.Peoples.Add(people);
			await _doceAppContext.SaveChangesAsync();
			return people;
		}

		public async Task<People> Delete(int Id)
		{
			var peopleToDelete = await _doceAppContext.Peoples.FindAsync(Id);	
			_doceAppContext.Peoples.Remove(peopleToDelete);	
			return peopleToDelete;
		}

		public async Task<People> Get(int Id)
		{
			return await _doceAppContext.Peoples.FindAsync(Id);	
		}

		public async Task<IEnumerable<People>> GetAll()
		{
			return await _doceAppContext.Peoples.ToListAsync();
		}

		public async Task Update(People people)
		{
		_doceAppContext.Entry(people).State= EntityState.Modified;
	    await _doceAppContext.SaveChangesAsync();
		}
	}
}
