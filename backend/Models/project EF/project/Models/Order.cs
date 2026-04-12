using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class Order
    {
        public int Order_id { get; set; }
        public int total_price { get; set; }
        public int user_id { get; set; }
        public User user { get; set; }
        public List<Order_item> order_items { get; set; }
        public Payment payment { get; set; }
    }
}
