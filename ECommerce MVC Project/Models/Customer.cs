using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ECommerce_MVC_Project.Models
{
    public class Customer : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
    }
}
