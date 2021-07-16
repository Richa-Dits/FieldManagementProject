using System.Collections.Generic;
using System.Linq;
using FieldMgt.Core.Interfaces;
using FieldMgt.Core.DomainModels;
using FieldMgt.Repository.UOW;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository
{
    public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public VendorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task CreateVendorAsync(Vendor model)
        {
            await InsertAsync(model);
        }
        public IEnumerable<Vendor> GetVendorsAsync()
        {
            return GetAll();
        }
        public Vendor GetVendorbyIdAsync(int id)
        {
            var result = _dbcontext.Vendors.FirstOrDefault(l => l.VendorId == id);
            return result;
        }
        public Vendor UpdateVendorStatusAsync(Vendor lead)
        {
            return Update(lead);
        }
    }
}
