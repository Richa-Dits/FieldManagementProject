using FieldMgt.Core.DomainModels;
using FieldMgt.Core.Interfaces;
using FieldMgt.Repository.UOW;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository.Exception
{
    public class ExceptionRepository : GenericRepository<ExceptionModel>,IExceptionInterface
    {
        private readonly ApplicationDbContext _dbcontext;
        public ExceptionRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task SaveLogs(ExceptionModel model)
        {
            await InsertAsync(model);
        }
    }
}
