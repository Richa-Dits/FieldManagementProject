using System;
using System.ComponentModel.DataAnnotations;

namespace FieldMgt.Core.DTOs.Request
{
    public class CreateContactDetailDTO
    {
        [Phone(ErrorMessage = "Please Enter valid Phone Number")]
        public string PrimaryPhone { get; set; }
        [Phone(ErrorMessage = "Please Enter valid Phone Number")]
        public string AlternatePhone { get; set; }
        [StringLength(100, MinimumLength = 8)]
        [EmailAddress(ErrorMessage = "Please Enter valid Email Address")]
        public string PrimaryEmail { get; set; }
        [StringLength(100, MinimumLength = 8)]
        [EmailAddress(ErrorMessage = "Please Enter valid Email Address")]
        public string AlternateEmail { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
