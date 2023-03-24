
using Chushka.Data;
using Chushka.Data.Models;
using Chushka.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Chushka.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext db;
        private readonly UserManager<Client> userManager;

        public ProductController(ApplicationDbContext db, UserManager<Client> userManager)
        {
            this.db = db;
            this.userManager = userManager;              
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Delete()
        {

            return View();
        }
        public async Task <IActionResult>  Details(int Id)
        {
            var client = await userManager.GetUserAsync(this.User);
            var model = db.Products.Where(x=>x.Id==Id).Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Id = x.Id,
                ClientId=client.Id,
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
