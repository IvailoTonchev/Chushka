
using Chushka.Data;
using Chushka.Data.Models;
using Chushka.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chushka.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext db;

        public ProductController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Add(InputProductModel input)
        {
            var prdouct = new Product 
            {
            Name = input.Name,
            Price = input.Price,
            Description = input.Description,
            Type= (Product.Type_)input.ProductType,
            };
            db.Products.Add(prdouct);
            db.SaveChanges();
            return Redirect("/");
        }

    }
}
