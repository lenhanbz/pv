using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webmvc_demo.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int categoryOfProductID { get; set; }

    }
}