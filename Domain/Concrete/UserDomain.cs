﻿using AutoMapper;
using DAL.Contracts;
using DAL.UoW;
using Domain.Contracts;
using DTO.UserDTO;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    internal class UserDomain : DomainBase, IUserDomain
    {
        public UserDomain(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(unitOfWork, mapper, httpContextAccessor)
        {
        }

        private IUserRepository userRepository => _unitOfWork.GetRepository<IUserRepository>();
        public IList<UserDTO> GetAllUsers()
        {
            IEnumerable<AppUser> user = userRepository.GetAll();
           
            var test = _mapper.Map<IList<UserDTO>>(user);
            return test;
        }
        /*public IList<UserDTO1> GetAllUsers1()
        {
            IEnumerable<AppUser> user = userRepository.GetAll();

            var test = _mapper.Map<IList<UserDTO1>>(user);
            return test;


        }
             */
        public UserDTO GetUserById(Guid id)
        {
            AppUser user = userRepository.GetById(id);
           // user.UserProjekts =  
            return _mapper.Map<UserDTO>(user);
        }
    }
}
