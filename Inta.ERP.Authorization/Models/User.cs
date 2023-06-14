using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Inta.ERP.Authorization.Models
{
    public class User: IdentityUser<string>
    {
        public int BranchId { get; set; }
        public bool Active { get; set; }
        public bool IsApiUser { get; set; }
        public decimal MaximumApproveAmount { get; set; }
        public decimal MaximumPettyCashApproveAmount { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsForcedLogoutPending { get; set; }
        public int Status { get; set; }
        public int CreatedUser { get; set; }
        public int LastModifiedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        // public virtual ICollection<ApplicationRole> Roles { get; } = new List<ApplicationRole>();
    }
}
