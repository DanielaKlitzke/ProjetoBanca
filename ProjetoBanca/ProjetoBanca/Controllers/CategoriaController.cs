using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            CategoriaDAO dao = new CategoriaDAO();
            IList<Categoria> categorias = dao.ListarCategoria();
            ViewBag.Categorias = categorias;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Categoria categoria)
        {
            CategoriaDAO dao = new CategoriaDAO();
            dao.Adicionar(categoria);
            return RedirectToAction("Index", "Categoria");
        }
    }
}