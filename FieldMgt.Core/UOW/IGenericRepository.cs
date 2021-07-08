using System;
using System.Collections.Generic;

namespace FieldMgt.Core.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(Object obj);
        IEnumerable<TEntity> GetAllConditional(string colName, string value);
    }
}
