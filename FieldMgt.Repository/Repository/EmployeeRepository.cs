using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Response;
using FieldMgt.Core.Interfaces;
using FieldMgt.Repository.UOW;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FieldMgt.Repository.Repository
{
    public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        //private readonly IUnitofWork _uow;
        public EmployeeRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateEmployeeAsync(Employee model)
        {
             await InsertAsync(model);
        }
        public Employee GetEmployeebyID(int id)
        {
            return GetById(id);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            var emp = _dbContext.Employee.Where(a => a.IsDeleted == true).ToList();
            return emp;
        }
        public UserManagerReponse DeleteEmployee(string userName, string deletedBy)
        {
            var emp = _dbContext.Employee.Where(a => a.Email == userName).Single();
            if(!(emp==null|| emp.IsDeleted==true))
            {
                emp.IsDeleted = true;
                emp.DeletedBy =deletedBy;
                emp.DeletedOn = System.DateTime.Now;
                var emp1= Update(emp);              
                return new UserManagerReponse
                {
                    Message = "Employee has been deleted"
                };
            }
            return new UserManagerReponse 
            { 
                Message ="Employee Not Found"
            };
        }
        public Employee UpdateEmployeen(Employee model)
        {
            return Update(model);
        }
    }
}
