using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class LeadContact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeadContactID { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(14)")]
        public string Phone { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }
        public int Gender { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string PermaAddress1 { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PermaAddress2 { get; set; }
        public int PermaCity { get; set; }
        public int PermaCountry { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string CoresAddress1 { get; set; }
        [Column(TypeName = "varchar(80)")]
        public string CoresAddress2 { get; set; }
        public int CoresCity { get; set; }
        public int CoresCountry { get; set; }
        public int LeadId { get; set; }
        [ForeignKey("LeadId")]
        public Lead Lead { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public Reference RefPCity { get; set; }
        public Reference RefPCountry { get; set; }
        public Reference RefCCity { get; set; }
        public Reference RefCCountry { get; set; }
        public Reference RefGender { get; set; }
        public ApplicationUser LeadContactCreatedBy { get; set; }
        public ApplicationUser LeadContactModifiedBy { get; set; }
        public ApplicationUser LeadContactDeletedBy { get; set; }
    }
}
