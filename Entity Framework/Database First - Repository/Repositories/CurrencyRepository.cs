using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___Repository.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        AWEntities context = new AWEntities();

        public IQueryable<Currency> All
        {
            get { return context.Currencies; }
        }

        public IQueryable<Currency> AllIncluding(params System.Linq.Expressions.Expression<Func<Currency, object>>[] includeProperties)
        {
            IQueryable<Currency> query = context.Currencies;
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }
            return query;
        }

        public Currency Find(string id)
        {
            return context.Currencies.Find(id);
        }

        public void InsertOrUpdate(Currency currency)
        {
            if (currency.CurrencyCode == default(string))
            {
                // new
                context.Currencies.Add(currency);
            }
            else
            {
                context.Entry<Currency>(currency).State = EntityState.Modified;
            }
        }

        public void Delete(string id)
        {
            var currency = context.Currencies.Find(id);
            context.Currencies.Remove(currency);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
