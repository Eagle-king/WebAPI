using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Supplier { get; set; }
        public int ProductQty { get; set; }

        public string ExpirationDate { get; set; }
        public string PhotoFileName { get; set; }
    }
}
