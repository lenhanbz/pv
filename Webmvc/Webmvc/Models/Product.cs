using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webmvc.Models
{
    public class Product
    {
        [DisplayName("Ma san pham")]
        [Required]
        public int productID { get; set; }
        [DisplayName("Ten san pham")]
        [Required]
        public string NameOfProduct { get; set; }
        [DisplayName("Loai san pham")]
        public int CategoryOfProductID { get; set; }

    }
}