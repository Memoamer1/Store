using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class Order_item
    {
        public int Order_item_id { get; set; }
        public int quantity { get; set; }
        public int product_id { get; set; }
        public Product product { get; set; }
        public int order_id { get; set; }
        public Order order { get; set; }
    }
}
