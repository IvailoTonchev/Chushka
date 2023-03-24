using Chushka.Data.Models;

namespace Chushka.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ProductName { get; set; }
        public bool OrderedOn { get; set; }
        public string ClientId{ get; set;}
        public int ProductId{ get; set;}
        }
}
