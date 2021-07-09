using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{
    
    public class Reference
    {
        public Reference()
        {
            Ref1Navigation = new HashSet<Staff>();
            //Ref2Navigation = new HashSet<Employee>();
            //Ref3Navigation = new HashSet<Employee>();
            Lead1Navigation = new HashSet<Lead>();
            Lead2Navigation = new HashSet<Lead>();
            Lead3Navigation = new HashSet<Lead>();
            //Lead4Navigation = new HashSet<Lead>();
            //Lead5Navigation = new HashSet<Lead>();
            //Lead6Navigation = new HashSet<Lead>();
            //Lead7Navigation = new HashSet<Lead>();
            Lead8Navigation = new HashSet<Lead>();
            LeadContact1Navigation = new HashSet<LeadContact>();
            //LeadContact2Navigation = new HashSet<LeadContact>();
            //LeadContact3Navigation = new HashSet<LeadContact>();
            //LeadContact4Navigation = new HashSet<LeadContact>();
            //LeadContact5Navigation = new HashSet<LeadContact>();
            LeadActivity1Navigation = new HashSet<LeadActivity>();
            LeadCall1Navigation = new HashSet<LeadCall>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReferenceId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string ReferenceName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string ReferenceCategory { get; set; }        
        public ICollection<Staff> Ref1Navigation { get; set; }
        //public ICollection<Employee> Ref2Navigation { get; set; }
        //public ICollection<Employee> Ref3Navigation { get; set; }
        public ICollection<Lead> Lead1Navigation { get; set; }
        public ICollection<Lead> Lead2Navigation { get; set; }
        public ICollection<Lead> Lead3Navigation { get; set; }
        //public ICollection<Lead> Lead4Navigation { get; set; }
        //public ICollection<Lead> Lead5Navigation { get; set; }
        //public ICollection<Lead> Lead6Navigation { get; set; }
        //public ICollection<Lead> Lead7Navigation { get; set; }
        public ICollection<Lead> Lead8Navigation { get; set; }
        public ICollection<LeadContact> LeadContact1Navigation { get; set; }
        //public ICollection<LeadContact> LeadContact2Navigation { get; set; }
        //public ICollection<LeadContact> LeadContact3Navigation { get; set; }
        //public ICollection<LeadContact> LeadContact4Navigation { get; set; }
        //public ICollection<LeadContact> LeadContact5Navigation { get; set; }
        public ICollection<LeadActivity> LeadActivity1Navigation { get; set; }
        public ICollection<LeadCall> LeadCall1Navigation { get; set; }
    }
}
