using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produtos> produtos = dao.ListarProduto();
            ViewBag.Produto = produtos;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Produtos produtos )
        {
            ProdutosDAO dao = new ProdutosDAO();
            dao.Adicionar(produtos);

            return RedirectToAction("Index", "Produto");
        }
    }
}