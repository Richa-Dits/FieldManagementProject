using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FieldMgt.Core.Interfaces;
using AutoMapper;
using FieldMgt.Core.DomainModels;
using FieldMgt.Core.UOW;
using FieldMgt.API.Infrastructure.Services;
using FieldMgt.Core.DTOs.Request;
using System;
using Microsoft.AspNetCore.Authorization;

namespace FieldMgt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userService;
        private readonly IMapper _mapper;
        private readonly IUnitofWork _uow;
        private readonly ICurrentUserService _currentUserService;
        public AuthController(IUserRepository userService, IUnitofWork uow, IMapper mapper,ICurrentUserService currentUserService)
        {
            _userService=userService;
            _mapper = mapper;
            _currentUserService = currentUserService;
            _uow = uow;
        }        
        [Authorize(Policy = "Admin")]
        [HttpPost]
        [Route("api/auth/Register")]
        public async Task<IActionResult> RegisterAsync([FromBody]CreateEmployeeDTO model)
        {
            throw new UnauthorizedAccessException();
            try
            {
                RegisterUserDTO registerDTO = new RegisterUserDTO();
                registerDTO.Email = model.Email;
                registerDTO.Password = model.Password;
                registerDTO.ConfirmPassword = model.ConfirmPassword;
                registerDTO.CreatedBy = _currentUserService.GetUserId();
                registerDTO.CreatedOn = System.DateTime.Now;
                    var result = await _userService.RegisterUserAsync(registerDTO);
                    if (result.IsSuccess)
                    {
                        RegistrationDTO modelDTO = new RegistrationDTO();
                        modelDTO.EmployeeId = null;
                        modelDTO.Email = model.Email;
                        modelDTO.FirstName = model.FirstName;
                        modelDTO.LastName = model.LastName;
                        modelDTO.IsActive = true;
                        modelDTO.UserId = result.Id;
                        modelDTO.Phone = model.Phone;
                        modelDTO.Designation = model.Designation;
                        modelDTO.CreatedOn = System.DateTime.Now;
                        modelDTO.CreatedBy = _currentUserService.GetUserId();
                        Staff payload = _mapper.Map<RegistrationDTO, Staff>(modelDTO);
                        await _uow.EmployeeRepositories.CreateStaffAsync(payload);
                        CreateAddressDTO permanentAddressModelDTO = new CreateAddressDTO();
                        permanentAddressModelDTO.Address = model.PermanentAddress;
                        permanentAddressModelDTO.City = model.PermanentCity;
                        permanentAddressModelDTO.State = model.PermanentState;
                        permanentAddressModelDTO.Country = model.PermanentCountry;
                        permanentAddressModelDTO.ZipCode = model.PermanentZipCode;
                        CreateAddressDTO correspondenceAddressModelDTO = new CreateAddressDTO();
                        correspondenceAddressModelDTO.Address = model.CorrespondenceAddress;
                        correspondenceAddressModelDTO.City = model.CorrespondenceCity;
                        correspondenceAddressModelDTO.State = model.CorrespondenceState;
                        correspondenceAddressModelDTO.Country = model.CorrespondenceCountry;
                        correspondenceAddressModelDTO.ZipCode = model.CorrespondenceZipCode;
                        var result1 = await _uow.SaveAsync1();
                        if (result1.Equals(1))
                        {
                            return Ok(result);//status code 200
                        }
                        else
                        {
                            return BadRequest("Unable to create Staff");
                        }
                }
                return BadRequest("Some Properties are not valid"); //status Code 400
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginUserAsync([FromBody] LoginViewDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(model);
                if (result.IsSuccess)
                    return Ok(result);//status code 200
                return BadRequest(result);
            }
            return BadRequest("Some Properties are not valid"); //status Code 400
        }
        //[Authorize(Policy = "Admin")]
        [Route("DeleteUser")]
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string userName)
        {
            var deletedBy = _currentUserService.GetUserId();
            var resultUser=await _userService.DeleteUser(userName,deletedBy);
            if (resultUser.Equals(1))
            {
                var updated = _uow.EmployeeRepositories.DeleteStaff(userName, deletedBy);
                var result = await _uow.SaveAsync1();
                if (result.Equals(1))
                {
                    return Ok(result);//status code 200
                }
                else
                {
                    return BadRequest("User can not be deleted");
                }
            }
            else
            {
                return BadRequest("User Doesn't Exist");
            }
        }
    }
}
