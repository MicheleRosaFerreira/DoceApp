﻿using DoceApp.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Interface
{
	public interface ILoginRepository
	{
		ActionResult<Login> GetLogin(int UserId);
		
	}
}
