using ProjetoBanca.DAO;
using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            ViewBag.Produtos = produtos;
            return View(produtos);
        }

        public ActionResult Form()
        {
            object logado = Session["pessoaLogada"];
            if (logado != null)
            {

                CarregarViewBag();
                ViewBag.Produtos = new Produtos();
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");

            }
        }

        public void CarregarViewBag()
        {
            UnidadeMedidaDAO unidadeDao = new UnidadeMedidaDAO();
            IList<UnidadeMedida> unidades = unidadeDao.ListarUnidadeMedida();
            ViewBag.UnidadeMedidas = unidades;

            CategoriaDAO categoriaDao = new CategoriaDAO();
            IList<Categoria> categorias = categoriaDao.ListarCategoria();
            ViewBag.Categorias = categorias;
        }

        public ActionResult Adiciona(Produtos produtos)
        {
            CarregarViewBag();
            if (ModelState.IsValid)
                {
                    if (ValidaProduto(produtos))
                    {
                        ProdutosDAO dao = new ProdutosDAO();
                        dao.Adicionar(produtos);

                        return RedirectToAction("Index", "Produto");
                    }
                    else
                    {
                        ViewBag.Produtos = produtos;
                        return View("Form");
                    }
                }
                else
                {
                    ViewBag.Produtos = produtos;
                    return View("Form");
                }
            
        }
        public bool ValidaProduto(Produtos produtos)
        {
            Regex numeros = new Regex(@"^\d+$");
            if (!numeros.IsMatch(produtos.CodigoProduto))
            {
                ModelState.AddModelError("produtos.codigoComNumero", "Código: Somente números");
                return false;
            }
            if (produtos.ValorProduto < 0)
            {
                ModelState.AddModelError("produtos.valorNegativo", "Valor não pode ser negativo");
                return false;
            }
            return true;
        }

        public bool CodigoDuplicado(Produtos produtos)
        {
            ProdutosDAO dao = new ProdutosDAO();
            var produto = dao.Busca(produtos.CodigoProduto);
            if (produto != null && produtos.CodigoProduto != produto.CodigoProduto)
            {
                return true;
            }
            return false;
        }
    }
}