﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webLectura.Controllers
{
    public class AcercaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
