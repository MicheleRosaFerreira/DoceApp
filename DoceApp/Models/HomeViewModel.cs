using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
	public class HomeViewModel
	{
		public List<Departament> Departaments { get; set; }
		
		public HomeViewModel()
		{
			Departaments = new List<Departament>();
		}
		
		public HomeViewModel(List<Departament> departaments)
		{
			Departaments = departaments;
		}
	}
}
