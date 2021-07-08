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
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(14)")]
        public string Phone { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string Address { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        [Column(TypeName = "varchar(5)")]
        [MaxLength(5)]
        public string ZipCode { get; set; }
        public int Designation { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string UserId { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public Reference EmpCity { get; set; }
        public Reference EmpCountry { get; set; }
        public Reference EmpDesignation { get; set; }
        public ApplicationUser EmpUserID { get; set; }
        public ApplicationUser EmpCreatedBy { get; set; }
        public ApplicationUser EmpModifiedBy { get; set; }
        public ApplicationUser EmpDeletedBy { get; set; }
    }    
}
