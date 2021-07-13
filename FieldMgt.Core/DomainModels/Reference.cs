using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldMgt.Core.DomainModels
{   
    public class Reference
    {
        public Reference()
        {
            Staff1Navigation = new HashSet<Staff>();
            Lead1Navigation = new HashSet<Lead>();
            Lead2Navigation = new HashSet<Lead>();
            Lead3Navigation = new HashSet<Lead>();
            Lead8Navigation = new HashSet<Lead>();
            LeadContact1Navigation = new HashSet<LeadContact>();
            //LeadActivity1Navigation = new HashSet<LeadActivity>();
            LeadCall1Navigation = new HashSet<LeadCall>();
            OPStatus = new HashSet<Order>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReferenceId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ReferenceName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ReferenceCategory { get; set; }        
        public ICollection<Staff> Staff1Navigation { get; set; }
        public ICollection<Lead> Lead1Navigation { get; set; }
        public ICollection<Lead> Lead2Navigation { get; set; }
        public ICollection<Lead> Lead3Navigation { get; set; }
        public ICollection<Lead> Lead8Navigation { get; set; }
        public ICollection<LeadContact> LeadContact1Navigation { get; set; }
        //public ICollection<LeadActivity> LeadActivity1Navigation { get; set; }
        public ICollection<LeadCall> LeadCall1Navigation { get; set; }
        public ICollection<Order> OPStatus { get; set; }
    }
}
