﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FieldMgt.Core.DomainModels;
using FieldMgt.Core.UOW;
using AutoMapper;
using FieldMgt.API.Infrastructure.Services;
using System.Threading.Tasks;
using FieldMgt.Core.DTOs.Request;
using FieldMgt.Core.Interfaces;
using System;

namespace FieldMgt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IUnitofWork _uow;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        private readonly IAddressDetailRepository _addressRepository1;
        private readonly IContactDetailRepository _contactRepository;
        public VendorController(IUnitofWork uow, IMapper mapper, ICurrentUserService currentUserService, IAddressDetailRepository addressRepository, IContactDetailRepository contactRepository)
        {
            _uow = uow;
            _mapper = mapper;
            _currentUserService = currentUserService;
            _addressRepository1 = addressRepository;
            _contactRepository = contactRepository;
        }
        [Route("~/api/Vendor/Create")]
        [HttpPost]
        public async Task<IActionResult> CreateVendorAsync([FromBody] CreateVendorDTO model)
        {
            try {
                CreateAddressDTO addressDTO = new CreateAddressDTO();
                addressDTO.Address = model.PermanentAddress;
                addressDTO.CityId = model.PermanentCity;
                addressDTO.StateId = model.PermanentState;
                addressDTO.CountryId
                    = model.PermanentCountry;
                addressDTO.AddressType = model.AddressType;
                addressDTO.ZipCode = model.ZipCode;
                AddressDetail addressDetail = _mapper.Map<CreateAddressDTO, AddressDetail>(addressDTO);
                var resp=_uow.AddressRepositories.SaveAddress(addressDetail);
                var result = await _uow.SaveAsync1();
                if (result != 0)
                {
                    CreateContactDetailDTO contactDetailDTO = new CreateContactDetailDTO();
                    contactDetailDTO.PrimaryPhone = model.PrimaryPhone;
                    contactDetailDTO.AlternatePhone = model.AlternatePhone;
                    contactDetailDTO.PrimaryEmail = model.PrimaryEmail;
                    contactDetailDTO.AlternatePhone = model.AlternatePhone;
                    contactDetailDTO.CreatedBy= _currentUserService.GetUserId();
                    contactDetailDTO.CreatedOn= System.DateTime.Now;
                    ContactDetail contactDetail = _mapper.Map<CreateContactDetailDTO, ContactDetail>(contactDetailDTO);
                    var response = _contactRepository.SaveContactDetails(contactDetail);
                    if (response != null)
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
                        modelDTO.PermanentAddressId = response.Id;
                        modelDTO.BillingAddressId = response.Id;
                        //modelDTO.ContactDetailId = result.Id;
                        Vendor vendor = _mapper.Map<CreateVendorDTO, Vendor>(modelDTO);
                        await _uow.VendorRepositories.CreateVendorAsync(vendor);
                        await _uow.SaveAsync();                        
                    }
                }
                return BadRequest("Some Properties are not valid"); //status Code 400
            }
            catch (Exception ex)
            {
                throw ex;
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
