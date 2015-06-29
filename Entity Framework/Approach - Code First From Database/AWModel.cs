namespace Approach___Code_First_From_Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AWModel : DbContext
    {
        public AWModel()
            : base("name=AWModel")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<vSalesPerson> vSalesPersons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<vSalesPerson>()
                .Property(e => e.SalesQuota)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPerson>()
                .Property(e => e.SalesYTD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vSalesPerson>()
                .Property(e => e.SalesLastYear)
                .HasPrecision(19, 4);
        }
    }
}
