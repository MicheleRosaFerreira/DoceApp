using DoceApp.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Interface
{
    public interface ILogin
    {
		Task<Login> Create(Login confectionery);
	}
}
