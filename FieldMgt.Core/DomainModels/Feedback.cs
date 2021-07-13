﻿using System;
using System.ComponentModel;
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
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        [DefaultValue(true)]
        public bool? IsActive { get; set; }
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
        public int LeadId { get; set; }
        [ForeignKey("LeadId")]
        public Lead Lead { get; set; }
        public ApplicationUser FeedBackCreatedBy { get; set; }
        public ApplicationUser FeedBackModifiedBy { get; set; }
        public ApplicationUser FeedBackDeletedBy { get; set; }
    }
}
