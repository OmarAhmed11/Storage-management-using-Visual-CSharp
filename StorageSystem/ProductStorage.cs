using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem
{
    class ProductStorage
    {
        [Key, ForeignKey("product")]
        [Column(Order = 1)]
        public int Product_Id { set; get; }
        [Key, ForeignKey("storage")]
        [Column(Order = 2)]
        public int Storage_Id { set; get; }
        public int Quantity { get; set; } 
        public virtual Storage storage { get; set; }
        public virtual Product product { get; set; }
    }
}
