using AutoMapper;
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
<<<<<<< HEAD
<<<<<<< HEAD
            CreateMap<CreateVendorDTO, Vendor>().ReverseMap();
=======
            CreateMap<CreateAddressDTO, AddressDetail>().ReverseMap();
            CreateMap<CreateContactDetailDTO, ContactDetail>().ReverseMap();
>>>>>>> fm-boilerplate
=======
            CreateMap<CreateAddressDTO, AddressDetail>().ReverseMap();
            CreateMap<CreateVendorDTO, Vendor>().ReverseMap();
            CreateMap<CreateContactDetailDTO, ContactDetail>().ReverseMap();
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
        }
    }
}
