using ProjetoInicio.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoInicio.Controllers
{
    public class ProdutosController : Controller
    {

        private List<Produto> produtos = new List<Produto>()
        {
            new Produto(1, "Notebook", 3000),
            new Produto(2, "Mouse", 200)
        };
        
        public IActionResult Index()
        {
            return View();
        }
    }
}