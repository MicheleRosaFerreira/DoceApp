using DoceApp.Interface;
using DoceApp.Models.Entidades;
using DoceApp.Models.Interfaces;

namespace DoceApp.Models.Service
{
    public class ConfectioneryService : IConfectioneryService
    {
        private readonly IConfectioneryRepository _confectionery;
        public ConfectioneryService(IConfectioneryRepository confectionery)
        {
            _confectionery = confectionery;
        }

        public Confectionery GetConfectionery(int id)
        {
           return _confectionery.GetConfectionery(id);
		}
    }
}
