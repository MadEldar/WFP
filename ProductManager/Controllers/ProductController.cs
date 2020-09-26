using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Services;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        public ProductController(ProductManagerService productService)
        {
            ProductService = productService;
        }

        public ProductManagerService ProductService { get; }

        [Route("/Products")]
        public IActionResult Index()
        {
            return View(ProductService.GetProducts());
        }
    }
}
