﻿using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            PessoaDAO dao = new PessoaDAO();
            IList<Pessoa> pessoas = dao.ListarPessoa();
            ViewBag.Pessoa = pessoas;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Pessoa pessoa)            
        {          
            PessoaDAO dao = new PessoaDAO();
            dao.Adicionar(pessoa);

            return RedirectToAction("Index","Pessoa");
        }
    }
}