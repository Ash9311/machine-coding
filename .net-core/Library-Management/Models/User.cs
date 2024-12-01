using Microsoft.AspNetCore.Identity;
namespace Library_Management.Models
{
    public class User:IdentityUser
    {
        public string FullName { get; set; }
    }
}
