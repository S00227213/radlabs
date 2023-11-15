using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductModel
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public DateTime dateFirstIssued { get; set; }
        public int QuantityInStock { get; set; }
        public virtual Category associatedCategory { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }


    }
}