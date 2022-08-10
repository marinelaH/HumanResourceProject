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


        [HttpDelete]
        [Route("{ProjektId}")]
        public IActionResult DeleteProject([FromRoute]Guid ProjektId)
        {


            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                _projektDomain.DeleteProject(ProjektId);

                return NoContent();

            }

            catch (Exception ex)
            {
                return NotFound();
            }
            


        }

        /*  [HttpPatch]

          public IActionResult UpdateProject([FromBody] ProjektPostDTO projekt)
          {

              try
              {
                  if (!ModelState.IsValid)
                  {
                      return BadRequest();
                  }

                  if (projekt is null)
                      return BadRequest("ProjektPostDTO object is null");

                  _projektDomain.UpdateProject();

                  return NoContent();

              }

              catch (Exception ex)
              {
                  return StatusCode(500, ex);
              }

          }

          */

        [HttpGet]
        [Route("{ProjektId}")]
        public IActionResult GetProjectById([FromRoute] Guid ProjektId)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                var project = _projektDomain.GetProjectById(ProjektId);

                if (project != null)
                    return Ok(project);

                return NotFound();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}

