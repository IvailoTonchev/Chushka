using Chushka.Data.Models;

namespace Chushka.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public ICollection<ProductOrder> Product { get; set; }
        public bool OrderedOn { get; set; }
        public int ClientId{ get; set;}
        }
}
