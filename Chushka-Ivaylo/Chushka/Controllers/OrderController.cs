using Chushka.Data;
using Chushka.Data.Models;
using Chushka.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chushka.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext db;

        public OrderController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
         return View();
        }
        public IActionResult All()
        {
            return View();
        }
    }
}
