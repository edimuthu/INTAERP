using Microsoft.AspNetCore.Identity;

namespace Inta.ERP.Authorization.Models
{
    public class UserRole<TKey> : IdentityUserRole<TKey> where TKey : IEquatable<TKey>
    {
        public int Status { get; set;}
        public int CreatedUser { get; set; }
        public int LastModifiedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
