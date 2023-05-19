using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;

namespace DoceApp.Models.Service
{
	public class DepartamentService : IDepartamentService
	{
		private readonly IDepartamentRepository _departament;
		public DepartamentService(IDepartamentRepository departament)
		{
			_departament = departament;
		}

		public List<Departament> GetAllDepartament()
		{
			return _departament.GetAllDepartament();
		}
	}
}
