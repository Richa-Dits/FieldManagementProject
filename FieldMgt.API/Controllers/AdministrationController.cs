using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FieldMgt.Core.Interfaces;

namespace FieldMgt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrationController : ControllerBase
    {
        private readonly IRoleRepository _roleService;
        public AdministrationController(IRoleRepository roleService)
        {
            _roleService=roleService ;
        }

        [Route("/api/Administration/AddRole")]
        [HttpGet]
        public async Task<IActionResult> AddRoleAsync(string role)
        {
            var result = await _roleService.AddRoleAsync(role);
                if (result.Message == "Succeeded")
                    return Ok(result);//status code 200
            return BadRequest(result);
        }
        [Route("~/api/Administration/List")]
        [HttpGet]
        public IEnumerable<string> ListRoles()
        {
            var roles = _roleService.ListRoles();
            return roles;
        }
        [Route("~/api/Administration/EditRoles")]
        [HttpGet]
        public async Task<IActionResult> EditUserRoles(string userName, string role)
        {
            var result = await _roleService.EditUserRoles(userName, role);
            if (result.Message == "Succeeded")
                //if (result.IsSuccess)
                return Ok(result);//status code 200
            return BadRequest(result);
        }
        [Route("~/api/Administration/RemoveUserRoles")]
        [HttpGet]
        public async Task<IActionResult> RemoveUserRoles(string userName, string role)
        {
            var result = await _roleService.RemoveUserRoles(userName, role);
            if(result.Message=="Succeeded")
            //if (result.IsSuccess)
                return Ok(result);//status code 200
            return BadRequest(result);
        }
        
    }
}
