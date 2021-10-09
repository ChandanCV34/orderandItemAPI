using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public string UserID { get; set; }

        public int OrderTotal { get; set; }

        public int DeliveryCharge { get; set; }

        public string  Status { get; set; }
    }
}
