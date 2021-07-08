using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }                   
        public int Designation { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string UserId { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public Reference EmpDesignation { get; set; }
        public ApplicationUser EmpUserID { get; set; }
        public ApplicationUser EmpCreatedBy { get; set; }
        public ApplicationUser EmpModifiedBy { get; set; }
        public ApplicationUser EmpDeletedBy { get; set; }
    }    
}
