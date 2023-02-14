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
            var orders = db.Orders.Select(x => new InputOrderModel
            {
                Id = x.Id,
              Client=x.Client,
              ClientId=x.ClientId,
              OrderedOn=x.OrderedOn,
              Product=x.Product,
            }).ToList();

            return View(orders);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Add(InputOrderModel model)
        {
            var order = new Order { Id = model.Id,
            Client=model.Client,
            ClientId = model.ClientId,
            OrderedOn= model.OrderedOn,
            Product=model.Product,
            
            };
            db.Orders.Add(order);
            db.SaveChanges();

            return this.Redirect("Index");
        }

    }
}
