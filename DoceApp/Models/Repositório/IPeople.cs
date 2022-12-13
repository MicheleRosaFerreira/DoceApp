using DoceApp.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Interface
{
    public interface IPeople
    {
        Task<IEnumerable<People>> GetAll();
        Task<People> Get(int Id);
        Task<People> Create(People people);
        Task Update(People people);
        Task<People> Delete(int Id);
    }
}
