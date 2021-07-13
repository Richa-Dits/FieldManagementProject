﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Maintenance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaintenanceId { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }
        [DefaultValue(true)]
        public bool? IsActive { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TotalCost { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
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
        public ApplicationUser MaintenanceCreatedBy { get; set; }
        public ApplicationUser MaintenanceModifiedBy { get; set; }
        public ApplicationUser MaintenanceDeletedBy { get; set; }
    }
}
