using Microsoft.AspNetCore.Identity;

namespace Chushka.Data.Models
{
    public class Client:IdentityUser
    {
        public Client()
        {
            this.Id=Guid.NewGuid().ToString();
            this.Orders = new HashSet<Order>();
        }
        public string FullName { get; set; }
        public virtual ICollection<Order>Orders { get; set; }
    }
}
