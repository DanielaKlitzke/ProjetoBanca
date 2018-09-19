using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autenticacao(String login, String senha)
        {
            PessoaDAO dao = new PessoaDAO();
            Pessoa pessoa = dao.Busca(login, senha);
            if (pessoa != null)
            {
                Session["pessoaLogada"] = pessoa;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                return View("Index");
            }
            
        }
    }
}