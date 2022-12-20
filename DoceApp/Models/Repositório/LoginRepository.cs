//using DoceApp.Context;
//using DoceApp.Interface;
//using DoceApp.Models.Entidades;

//namespace DoceApp.Repositório
//{
//	public class LoginRepository : ILogin
//	{
//		public readonly DoceAppContext _doceAppContext;
//		public LoginRepository(DoceAppContext doceAppContext)
//		{
//			_doceAppContext = doceAppContext;
//		}
//		public async Task<Login> Create(Login confectionery)
//		{
//			_doceAppContext.Acess.Add(confectionery);
//			await _doceAppContext.SaveChangesAsync();
//			return confectionery;
//		}
//	}
//}
