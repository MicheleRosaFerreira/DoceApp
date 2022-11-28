using DoceApp.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Domain.Interface
{
    public interface IConfectionery
    {
        Task<IEnumerable<Confectionery>> GetAll();
        Task<Confectionery> Get(int Id);
        Task<Confectionery> Create( Confectionery confectionery);
        Task <Confectionery> Update();
        Task <Confectionery> Delete(int Id);

    }
}
