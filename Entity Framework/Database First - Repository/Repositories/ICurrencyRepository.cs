using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Database_First___Repository.Repositories
{
    public interface ICurrencyRepository : IDisposable
    {
        IQueryable<Currency> All {get;}
        IQueryable<Currency> AllIncluding(params Expression<Func<Currency, object>>[] includeProperties);
        Currency Find(string id);
        void InsertOrUpdate(Currency currency);
        void Delete(string id);
        void Save();
    }
}
