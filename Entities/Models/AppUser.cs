using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            DetajeUsers = new HashSet<DetajeUser>();
            Lejes = new HashSet<Leje>();
            UserCertifikates = new HashSet<UserCertifikate>();
            UserEdukims = new HashSet<UserEdukim>();
            UserPervojePunes = new HashSet<UserPervojePune>();
            UserProjekts = new HashSet<UserProjekt>();
            Aftesis = new HashSet<Aftesi>();
            Rolis = new HashSet<Roli>();
        }

        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserFirstname { get; set; } = null!;
        public string UserLastname { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public int BalancaLeje { get; set; }
        public bool UserIsActive { get; set; }

        public virtual ICollection<DetajeUser> DetajeUsers { get; set; }
        public virtual ICollection<Leje> Lejes { get; set; }
        public virtual ICollection<UserCertifikate> UserCertifikates { get; set; }
        public virtual ICollection<UserEdukim> UserEdukims { get; set; }
        public virtual ICollection<UserPervojePune> UserPervojePunes { get; set; }
        public virtual ICollection<UserProjekt> UserProjekts { get; set; }

        public virtual ICollection<Aftesi> Aftesis { get; set; }
        public virtual ICollection<Roli> Rolis { get; set; }
    }
}
