using System.Collections.Generic;

namespace Web_Services.Api.Models
{

    public class CategoryModel
    {
        
        public CategoryModel()
        {
            Products = new HashSet<ProductModel>();
        }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
