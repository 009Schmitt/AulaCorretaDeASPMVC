using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AulaMVC.Models;

namespace AulaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var pessoa = new Pessoa
            {
                IdPessoa = 1,
                Nome = "Joeslei",
                Cpf = "Heroi"
            };

            //ViewData["IdPessoa"] = pessoa.IdPessoa;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Cpf"] = pessoa.Cpf;

            ViewBag.IdPessoa = pessoa.IdPessoa;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Cpf = pessoa.Cpf;

            return View();
        }
        
        [HttpPost]
        public IActionResult Cadastro(int id,string nome, string cpf)
        {
            ViewBag.IdPessoa = id;
            ViewBag.Nome = nome;
            ViewBag.Cpf = cpf;

            //string insert = $"Insert into Pessoa (idPessoa, Nome,cpf) values ({id},'{nome}','{cpf}')";

            return View();
        }


        public IActionResult Contatos()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
