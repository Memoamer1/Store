using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class Cart_item
    {
        public int Cart_item_id { get; set; }
        public int quantity { get; set; }
        public int product_id { get; set; }
        public Product product { get; set; }
        public int cart_id { get; set; }
        public Cart cart { get; set; }
    }
}
