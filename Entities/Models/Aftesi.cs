using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Aftesi
    {
        public Aftesi()
        {
            Users = new HashSet<AppUser>();
        }

        public Guid AftesiId { get; set; }
        public string LlojiAftesise { get; set; } = null!;

        public virtual ICollection<AppUser> Users { get; set; }
    }
}
