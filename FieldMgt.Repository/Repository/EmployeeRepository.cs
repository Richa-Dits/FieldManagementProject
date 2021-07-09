using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Response;
using FieldMgt.Core.Interfaces;
using FieldMgt.Repository.UOW;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository
{
    public class StaffRepository: GenericRepository<Staff>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        //private readonly IUnitofWork _uow;
        public StaffRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateStaffAsync(Staff model)
        {
             await InsertAsync(model);
        }
        public Staff GetStaffbyID(int id)
        {
            return GetById(id);
        }
        public IEnumerable<Staff> GetStaffs()
        {
            var emp = _dbContext.Staff.Where(a => a.IsDeleted == true).ToList();
            return emp;
        }
        public UserManagerReponse DeleteStaff(string userName, string deletedBy)
        {
            var emp = _dbContext.Staff.FirstOrDefault();
            //commented to create the db
            //var emp = _dbContext.Staff.Where(a => a.Email == userName).Single();
            if(!(emp==null|| emp.IsDeleted==true))
            {
                emp.IsDeleted = true;
                emp.DeletedBy =deletedBy;
                emp.DeletedOn = System.DateTime.Now;
                var emp1= Update(emp);              
                return new UserManagerReponse
                {
                    Message = "Staff has been deleted"
                };
            }
            return new UserManagerReponse 
            { 
                Message ="Staff Not Found"
            };
        }
        public Staff UpdateStaffn(Staff model)
        {
            return Update(model);
        }
    }
}
