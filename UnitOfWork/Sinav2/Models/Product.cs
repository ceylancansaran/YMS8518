using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public List<Order> Orders { get; set; }
    }
}
