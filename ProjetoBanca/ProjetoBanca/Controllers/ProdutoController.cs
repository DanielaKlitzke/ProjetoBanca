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
            UnidadeMedidaDAO unidadeDao = new UnidadeMedidaDAO();
            IList<UnidadeMedida> unidades = unidadeDao.ListarUnidadeMedida();
            ViewBag.UnidadeMedidas = unidades;

            CategoriaDAO categoriaDao = new CategoriaDAO();
            IList<Categoria> categorias = categoriaDao.ListarCategoria();
            ViewBag.Categorias = categorias;
            return View();           
        }

        public ActionResult Adiciona(Produtos produtos )
        {
            if (ModelState.IsValid)
            {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adicionar(produtos);

                return RedirectToAction("Index", "Produto");
            }
            else
            {
                CategoriaDAO categoriaDAO = new CategoriaDAO();
                ViewBag.Categoria = categoriaDAO.ListarCategoria();
                return View("Form");
            }
           
        }
    }
}