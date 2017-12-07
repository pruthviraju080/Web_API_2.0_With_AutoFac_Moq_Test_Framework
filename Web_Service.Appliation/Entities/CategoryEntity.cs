using System;
using System.Collections.Generic;

namespace Web_Service.Appliation.Entities
{

    public class CategoryEntity
    {
        
        public CategoryEntity()
        {
            Products = new HashSet<ProductEntity>();
        }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}
