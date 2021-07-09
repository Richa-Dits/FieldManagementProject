using FieldMgt.Core.DomainModels;
using FieldMgt.Core.DTOs.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FieldMgt.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task CreateStaffAsync(Staff model);
        IEnumerable<Staff> GetStaffs();
        Staff GetStaffbyID(int id);
        UserManagerReponse DeleteStaff(string userName, string deletedBy);
        Staff UpdateStaffn(Staff model);
    }
}
