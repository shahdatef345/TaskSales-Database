using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        // Foreign keys
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }

    }
}
