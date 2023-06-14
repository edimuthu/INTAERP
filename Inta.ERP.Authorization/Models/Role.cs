using Microsoft.AspNetCore.Identity;

namespace Inta.ERP.Authorization.Models
{
    public class Role : IdentityRole<string>
    {
        public string Name { get; set; }
        public int Status { get; set; }
        public int CreatedUser { get; set; }
        public int LastModifiedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        //public virtual ICollection<ApplicationUser> Users { get; } = new List<ApplicationUser>();
    }
}
