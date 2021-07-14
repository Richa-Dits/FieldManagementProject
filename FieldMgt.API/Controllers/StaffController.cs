﻿using AutoMapper;
using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs;
using FieldMgt.Core.UOW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldMgt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IUnitofWork _uow;
        private readonly IMapper _mapper;
        public StaffController(IUnitofWork uow,IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        
        [Route("~/api/Staff/List")]
        [HttpGet]
        public IEnumerable<Staff> GetStaff()
        {
            return  _uow.EmployeeRepositories.GetStaff();
        }
        [Route("~/api/Staff/ById/{id}")]
        [HttpGet]
        public IActionResult GetStaffbyId(int id)
        {
            var result = _uow.EmployeeRepositories.GetStaffbyId(id);
            if (result == null)
            {
                return BadRequest("Staff Member doesnt exist");
            }
            return Ok(result);//status code 200
        }    
        [Route("~/api/Staff/Update")]
        [HttpPatch]
        public async Task<IActionResult> UpdateStaffAsync(Staff model)
        {
            var updated= _uow.EmployeeRepositories.UpdateStaffAsync(model);
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
    }
}
