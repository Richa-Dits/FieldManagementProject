using System.Collections.Generic;
using System.Linq;
using FieldMgt.Core.Interfaces;
using FieldMgt.Core.DomainModels;
using FieldMgt.Repository.UOW;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository
{
    public class ContactDetailRepository : GenericRepository<ContactDetail>, IContactDetailRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public ContactDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
        public Task<int> SaveContactDtails(ContactDetail addressDetail)
        {
            var result = InsertAsync(addressDetail);
            return Task.FromResult(result.Id);
        }
    }
}
