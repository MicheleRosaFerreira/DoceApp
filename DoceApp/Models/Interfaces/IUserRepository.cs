using DoceApp.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User> Get(int Id);
        Task<User> Create(User user);
        Task Update(User user);
        Task<User> Delete(int Id);
    }
}
