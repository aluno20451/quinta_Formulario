using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //viewbag para guardar a resposta
            ViewBag.msg = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nome, int? idade){
            /// precisamos de validar os dados introduzidos pelo utilizador
            /// 1º questão: o nome é um 'nome'?
            /// 2º questão: a idade está dentro dos parâmetros pretendidos [0;120]?

            string mensagem="";
            // validar a idade
            if (idade >= 0 && idade <= 120)
            {
                mensagem = "Voce chama-se " + nome + " e tem " + idade + " anos.";
            }
            else {
                //mensagem alternativa
                mensagem = "Deve especificar uma idade válida!\n"
                    +"A idade deve ser maior que zero e menor que 120 anos...";
            }

            // criar a mensagem de resposta
            // criar o 'contentor' que leva a resposta para a View
            ViewBag.msg = mensagem;
            
            // invoca a view
            return View();
        }
    }
}