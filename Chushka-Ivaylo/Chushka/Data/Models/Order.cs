namespace Chushka.Data.Models
{
    public class Order
    {
        public Order()
        {
            this.Product = new HashSet<ProductOrder>();
        }
        public int Id { get; set; }
        public ICollection <ProductOrder> Product { get; set; }
        public bool OrderedOn { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

    }
}
