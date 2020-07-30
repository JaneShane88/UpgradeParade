using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UpgradeParadeTT.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
