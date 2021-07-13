using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Lead
    {
        public Lead()
        {
            //Ref1LeadId = new HashSet<LeadActivity>();
            Ref2LeadId = new HashSet<LeadCall>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LeadId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string LeadCompanyName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string LeadDescription { get; set; }        
        public int LeadSource { get; set; }  
        public int LeadStatus { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        public int? LeadStage { get; set; }
        [DefaultValue(true)]
        public bool? IsActive { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Proposal { get; set; }
        public int NotesId { get; set; }
        public Notes Notes { get; set; }
        public int ContactDetailId { get; set; }
        [ForeignKey("ContactDetailId")]
        public ContactDetail ContactDetail { get; set; }
        public int PermanentAddressId { get; set; }
        public int BillingAddressId { get; set; }
        
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string DeletedBy { get; set; }
        [DefaultValue(false)]
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public Reference RefStatus { get; set; }
        //public Reference RefPCity { get; set; }
        //public Reference RefPCountry { get; set; }
        public Reference RefGender { get; set; }
        public Reference RefSource { get; set; }
        public Reference RefStage { get; set; }
        public ApplicationUser LeadCreatedBy { get; set; }
        public ApplicationUser LeadModifiedBy { get; set; }
        public ApplicationUser LeadDeletedBy { get; set; }
        public AddressDetail LeadAddress { get; set; }
        public AddressDetail LeadBillingAddress { get; set; }
        //public ICollection<LeadActivity> Ref1LeadId { get; set; }
        public ICollection<LeadCall> Ref2LeadId { get; set; }
    }
}
