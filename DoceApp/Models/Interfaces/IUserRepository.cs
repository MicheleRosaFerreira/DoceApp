using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Models.Interfaces
{
    public interface IUserRepository
    {
		ActionResult<List<User>> GetAll();
		ActionResult<User> Get(int Id);
		ActionResult<User> GetByCpf(string Cpf);
		ActionResult<User> Create(User user);
		ActionResult Update(User user);
		ActionResult<User> Delete(int Id);
    }
}
