using DoceApp.Context;
using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace DoceApp.Repositório
{
	public class ConfectioneryRepository : IConfectioneryRepository
	{
		public readonly ContextBase _doceAppContext;
		public ConfectioneryRepository(ContextBase doceAppContext)
		{
			_doceAppContext = doceAppContext;
		}

		public Confectionery GetConfectionery(int id)
		{
			return _doceAppContext.Confectionery.FirstOrDefault(i => i.Departament_Id == id);
		}
		//public async Task<Confectionery> Create(Confectionery confectionery)
		//{
		//	_doceAppContext.Confectioneries.Add(confectionery);
		//	await _doceAppContext.SaveChangesAsync();
		//	return confectionery;
		//}

		//public async Task<Confectionery> Delete(int Id)
		//{
		//	var confectioneryToDelete = await _doceAppContext.Confectioneries.FindAsync(Id);
		//	_doceAppContext.Confectioneries.Remove(confectioneryToDelete);
		//	return confectioneryToDelete;
		//}

		//public async Task<Confectionery> Get(int Id)
		//{
		//	return await _doceAppContext.Confectioneries.FindAsync(Id);

		//}

		//public async Task Update(Confectionery confectionery)
		//{
		//	_doceAppContext.Entry(confectionery).State = EntityState.Modified;
		//	await _doceAppContext.SaveChangesAsync();
		//}
	}
}
