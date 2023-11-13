using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductModel
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
