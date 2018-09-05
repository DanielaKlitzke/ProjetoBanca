using ProjetoBanca.DAO;
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
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Pessoa pessoa)
            
            /*(String nome, String cpfoucnpj, String sexo, String endereco, String bairro,
            int numeroResidencia, String complemento, String cidade, String estado, String cep, int telefone,
            String dataNascimento, String email)*/
        {
            /*Pessoa pessoa = new Pessoa()
            {
                Nome = nome,
                CpfOuCnpj = cpfoucnpj,
                Sexo = sexo,
                Endereco = endereco,
                Bairro = bairro,
                NumeroResidencia = numeroResidencia,
                Complemento = complemento,
                Cidade = cidade,
                Estado = estado,
                Cep = cep,
                Telefone = telefone,
                DataNascimento = dataNascimento,
                Email = email
            };*/

            PessoaDAO dao = new PessoaDAO();
            dao.Adicionar(pessoa);

            return View();
        }
    }
}