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
        public void DeleteAddress_ShouldDeleteStaffMember()
        {
            //Arrange
           _mockUOW.AddressRepositories.DeleteAddress
            //Act           

            //Assert
        }
    }
}
