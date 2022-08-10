﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.UserDTO
{
    public class UserDTO
    {
       public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserFirstname { get; set; } = null!;
        public string UserLastname { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public int BalancaLeje { get; set; }
        public bool UserIsActive { get; set; }

       // public virtual ICollection<UserProjekt> UserProjekts { get; set; }

        // public byte[] PasswordHash { get; set; } = null!;
        // public byte[] PasswordSalt { get; set; } = null!;
    }
}
