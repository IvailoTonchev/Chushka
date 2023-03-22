using Microsoft.AspNetCore.Identity;

namespace Chushka.Data.Models
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole():this(null)
        {
        }
           
        public ApplicationRole(string name)
        {
            Name = name;
            Id = Guid.NewGuid().ToString();
            
        }
    }
}
