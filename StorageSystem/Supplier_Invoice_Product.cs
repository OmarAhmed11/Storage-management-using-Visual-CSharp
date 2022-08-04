using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem
{
    class Supplier_Invoice_Product
    {
       
        [Key]
        [Column(Order = 1)]
        [ForeignKey("supplier_invoice")]
        public int Supplier_Invoice_Id { get; set; }
        public virtual Supplier_Invoice supplier_invoice { get; set; }


        [Key]
        [Column(Order = 2)]
        [ForeignKey("product")]
        public int Product_Id { get; set; }
        public virtual Product product { get; set; }

        public int Quantity { get; set; }
    }
}
