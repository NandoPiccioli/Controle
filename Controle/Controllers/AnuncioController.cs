using Controle.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Controllers
{
    public class AnuncioController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
