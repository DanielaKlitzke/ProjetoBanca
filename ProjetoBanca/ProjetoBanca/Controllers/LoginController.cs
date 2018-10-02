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

        public ActionResult Autenticacao(String login, String senha, int permissao)
        {
            PessoaDAO dao = new PessoaDAO();
            Pessoa pessoa = dao.BuscaSenha(login, senha, permissao);
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