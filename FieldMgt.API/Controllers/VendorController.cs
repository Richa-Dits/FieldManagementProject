using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FieldMgt.Core.DomainModels;
using FieldMgt.Core.UOW;
using AutoMapper;
using FieldMgt.API.Infrastructure.Services;
using System.Threading.Tasks;
using FieldMgt.Core.DTOs.Request;

namespace FieldMgt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IUnitofWork _uow;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        public VendorController(IUnitofWork uow, IMapper mapper, ICurrentUserService currentUserService)
        {
            _uow = uow;
            _mapper = mapper;
            _currentUserService = currentUserService;
        }
        [Route("~/api/Vendor/Create")]
        [HttpPost]
        public async Task<IActionResult> CreateVendorAsync(CreateVendorDTO model)
        {
            CreateVendorDTO modelDTO = new CreateVendorDTO();
            modelDTO.VendorCompanyName = model.VendorCompanyName;
            modelDTO.VendorOwnerorMD = model.VendorOwnerorMD;
            modelDTO.VendorContactPersonName = model.VendorContactPersonName;
            modelDTO.VendorGSTNumber = model.VendorGSTNumber;
            modelDTO.VendorAccountNumber = model.VendorAccountNumber;
            modelDTO.IsActive = true;
            modelDTO.CreatedBy = _currentUserService.GetUserId();
            modelDTO.CreatedOn = System.DateTime.Now;
            modelDTO.VendorIFSCCode = model.VendorIFSCCode;
            modelDTO.VendorBankName = model.VendorBankName;
            modelDTO.VendorBankBranch = model.VendorBankBranch;
            modelDTO.PermanentAddressId = model.PermanentAddressId;
            modelDTO.BillingAddressId = model.BillingAddressId;
            modelDTO.ContactDetailId = model.ContactDetailId;
            Vendor response = _mapper.Map<CreateVendorDTO, Vendor>(modelDTO);
            await _uow.VendorRepositories.CreateVendorAsync(response);
            var result = await _uow.SaveAsync1();
            if (result.Equals(1))
            {
                return Ok(result);//status code 200
            }
            else
            {
                return BadRequest("Vendor can not be created");
            }
        }
        [Route("~/api/Vendor/GetList")]
        [HttpGet]
        public IEnumerable<Vendor> GetVendorAsync()
        {
            return _uow.VendorRepositories.GetVendorsAsync();
        }
        [Route("~/api/Vendor/ById{id}")]
        [HttpGet]
        public IActionResult GetVendorByIdAsync(int id)
        {
            var result = _uow.VendorRepositories.GetVendorbyIdAsync(id);
            if (result == null)
            {
                return BadRequest("Lead Contact doesnt exist");
            }
            return Ok(result);//status code 200
        }
        [Route("~/api/Vendor/Update")]
        [HttpPatch]
        public Vendor UpdateVendorStatusAsync(Vendor lead)
        {
            var updatedLead = _uow.VendorRepositories.UpdateVendorStatusAsync(lead);
            _uow.SaveAsync();
            return updatedLead;
        }
    }
}
