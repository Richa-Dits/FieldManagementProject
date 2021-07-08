using System;

namespace FieldMgt.Core.DTOs.Request
{
    public class CreateLeadDTO:BaseCreateLeadModel
    { 
        public string LeadName { get; set; }  
        public string LeadContact { get; set; }    
        public string LeadDescription { get; set; }       
        public int LeadSource { get; set; }
        public int LeadStatus { get; set; }
        public int Gender { get; set; }
        public string PermaAddress1 { get; set; }
        public string PermaAddress2 { get; set; }
        public string CoresAddress1 { get; set; }
        public string CoresAddress2 { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }    
        public int PermaCity { get; set; }
        public int PermaCountry { get; set; }    
        public int CoresCity { get; set; }
        public int CoresCountry { get; set; } 
        public int LeadStage { get; set; }
        public bool IsActive { get; set; }     
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class BaseCreateLeadModel
    {
        public int? LeadId { get; set; }
    }

}
