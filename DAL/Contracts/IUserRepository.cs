﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IUserRepository: IRepository<AppUser, Guid> {
        AppUser GetById(Guid id);
        AppUser GetByUserName(string username);
    }
}
