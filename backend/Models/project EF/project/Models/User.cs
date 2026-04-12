using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone_number { get; set; }
        public string address { get; set; }
        public List<Order> orders { get; set; }
        public Cart cart { get; set; }
    }
}
