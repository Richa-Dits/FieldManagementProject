﻿using AutoMapper;
using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Request;

namespace FieldMgt
{
    public class CreateServiceMap : Profile
    {
        public CreateServiceMap()
        {
            CreateMap<CreateLeadDTO, Lead>().ReverseMap();
            CreateMap<CreateLeadContactDTO, LeadContact>().ReverseMap();
            CreateMap<RegistrationDTO, Staff>().ReverseMap();
        }
    }
}
