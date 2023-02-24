
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
        public IActionResult Add()
        {
            return this.View();
        }

    }
}
