using DoceApp.Context;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DoceApp.Repositório
{
	public class ConfectioneryRepository : IConfectionery
	{
		public readonly DoceAppContext _doceAppContext;
		public ConfectioneryRepository(DoceAppContext doceAppContext)
		{
			_doceAppContext = doceAppContext;
		}
		public async Task<Confectionery> Create(Confectionery confectionery)
		{
			_doceAppContext.Confectioneries.Add(confectionery);
			await _doceAppContext.SaveChangesAsync();
			return confectionery;
		}

		public async Task<Confectionery> Delete(int Id)
		{
			var confectioneryToDelete = await _doceAppContext.Confectioneries.FindAsync(Id);
			_doceAppContext.Confectioneries.Remove(confectioneryToDelete);
			return confectioneryToDelete;
		}

		public async Task<Confectionery> Get(int Id)
		{
			return await _doceAppContext.Confectioneries.FindAsync(Id);
			
		}

		public async Task<IEnumerable<Confectionery>> GetAll()
		{
			return await _doceAppContext.Confectioneries.ToListAsync();
		}

		public async Task  Update(Confectionery confectionery)
		{
			_doceAppContext.Entry(confectionery).State= EntityState.Modified;
			await _doceAppContext.SaveChangesAsync();	
		}
	}
}
