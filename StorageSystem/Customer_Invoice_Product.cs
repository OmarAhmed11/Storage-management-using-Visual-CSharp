using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem
{
    class Customer_Invoice_Product
    {

        [Key]
        [Column(Order = 1)]
        [ForeignKey("customer_invoice")]
        public int Customer_Invoice_Id { get; set; }
        public virtual Customer_Invoice customer_invoice { get; set; }


        [Key]
        [Column(Order = 2)]
        [ForeignKey("product")]
        public int Product_Id { get; set; }
        public virtual Product product { get; set; }
        public int Quantity { set; get; }

    }
}
