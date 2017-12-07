using System.Collections.Generic;

namespace Web_Services.Api.Models
{

    public  class ProductModel
    {
        public ProductModel()
        {
            Order_Details = new HashSet<Order_DetailModel>();
        }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public virtual CategoryModel CategoryModel { get; set; }

        public virtual ICollection<Order_DetailModel> Order_Details { get; set; }

        public virtual SupplierModel SupplierModel { get; set; }
    }
}
