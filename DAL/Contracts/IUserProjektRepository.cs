﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IUserProjektRepository : IRepository<UserProjekt, Guid>
    {
       // public ICollection<UserProjekt> GetByUserId(Guid id);
       
    }
}
