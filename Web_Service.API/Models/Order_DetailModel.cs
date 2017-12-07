


namespace Web_Services.Api.Models
{
    public class Order_DetailModel
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

        public virtual OrderEntityModel OrderEntityModel { get; set; }

        public virtual ProductModel ProductModel { get; set; }
    }
}
