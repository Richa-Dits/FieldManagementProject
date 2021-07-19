using FieldMgt.Core.Interfaces;
using System;
using System.Threading.Tasks;
using FieldMgt.Core.DomainModels;
using FieldMgt.Repository.Repository;
using FieldMgt.Core.UOW;

namespace FieldMgt.Repository.UOW
{

    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _dbcontext;        
        public UnitofWork(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
            LeadServices = new LeadRepository(_dbcontext);
            LeadContactRepositories = new LeadContactRepository(_dbcontext);
<<<<<<< HEAD
            EmployeeRepositories = new StaffRepository(_dbcontext);
            VendorRepositories = new VendorRepository(_dbcontext);
<<<<<<< HEAD
=======
            StaffRepositories = new StaffRepository(_dbcontext);
>>>>>>> fm-boilerplate
=======
            AddressRepositories = new AddressRepository(_dbcontext);
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
        }
        public ILeadRepository LeadServices { get; }
        public IUserRepository USerServices { get; }
        public IRoleRepository RoleServices { get; }
        public ILeadContactRepository LeadContactRepositories { get; }
<<<<<<< HEAD
        public IStaffRepository  EmployeeRepositories { get; }
<<<<<<< HEAD
        public IVendorRepository VendorRepositories { get; }
=======
        public IStaffRepository  StaffRepositories { get; }
>>>>>>> fm-boilerplate
=======
        public IAddressRepository AddressRepositories { get; }
        public IVendorRepository VendorRepositories { get; }        
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
        public async Task SaveAsync()
        {
            using (_dbcontext.Database.BeginTransaction())
            {
                try
                {
                    await _dbcontext.SaveChangesAsync();
                    _dbcontext.Database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    _dbcontext.Database.RollbackTransaction();
                    throw new Exception(ex.Message);
                }
            }
        }
        public async Task<int> SaveAsync1()
        {
            using (_dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var result = await _dbcontext.SaveChangesAsync();
                    _dbcontext.Database.CommitTransaction();
                    return result;
                }
                catch (Exception ex)
                {
                    _dbcontext.Database.RollbackTransaction();
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
