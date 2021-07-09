using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Ref1Navigation = new HashSet<Employee>();
            Ref2Navigation = new HashSet<Employee>();
            Ref3Navigation = new HashSet<Employee>();
            Ref4Navigation = new HashSet<Employee>();
            Ref5Navigation = new HashSet<Lead>();
            Ref6Navigation = new HashSet<Lead>();
            Ref7Navigation = new HashSet<Lead>();
            Ref8Navigation = new HashSet<LeadContact>();
            Ref9Navigation = new HashSet<LeadContact>();
            Ref10Navigation = new HashSet<LeadContact>();
            Ref11Navigation = new HashSet<LeadActivity>();
            Ref12Navigation = new HashSet<LeadActivity>();
            Ref13Navigation = new HashSet<LeadActivity>();
            Ref14Navigation = new HashSet<LeadCall>();
            Ref15Navigation = new HashSet<ApplicationUser>();
            Ref16Navigation = new HashSet<ApplicationUser>();
            Ref17Navigation = new HashSet<Order>();
            Ref18Navigation = new HashSet<Order>();
            Ref19Navigation = new HashSet<Order>();
            Ref20Navigation = new HashSet<Order>();
        }                    
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string DeletedBy { get; set; }
        public ApplicationUser RefDeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string CreatedBy { get; set; }
        public ApplicationUser RefCreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ICollection<Staff> Ref1Navigation { get; set; }
        public ICollection<Staff> Ref2Navigation { get; set; }
        public ICollection<Staff> Ref3Navigation { get; set; }
        public ICollection<Staff> Ref4Navigation { get; set; }
        public ICollection<Lead> Ref5Navigation { get; set; }
        public ICollection<Lead> Ref6Navigation { get; set; }
        public ICollection<Lead> Ref7Navigation { get; set; }
        public ICollection<LeadContact> Ref8Navigation { get; set; }
        public ICollection<LeadContact> Ref9Navigation { get; set; }
        public ICollection<LeadContact> Ref10Navigation { get; set; }
        public ICollection<LeadActivity> Ref11Navigation { get; set; }
        public ICollection<LeadActivity> Ref12Navigation { get; set; }
        public ICollection<LeadActivity> Ref13Navigation { get; set; }
        public ICollection<LeadCall> Ref14Navigation { get; set; }
        public ICollection<ApplicationUser> Ref15Navigation { get; set; }
        public ICollection<ApplicationUser> Ref16Navigation { get; set; }
        public ICollection<Order> Ref17Navigation { get; set; }
        public ICollection<Order> Ref18Navigation { get; set; }
        public ICollection<Order> Ref19Navigation { get; set; }
        public ICollection<Order> Ref20Navigation { get; set; }
    }
}
