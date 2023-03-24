using Chushka.Data;
using Chushka.Data.Migrations;
using Chushka.Data.Models;
using Chushka.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public IActionResult Add(InputOrderModel model)
        {
            var order = new Order
            {
               ClientId = model.ClientId,
                
            };
            
                var product = db.Products.FirstOrDefault(x => model.ProductId == x.Id);           

                order.Product.Add(new ProductOrder
                {
                    Product = product      
                });
            

            db.Orders.Add(order);
            db.SaveChanges();
   
            return RedirectToAction ("All");
        }
    }
}
