using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public double Quantity { get; set; } 
        public double Price { get; set; }
        public double Sales { get; set; }
    }
}
