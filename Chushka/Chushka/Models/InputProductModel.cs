using Chushka.Data.Models;

namespace Chushka.Models
{
    public class InputProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public enum Type_ { Food = 1, Domestic = 2, Health = 3, Cosmetic = 4, Other = 5 }
        public Type_ Type{get; set;}
        public ICollection<ProductOrder> Orders { get; internal set; }
    }
}
