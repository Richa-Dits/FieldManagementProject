using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FieldMgt.Core.DTOs.Request
{
    public class RegistrationDTO:BaseRegistration
    {       
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public string ZipCode { get; set; }
        public int Status { get; set; }
        public string UserId { get; set; }
        public string Phone { get; set; }
        public int Designation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class BaseRegistration
    {
        public int? EmployeeId { get; set; }
    }
}

