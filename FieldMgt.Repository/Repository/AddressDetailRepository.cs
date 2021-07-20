using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Request;
using FieldMgt.Core.DTOs.Response;
using FieldMgt.Core.Interfaces;
using FieldMgt.Repository.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository
{
    public class AddressDetailRepository : GenericRepository<AddressDetail>, IAddressDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AddressDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<AddressDetail> SaveAddress(CreateAddressDTO model)
        {
            var response= await SingleAsync<AddressDetail>("sp_SaveVendorDetail", model);
            return response;
        }
        public AddressDetail DeleteAddress(int addressId, string deletedBy)
        {
            try
            {
                var address = _dbContext.AddressDetails.Where(a => a.AddressDetailId == addressId).Single();
                if (!(address == null || address.IsDeleted == true))
                {
                    address.IsDeleted = true;
                    address.DeletedBy = deletedBy;
                    address.DeletedOn = System.DateTime.Now;
                    var address1 = Update(address);
                    return address;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
