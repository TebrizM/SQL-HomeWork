﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstHomeWork.Controllers
{
    public class ProfileController:Controller
    {
        public ActionResult Contact()
        {
            return View();
        }
    }
}
