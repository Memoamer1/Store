using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class Payment
    {
        public int Payment_id { get; set; }
        public string Payment_status { get; set; }
        public int Order_id { get; set; }
        public Order order { get; set; }
    }
}
