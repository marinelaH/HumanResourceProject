using Domain.Contracts;
using DTO.UserDTO;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourceProject.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProjektController : ControllerBase
    {
        private readonly IProjektDomain _projektDomain;

        public ProjektController(IProjektDomain projektDomain)
        {
            _projektDomain = projektDomain;
           

        }


        [HttpGet]
        [Route("getAllProjects")]
        public IActionResult getAllProjects()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var projects = _projektDomain.getAllProjects();

                if (projects != null)
                {
                    return Ok(projects);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public IActionResult CreateProject([FromBody] ProjektPostDTO projekt)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                if (projekt is null)
                    return BadRequest("ProjektPostDTO object is null");

                var createdProject = _projektDomain.AddProject(projekt);

                return CreatedAtRoute("", new { id = createdProject.ProjektId,emri = createdProject.EmriProjekt,pershkrimi = createdProject.PershkrimProjekt }, createdProject);

            }
            
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
           
        }


    }
}
