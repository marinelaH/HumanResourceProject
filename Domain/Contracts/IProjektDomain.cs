using DTO.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Domain.Contracts
{
    public interface IProjektDomain
    {
         ProjektDTO AddProject(ProjektPostDTO projekt);
         
         IList<ProjektDTO> getAllProjects();

         ProjektDTO GetProjectById(Guid ProjektId); 

       // void UpdateProject(ProjektDTO projektdto);

         void DeleteProject(Guid ProjektId);

         //void UpdateProject()
    }
}
