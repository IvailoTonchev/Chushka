using Chushka.Data.Models;

namespace Chushka.Models
{
    public class InputOrderModel
    {
        public int Id { get; set; }
        public ICollection<ProductOrder> Product { get; set; }
        public bool OrderedOn { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
