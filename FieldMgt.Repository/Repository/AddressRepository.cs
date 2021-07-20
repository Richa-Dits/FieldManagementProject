//using FieldMgt.Core.DomainModels;
//using FieldMgt.Core.DTOs.Response;
//using FieldMgt.Core.Interfaces;
//using FieldMgt.Repository.UOW;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace FieldMgt.Repository.Repository
//{
//    public class AddressRepository : GenericRepository<AddressDetail>, IAddressRepository
//    {
//        private readonly ApplicationDbContext _dbcontext;
//        public AddressRepository(ApplicationDbContext dbContext) : base(dbContext)
//        {
//            _dbcontext = dbContext;
//        }
//        public Task<int> SaveAddress(AddressDetail model)
//        {
//            //var result= InsertAsync(addressDetail);
//            //return result;
//            //if (model == null)
//            //{
//            //    throw new NullReferenceException("Register Model is Empty");
//            //}
//            //if (model.Password != model.ConfirmPassword)
//            //    return new UserManagerReponse
//            //    {
//            //        Message = "Confirm Password doesn't match Password",
//            //        IsSuccess = false
//            //    };
//            //var identityUser = new ApplicationUser
//            //{
//            //    Email = model.Email,
//            //    UserName = model.Email,
//            //    CreatedBy = model.CreatedBy,
//            //    CreatedOn = model.CreatedOn,
//            //    IsActive = true,
//            //    IsDeleted = false
//            //};
//            //var result = await _userManager.CreateAsync(identityUser, model.Password);
//            var result = InsertAsync(model);
//            //if (result.Id)
//            //{
//            return Task.FromResult(result.Id);
//            //}
//            //else
//            //{
//            //    return new AddressResponseDTO
//            //    {
//            //    };
//            //}
//        }
//    }
//}
