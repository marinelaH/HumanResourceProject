﻿using AutoMapper;
using DTO.UserDTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mappings
{
    public class GeneralProfile : Profile
    {
        #region User
        public GeneralProfile()
        {
            CreateMap<AppUser, UserDTO>().ReverseMap();
            CreateMap<Projekt, ProjektDTO>().ReverseMap();
            CreateMap<ProjektPostDTO, Projekt>().ReverseMap();
            CreateMap<Edukim, EdukimDTO>().ReverseMap();
            CreateMap<EdukimPostDTO, Edukim>().ReverseMap();
            CreateMap<Certifikate, CertifikateDTO>().ReverseMap();
            CreateMap<CertifikatePostDTO, Certifikate>().ReverseMap();


            //CreateMap<AppUser, UserDTO1>().ReverseMap();

        }

        #endregion


    }
}
