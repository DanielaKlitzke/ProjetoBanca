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
                    
                    return RedirectToAction("Index", "Produto");
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
            Regex letrasComEspaco = new Regex(@"^[a-zA-Z]+\s*[a-zA-Z]*$");
            Regex letras = new Regex(@"^[a-zA-Z]+$");
            Regex email = new Regex(@"[a-z]?[0-9]?[@][a-z]+");

            if (CpfDuplicado(pessoa))
            {
                ModelState.AddModelError("pessoa.jaExiste", "Jé existe outra pessoa com este CPF/CNPJ");
                return false;
            }

            if (pessoa.TipoPessoa.Equals("1"))
            {
                if (pessoa.CpfOuCnpj.Length !=11 )
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
            else if (pessoa.TipoPessoa.Equals("2"))
            {
                if (pessoa.CpfOuCnpj.Length !=14)
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
            if (pessoa.Rg.Length <7 || pessoa.Rg.Length >8)
            {
                ModelState.AddModelError("pessoa.rgnumerodifere", "RG tem que ter até 8 números");
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
            if (pessoa.Cidade.Trim(' ').Equals(string.Empty))
            {
                ModelState.AddModelError("pessoa.validacidade", "Números não são válidos para Cidade");
                return false;
            }
            if (!letras.IsMatch(pessoa.Estado))
            {
                ModelState.AddModelError("pessoa.validaestado", "Digite apenas a sigla do Estado");
                return false;
            }
            if (!email.IsMatch(pessoa.Email))
            {
                ModelState.AddModelError("pessoa.validaemail", "Informe um email válido!");
                return false;
            }

            return true;
        }

        public bool CpfDuplicado(Pessoa pPessoa)
        {
            PessoaDAO dao = new PessoaDAO();
            var pessoa = dao.BuscaPorCpfOuCnpj(pPessoa.CpfOuCnpj);
            if (pessoa != null && pPessoa.IdPessoa != pessoa.IdPessoa )
            {
                return true;
            }
            return false;
        }
    }
}