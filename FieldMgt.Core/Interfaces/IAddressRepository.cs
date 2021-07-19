using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FieldMgt.Core.Interfaces
{
    public interface IAddressRepository
    {
        Task<int> SaveAddress(AddressDetail model);
        //Task SaveContactDetals(ContactDetail model);
    }
}
