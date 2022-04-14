using Microsoft.AspNetCore.Identity;
namespace ECommerce_MVC_Project.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
