using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First___Generic_Repository.Repositories
{
    public class ProductCategoryRepository : IEntityRepository<ProductCategory>
    {
        AWEntities context = new AWEntities();

        public IQueryable<ProductCategory> All
        {
            get { return context.ProductCategories; }
        }

        public IQueryable<ProductCategory> AllIncluding(params System.Linq.Expressions.Expression<Func<ProductCategory, object>>[] includeProperties)
        {
            IQueryable<ProductCategory> query = context.ProductCategories;
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }
            return query;
        }

        public ProductCategory Find(string id)
        {
            return context.ProductCategories.Find(id);
        }

        public void InsertOrUpdate(ProductCategory productCategory)
        {
            if (productCategory.ProductCategoryID == default(int))
            {
                // new
                context.ProductCategories.Add(productCategory);
            }
            else
            {
                context.Entry<ProductCategory>(productCategory).State = EntityState.Modified;
            }
        }

        public void Delete(string id)
        {
            var productCategory = context.ProductCategories.Find(id);
            context.ProductCategories.Remove(productCategory);
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
