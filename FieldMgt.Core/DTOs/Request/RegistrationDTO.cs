using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FieldMgt.Core.DTOs.Request
{
    public class RegistrationDTO:BaseRegistration
    {
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }
        [StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }        
        public bool IsActive { get; set; }
        public string UserId { get; set; }
        [Phone]
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

