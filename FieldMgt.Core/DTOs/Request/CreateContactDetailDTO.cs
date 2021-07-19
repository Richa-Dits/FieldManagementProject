using System;
<<<<<<< HEAD
using System.ComponentModel;
=======
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
using System.ComponentModel.DataAnnotations;

namespace FieldMgt.Core.DTOs.Request
{
<<<<<<< HEAD
    public class CreateContactDetailDTO:BaseContactModel
=======
    public class CreateContactDetailDTO
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
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
<<<<<<< HEAD
        [DefaultValue(true)]
=======
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
<<<<<<< HEAD
    public class BaseContactModel
    {
        public int? ContactDetailId { get; set; }
    }
=======
>>>>>>> ef4520a6e7dfe0f38542af7a7fb72274d25103b1
}
