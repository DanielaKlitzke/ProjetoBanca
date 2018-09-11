using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBanca.Controllers
{
    public class UnidadeMedidaController : Controller
    {
        // GET: UnidadeMedida
        public ActionResult Index()
        {
            UnidadeMedidaDAO dao = new UnidadeMedidaDAO();
            IList<UnidadeMedida> unidadeMedidas = dao.ListarUnidadeMedida();
            ViewBag.UnidadeMedidas = unidadeMedidas;
            return View();
        }

        public ActionResult Form()
        {
            ViewBag.UnidadeMedida = new UnidadeMedida();
            return View();
        }

        public ActionResult Adiciona(UnidadeMedida unidadeMedida)
        {
            if (ModelState.IsValid)
            {
                UnidadeMedidaDAO dao = new UnidadeMedidaDAO();
                dao.Adicionar(unidadeMedida);
                return RedirectToAction("Index", "UnidadeMedida");
            }
            else
            {
                ViewBag.UnidadeMedida = unidadeMedida;
                return View("Form");
            }
        }
    }
}