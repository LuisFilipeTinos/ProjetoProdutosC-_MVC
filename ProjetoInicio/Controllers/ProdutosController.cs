using ProjetoInicio.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace ProjetoInicio.Controllers
{
    public class ProdutosController : Controller
    {
        private List<Produto> produtos = new List<Produto>()
        {
            new Produto(1, "Notebook", 3000),
            new Produto(2, "Mouse", 200),
            new Produto(3, "Teclado", 800),
            new Produto(4, "Gabinete", 500),
            new Produto(5, "Celular", 1000)
        };
        
        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Criar()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Criar(Produto produto)
        {
            produto.Id = produtos.Count + 1;
            produtos.Add(produto);

            return RedirectToAction("Index");
        }
    }
}