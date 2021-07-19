using System.Collections.Generic;
using System.Linq;
using FieldMgt.Core.Interfaces;
using FieldMgt.Core.DomainModels;
using FieldMgt.Repository.UOW;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository
{ 
    public class LeadRepository:GenericRepository<Lead>,ILeadRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public LeadRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }        
        public async Task CreateLeadAsync(Lead model)
        {
            await InsertAsync(model);
        }
        public  IEnumerable<Lead> GetLeadsAsync()
        {
            return GetAll();
            //return  _dbContext.Leads.ToList();
        }
        public Lead GetLeadbyIdAsync(int id)
        {
            var result= _dbContext.Leads.FirstOrDefault(l =>l.LeadId == id);            
            return result;
        }
        public Lead UpdateLeadStatusAsync(Lead lead)
        {
            return Update(lead);
        }
    }
}
