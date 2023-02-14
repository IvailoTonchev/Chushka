
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
            var products = db.Products.Select(x => new InputProductModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Description = x.Description,
                Type= (InputProductModel.Type_)x.Type,
            }).ToList();

            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(InputProductModel model)
        {
            var product = new Product { Name = model.Name,
            Id=model.Id,
            Description=model.Description,
            Price = model.Price,
            Type= (Product.Type_)model.Type,
            Orders=model.Orders
            };
            db.Products.Add(product);
            db.SaveChanges();

            return this.Redirect("Index");
        }
    }
}
