using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FieldMgt.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task CreateEmployeeAsync(Employee model);
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeebyID(int id);
        UserManagerReponse DeleteEmployee(string userName, string deletedBy);
        Employee UpdateEmployeen(Employee model);
    }
}
