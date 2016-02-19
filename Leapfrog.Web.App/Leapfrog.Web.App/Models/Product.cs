using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leapfrog.Web.App.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductManufacturer { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool ExpiredStatus { get; set; }
    }
}