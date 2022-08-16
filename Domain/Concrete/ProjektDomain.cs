﻿using AutoMapper;
using DAL.Contracts;
using DAL.UoW;
using Domain.Contracts;
using DTO.UserDTO;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class ProjektDomain : DomainBase, IProjektDomain
    {
        public ProjektDomain(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(unitOfWork, mapper, httpContextAccessor)
        {
        }

        private IProjektRepository projektRepository => _unitOfWork.GetRepository<IProjektRepository>();

       public ProjektDTO AddProject(ProjektPostDTO projekt)
        {
            var projektEntity = _mapper.Map<Projekt>(projekt);
            var projektFinal = projektRepository.Add(projektEntity);
            var projektToReturn = _mapper.Map<ProjektDTO>(projektFinal);
            _unitOfWork.Save();
            return projektToReturn;
          
         
           


        }




        public IList<ProjektDTO> getAllProjects()
        {
            IEnumerable<Projekt> user = projektRepository.GetAll();

            var test = _mapper.Map<IList<ProjektDTO>>(user);
            return test;
        }

        public ProjektDTO GetProjectById(Guid ProjektId)
        {
            var project = projektRepository.GetById(ProjektId);
            return _mapper.Map<ProjektDTO>(project);

        }

        public void DeleteProject(Guid ProjektId)
        {
            try
            {
                var project=projektRepository.GetById(ProjektId);
                if (project is null)
                    throw new Exception();
                projektRepository.Remove(ProjektId);
                _unitOfWork.Save();

            }

            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void PutProject(Guid ProjektId,ProjektPostDTO projekt)
        {

            var projektentity = projektRepository.GetById(ProjektId);

            if (projektentity is null)
                throw new Exception();
             projektentity = _mapper.Map<ProjektPostDTO,Projekt>(projekt,projektentity);
 
            projektRepository.Update(projektentity);
            _unitOfWork.Save();
        }
        public void PatchProject(Guid ProjektId,JsonPatchDocument patchDoc)
        {
            var project = projektRepository.GetById(ProjektId);
            if (project is null)
                throw new Exception();
            patchDoc.ApplyTo(project);
            _unitOfWork.Save();

        }
        
}



    
}