﻿using Domain.Contracts;
using DTO.UserDTO;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourceProject.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserDomain _userDomain;

        public UserController(IUserDomain userDomain)
        {
            _userDomain = userDomain;
        }


        [HttpGet]
        [Route("getAllUsers")]
        public IActionResult GetAllUsers()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var users = _userDomain.GetAllUsers();

                if (users != null)
                {
                    return Ok(users);
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


        [HttpGet]
        [Route("{userId}")]
        public IActionResult GetUserById([FromRoute] Guid userId)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                var user = _userDomain.GetUserById(userId);

                if (user != null)
                    return Ok(user);

                return NotFound();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

   /* [HttpPost]
    [Route("AddProject")]
    public IActionResult AddProject([FromBody] Entities.Models.Projekt projekt)
    {
        try
        {
            if (!ModelState.IsValid)
                return BadRequest();



            var user = _userDomain.AddProject(eProjekt projekt);

            if (user != null)
                return Ok(user);

            return NotFound();
        }

        catch (Exception ex)
        {
            throw ex;
        }
    }
}
    */
}

