using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackId { get; set; }
        [Column(TypeName = "nvarchar(255)")] 
        public string UserId { get; set; }
        
        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int LeadId { get; set; }
        [ForeignKey("LeadId")]
        public Lead Lead { get; set; }
        public ApplicationUser FeebackUserID { get; set; }
    }
}
