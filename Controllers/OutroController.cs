using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class OutroController : Controller
    {
        public IActionResult Index()
        {
            return View("Resultado", "Outro Controller");
        }
    }
}