using DoceApp.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Interface
{
    public interface IConfectioneryService
    {
        Confectionery GetConfectionery(int id);
        //Task<Confectionery> Get(int Id);
        //Task<Confectionery> Create(Confectionery confectionery);
        //Task Update(Confectionery confectionery);
        //Task<Confectionery> Delete(int Id);

    }
}
