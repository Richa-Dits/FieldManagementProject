using System;
using System.Collections.Generic;
using System.Text;
using FieldMgt.Core.DomainModels;
using FieldMgt.Core.Interfaces;
using FieldMgt.Core.UOW;
using FieldMgt.Repository.Repository;
using FieldMgt.Repository.UOW;
using Moq;
using Xunit;

namespace FieldMgtTest.AddressTest
{
    public class AddressRepositoryTest
    {
        private readonly IUnitofWork _mockUOW;
        //protected readonly AddressDetailRepository addressDetailService;
        public AddressRepositoryTest(IUnitofWork mockUOW)
        {
            _mockUOW = mockUOW;
        }
        [Fact]
        public void DeleteAddressfact_ShouldDeleteStaffMember()
        {

            var address = _mockUOW.AddressRepositories.DeleteAddress(22, "Hello");
            _mockUOW.SaveAsync1();
            Assert.Equal(true, address.IsDeleted);
            //Assert.Equal(user, address.DeletedBy);

        }
        [Theory]
        [InlineData(22,"Hello")]
        public void DeleteAddress_ShouldDeleteStaffMember(int id, string user)
        {
        
            var address=_mockUOW.AddressRepositories.DeleteAddress(id, user);
            _mockUOW.SaveAsync1();          
            Assert.Equal(true, address.IsDeleted);
            //Assert.Equal(user, address.DeletedBy);          
        }
        [Fact]
        public void GetStaff_ShouldGetAllStaff()
        {
            IEnumerable<Staff> result = _mockUOW.StaffRepositories.GetStaff();
            Assert.IsAssignableFrom<IEnumerable<Staff>>(result);
        }
        [Theory]
        [InlineData(22, "Hello")]
        public void Delete_ShouldDeleteStaffMember(int id, string user)
        {

            var address = _mockUOW.AddressRepositories.DeleteAddress(id, user);
            _mockUOW.SaveAsync1();
            Assert.Equal(true, address.IsDeleted);
            //Assert.Equal(user, address.DeletedBy);          
        }
    }
}
