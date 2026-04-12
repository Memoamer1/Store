using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class Product
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int category_id { get; set; }
        public Category category { get; set; }
        public List<Cart_item> cart_item { get; set; }
        public List<Order_item> order_item { get; set; }
    }
}
