using System;
using System.ComponentModel.DataAnnotations;

namespace FieldMgt.Core.DTOs.Request
{
    public class CreateEmployeeDTO:BaseEmployeeModel
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Password { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string ConfirmPassword { get; set; }
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
    public class BaseEmployeeModel
    {
        public int? EmployeeId { get; set; }
    }
}
