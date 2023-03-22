
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
        public IActionResult Delete()
        {

            return View();
        }
        public IActionResult Details(int Id)
        {
            var model = db.Products.Where(x=>x.Id==Id).Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Id = x.Id,
                Price = x.Price,

            }).FirstOrDefault();
            return View(model);

        }
        public IActionResult Detailsadmin()
        {

            return View();
        }
        public IActionResult Update()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(InputProductModel input)
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
        [HttpGet]
        public IActionResult AdminHome()
        {
            var model = db.Products.Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description=x.Description,
                Id=x.Id,
                Price=x.Price
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult AdminHome(ProductViewModel x)
        {
            return View();
        }
        public IActionResult Order()
        {
            return RedirectToAction("All","Order");
        }
    }
}
