using System.Collections.Generic;

namespace Web_Service.Appliation.Entities
{

    public  class ProductEntity
    {
        public ProductEntity()
        {
            Order_Details = new HashSet<Order_Detail>();
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

        public virtual CategoryEntity CategoryEntity { get; set; }

        public virtual ICollection<Order_Detail> Order_Details { get; set; }

        public virtual SupplierEntity SupplierEntity { get; set; }
    }
}
