using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FieldMgt.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task CreateStaffAsync(Staff model);
        IEnumerable<Staff> GetStaff();
        Staff GetStaffbyId(int id);
        UserManagerReponse DeleteStaff(string userName, string deletedBy);
        Staff UpdateStaffAsync(Staff model);
    }
}
