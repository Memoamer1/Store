using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class Cart
    {
        public int Cart_id { get; set; }
        public List<Cart_item> cart_item { get; set; }
        public int User_id { get; set; }
        public User user { get; set; }
    }
}
