using DoceApp.Models.Entidades;

namespace DoceApp.Models.Interfaces
{
	public interface IConfectioneryRepository
	{
		Confectionery GetConfectionery(int id);
	}
}
