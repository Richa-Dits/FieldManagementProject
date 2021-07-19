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
        IVendorRepository VendorRepositories { get; }
=======
        IStaffRepository StaffRepositories { get; }
>>>>>>> fm-boilerplate
=======
        IAddressRepository AddressRepositories { get; }
        IVendorRepository VendorRepositories { get; }        
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
        Task SaveAsync();
        Task<int> SaveAsync1();
    }
}
