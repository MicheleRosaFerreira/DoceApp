using DoceApp.Context;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;

namespace DoceApp.Models.Repositório
{
	public class DepartamentRepository : IDepartamentRepository
	{
		private readonly ContextBase _contextBase;
		public DepartamentRepository(ContextBase context)
		{
			_contextBase = context;
		}
		public List<Departament> GetAllDepartament()
		{
			return _contextBase.Departament.ToList();
		}
	}
}
