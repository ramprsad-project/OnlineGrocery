namespace GroceryManagementAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
        public int StatusId { get; set; }
        public decimal CartTotal { get; set; }
        public int CouponId { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ShippingAmount { get; set; }
    }
}
