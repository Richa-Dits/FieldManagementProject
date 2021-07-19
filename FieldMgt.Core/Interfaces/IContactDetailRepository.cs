using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FieldMgt.Core.DomainModels;

namespace FieldMgt.Core.Interfaces
{
    public interface IContactDetailRepository
    {
        Task<int> SaveContactDtails(ContactDetail model);
    }
}
