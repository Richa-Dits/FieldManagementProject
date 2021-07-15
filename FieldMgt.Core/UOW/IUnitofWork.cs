using System.Threading.Tasks;
using FieldMgt.Core.Interfaces;


namespace FieldMgt.Core.UOW
{

    public interface IUnitofWork
    {
        ILeadRepository LeadServices { get; }
        IUserRepository USerServices { get; }
        IRoleRepository RoleServices { get; }
        ILeadContactRepository LeadContactRepositories { get; }
        IStaffRepository EmployeeRepositories { get; }
        Task SaveAsync();
        Task<int> SaveAsync1();
    }
}
