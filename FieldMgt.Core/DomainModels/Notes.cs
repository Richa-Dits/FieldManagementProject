﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class Notes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoteId { get; set; }
        //make foreign key with global codes
        public int NotesTypeId { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string NoteDescription { get; set; }
        public int NoteTypeId { get; set; }
        [DefaultValue(true)]
        public bool? IsActive { get; set; }
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
        public ApplicationUser NotesCreatedBy { get; set; }
        public ApplicationUser NotesModifiedBy { get; set; }
        public ApplicationUser NotesDeletedBy { get; set; }

    }
}
