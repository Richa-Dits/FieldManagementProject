using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FieldMgt.Core;
using FieldMgt.Core.Interfaces;
using FieldMgt.Core.DomainModels;
using Microsoft.AspNetCore.Identity;
using FieldMgt.Core.DTOs;
using FieldMgt.Core.DTOs.Response;

namespace FieldMgt.Repository.Repository
{
    public class RoleRepository:IRoleRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _dbcontext;
        private readonly UserManager<ApplicationUser> _userManager;
        public RoleRepository(RoleManager<IdentityRole> roleManager, ApplicationDbContext dbcontext, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _dbcontext = dbcontext;
            _userManager = userManager;
        }
        public RoleRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<UserManagerReponse> AddRoleAsync(string role)
        {
            IdentityRole userRole = new IdentityRole(role) ;
            var result = await _roleManager.CreateAsync(userRole);
            if (result.Succeeded)
            {
                return new UserManagerReponse
                {
                    Message = "Role Created Successfully",
                    IsSuccess = true
                };
            }
            return new UserManagerReponse
            {
                Message = "Role not created",
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description)
            };
        }
        public IEnumerable<string> ListRoles()
        {
           var roles= _dbcontext.Roles.ToList();
            foreach(var role in roles)
            {
                yield return role.Name;
            }
        }
        public async Task<UserManagerReponse> EditUserRoles(string userName, string role)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.UserName == userName);
            var roles=_roleManager.FindByNameAsync(role);
            if(roles.Result==null)
            {
                return new UserManagerReponse
                {
                    Message = "Role doesn't exist"
                };
            }
            else { 
            string roleName = roles.Result.Name.ToString();
            var result=await _userManager.AddToRoleAsync(user, roleName);            
                return new UserManagerReponse
                {
                    Message = result.ToString()
                };
            }
        }
        public async Task<UserManagerReponse> RemoveUserRoles(string userName, string role)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.UserName == userName);
            var roles = _roleManager.FindByNameAsync(role);
            if (roles.Result == null)
            {
                return new UserManagerReponse
                {
                    Message = "Role doesn't exist",
                    IsSuccess=false
                };
            }
            else
            {
                string roleName = roles.Result.Name.ToString();
                var result = await _userManager.RemoveFromRoleAsync(user, roleName);
                return new UserManagerReponse
                {
                    Message = result.ToString(),
                    IsSuccess = true
                };
            }
        }
    }
}
