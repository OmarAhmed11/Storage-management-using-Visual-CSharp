using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem
{
    class Context : DbContext
    {
        public Context() : base(@"Data Source=DESKTOP-O7GDQ3B\OMAR;Initial Catalog=StorageSystem;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework")
        {

        }
        public virtual DbSet<Category> category { get; set; }
        public virtual DbSet<Product> product { get; set; }
        public virtual DbSet<Storage> storage { get; set; }
        public virtual DbSet<ProductStorage> productstorage { get; set; }
        public virtual DbSet<Customer> customer { get; set; }
        public virtual DbSet<Customer_Invoice> customer_invoice { get; set; }
        public virtual DbSet<Customer_Invoice_Product> customer_invoice_product { get; set; }
        public virtual DbSet<Supplier> supplier { get; set; }
        public virtual DbSet<Supplier_Invoice> supplier_invoice { get; set; }
        public virtual DbSet<Supplier_Invoice_Product> supplier_invoice_product { get; set; }
    }
}
