using DoceApp.Models.Entidades;

namespace DoceApp.Models
{
	public class MenuViewModel
	{
		public List<Confectionery> Confectioneries { get; set; }

		public MenuViewModel(List<Confectionery> confectioneries)
		{
			Confectioneries = confectioneries;
		}
	}
}
