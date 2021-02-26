using Microsoft.AspNetCore.Mvc;
namespace Mvc_Roy.Controllers

{
    public class ProdutoController : Controller
    {
        public string index(){

            return "Escola SENAI Suíço-Brasileira Paulo Ernesto Tolle";
        }

        public string Welcome(){

            return "Seja Bem-Vindo";
        }

        public string Contato(){

            return "Telefone: (11) 5642-3400   Email:secretaria115@sp.senai.br";
        }
    }
}