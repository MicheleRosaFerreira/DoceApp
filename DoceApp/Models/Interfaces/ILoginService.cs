using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace DoceApp.Models.Interfaces
{
	public interface ILoginService
	{
		ActionResult<Login> GetLogin(int UserId);
	}
}
