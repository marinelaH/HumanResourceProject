﻿using DTO.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IUserDomain
    {
        IList<UserDTO> GetAllUsers();
     
        UserDTO GetUserById(Guid id);

        // IList<UserDTO1> GetAllUsers1();


    }
}
