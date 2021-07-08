using System.Collections.Generic;
using FieldMgt.Core.DomainModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FieldMgt.Core.UOW;
using System.Threading.Tasks;

namespace FieldMgt.Repository.UOW
{
    public class GenericRepository<TEntity> where TEntity:class
    {
        private readonly IUnitofWork _uow;
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        private List<KeyValuePair<string, string>> criteria = new List<KeyValuePair<string, string>>();
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public void Delete(object obj)
        {
            TEntity entityToDelete = _dbSet.Find(obj);
            _dbContext.Entry(obj).State = EntityState.Deleted;
           _dbSet.Remove(entityToDelete);
        }
        public IEnumerable<TEntity> GetAll()
        {            
            return _dbSet.AsNoTracking().ToList();
        }
        public TEntity GetById(object id)
        {            
            return _dbSet.Find(id);
        }
        public async Task InsertAsync(TEntity entity)
        {
             await _dbSet.AddAsync(entity);
            
        }
        //void method
        public TEntity Update(TEntity entity)
        {            
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        public IEnumerable<TEntity> GetAllConditional(string colName,string value)
        {
           // var emp = _dbSet.Where(a => a.. == value).Single();
            //var query = _dbSet.Where( c=> c.GetType(colName) == criteria[1].Value).ToString();
            var values = _dbSet.Where(x => x.GetType().GetProperty(colName).ToString()==value);
            //criteria.Add(new KeyValuePair<string, string>(colName, value));
            //return _dbSet.Where(e => criteria.Select(c => e.GetType().GetProperty(c.Value).GetValue(e).ToString() == c.Value)
            //                                          .All(c => c == true));
            return values.AsEnumerable<TEntity>();
           // return _dbSet.Where(x => x.GetType().GetProperty(colName).GetValue(x).ToString() == value).ToList();
        }
        
    }
}
