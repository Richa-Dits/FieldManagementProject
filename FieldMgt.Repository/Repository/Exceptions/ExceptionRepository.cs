using FieldMgt.Core.DomainModels;
using FieldMgt.Core.Interfaces;
using FieldMgt.Repository.UOW;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository.Exceptions
{
    public class ExceptionRepository : GenericRepository<ExceptionLog>,IExceptionInterface
    {
        private readonly ApplicationDbContext _dbcontext;
        public ExceptionRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task SaveLogs(ExceptionLog model)
        {
            await InsertAsync(model);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
