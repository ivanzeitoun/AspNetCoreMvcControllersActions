using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvcControllersActions.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcControllersActions.Controllers
{
    public class PessoaController : Controller

    {
        public IActionResult Formulario()
        {
            return View();
        }
        public IActionResult Index()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Ivan";
            pessoa.Telefone = "999-999";
            return View("Pessoa", pessoa);
        }

        [HttpPost]
        public ViewResult Formulario (Pessoa pessoa)
        {
            return View("DetalhesPessoa", pessoa);
        }

    }
}