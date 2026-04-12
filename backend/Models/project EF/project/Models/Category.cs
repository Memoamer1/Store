using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    public class Category
    {
        public int Category_id { get; set; }
        public int category_name { get; set; }
        public List<Product> products { get; set; }
    }
}
