using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _repositoryContext;

        public ProductController(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public IActionResult Index()
        {
            return View(model: _repositoryContext.Products.ToList());
        }

        public IActionResult Get(int id)
        {
            var product = _repositoryContext.Products.FirstOrDefault(p => p.ProductId == id);
            return View(model: product);
        }
    
    }
}