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
            ViewBag.Pessoa = new Pessoa();
            return View();
        }

        public ActionResult Adiciona(Pessoa pessoa)            
        {
            if (ModelState.IsValid)
            {
                if (InformacoesValidas(pessoa))
                {
                    PessoaDAO dao = new PessoaDAO();
                    dao.Adicionar(pessoa);
                    
                    return RedirectToAction("Form", "Usuario");
                }
                else
                {
                    ViewBag.Pessoa = pessoa;
                    return View("Form");
                }                
            }
            else
            {
                ViewBag.Pessoa = pessoa;
                return View("Form");
            }
        }
        public bool InformacoesValidas(Pessoa pessoa)
        {
            Regex numeros = new Regex(@"^\d+$");
            Regex letras = new Regex(@"^[a-zA-Z]+$");
            if (pessoa.TipoPessoa.Equals("1"))
            {
                if (!pessoa.CpfOuCnpj.Length.Equals(11))
                {
                    ModelState.AddModelError("pessoa.numerosamais", "Cpf tem que ter 11 números");
                    return false;
                }
                if (!numeros.IsMatch(pessoa.CpfOuCnpj))
                {
                    ModelState.AddModelError("pessoa.somenteNumero", "CPf somente números");
                    return false;
                }
            }
            else
            {
                if (!pessoa.CpfOuCnpj.Length.Equals(14))
                {
                    ModelState.AddModelError("pessoa.numerosamaiscnpj", "Cnpj tem que ter 14 números");
                    return false;
                }
                if (!numeros.IsMatch(pessoa.CpfOuCnpj))
                {
                    ModelState.AddModelError("pessoa.somenteNumerocnpj", "CNPJ somente números");
                    return false;
                }
            }
            if (!pessoa.Rg.Length.Equals(7))
            {
                ModelState.AddModelError("pessoa.rgnumerodifere", "RG tem que ter 7 números");
                return false;
            }
            if (!numeros.IsMatch(pessoa.Rg))
            {
                ModelState.AddModelError("pessoa.somenteNumerorg", "RG somente números");
                return false;
            }
            if (!numeros.IsMatch(pessoa.Cep))
            {
                ModelState.AddModelError("pessoa.somentenumerocep", "CEP somente números");
                return false;
            }
            if (!letras.IsMatch(pessoa.Cidade))
            {
                ModelState.AddModelError("pessoa.cidade", "Números não são válidos para Cidade");
                return false;
            }
            if (!letras.IsMatch(pessoa.Estado))
            {
                ModelState.AddModelError("pessoa.estado", "Digite apenas a sigla do Estado");
                return false;
            }

            PessoaDAO dao = new PessoaDAO();
            IList<Pessoa> pessoas = dao.ListarPessoa();
            foreach (var cpfCnpj in pessoas)
            {
                if (cpfCnpj.CpfOuCnpj.Equals(pessoa.CpfOuCnpj))
                {
                    ModelState.AddModelError("pessoa.pessoajacadastrada", "CPF ou CNPJ já cadastrados");
                    return false;
                }
            }
            return true;
        }
    }
}