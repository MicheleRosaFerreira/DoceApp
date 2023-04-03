﻿using DoceApp.Models;
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
		Login GetLogin(string nickname ,string password);
		//ActionResult<Loginn> GetLoginNickname(string nickName);


	}
}
