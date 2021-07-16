using System;
using System.Collections.Generic;
using System.Text;

namespace FieldMgt.Core.DomainModels
{
    public class ExceptionModel
    {
        public string Browser { get; set; }
        public string UserId { get; set; }
        public string ErrorCode { get; set; }
        public string ExceptionId { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
    }
}
