namespace Chushka.Data.Models
{
    public class Product
    {
        public Product()
        {
            this.Orders = new HashSet<ProductOrder> ();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public enum Type_ {Food=1,Domestic=2,Health=3,Cosmetic=4,Other=5 }
        public Type_ Type { get; set; }
        public virtual ICollection<ProductOrder> Orders { get; set; }
    }
}
