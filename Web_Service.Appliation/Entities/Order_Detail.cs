

namespace Web_Service.Appliation.Entities
{
    public class Order_Detail
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

        public virtual OrderEntity OrderEntity { get; set; }

        public virtual ProductEntity ProductEntity { get; set; }
    }
}
