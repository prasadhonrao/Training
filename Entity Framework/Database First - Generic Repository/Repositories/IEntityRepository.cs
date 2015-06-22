using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___Generic_Repository.Repositories
{
    interface IEntityRepository<T> : IDisposable
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(string id);
        void InsertOrUpdate(T entity);
        void Delete(string id);
        void Save();
 
    }
}
