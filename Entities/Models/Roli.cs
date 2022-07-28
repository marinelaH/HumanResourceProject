using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Roli
    {
        public Roli()
        {
            Users = new HashSet<AppUser>();
        }

        public Guid RoliId { get; set; }
        public string RoliEmri { get; set; } = null!;
        public string RoliPershkrim { get; set; } = null!;

        public virtual ICollection<AppUser> Users { get; set; }
    }
}
