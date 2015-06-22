using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Database_First___Repository.Repositories
{
    public interface IProductCategoryRepository : IDisposable
    {
        IQueryable<ProductCategory> All { get; }
        IQueryable<ProductCategory> AllIncluding(params Expression<Func<ProductCategory, object>>[] includeProperties);
        ProductCategory Find(string id);
        void InsertOrUpdate(ProductCategory currency);
        void Delete(string id);
        void Save();
    }
}
