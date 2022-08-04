using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem
{
    class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime Production_Date { get; set; }
        public DateTime Expire_Date { get; set; }
        public int Quantity { get; set; }

        public virtual Category category { get; set; }
        public virtual List<ProductStorage> productstorage { get; set; }
        public virtual List<Customer_Invoice_Product> customer_invoice_product { get; set; }
        public virtual List<Supplier_Invoice_Product> supplier_invoice_product { get; set; }
    }
}
