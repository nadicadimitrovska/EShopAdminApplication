using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAdminApplication.Models
{
    public class Product
    {
        
        public Guid Id { get; set; }
        public string ProductName { get; set; }

        public string ProductImage { get; set; }
      
        public string ProductDescription { get; set; }
        
        public int ProductPrice { get; set; }
       
        public int Rating { get; set; }
      
    }
}
