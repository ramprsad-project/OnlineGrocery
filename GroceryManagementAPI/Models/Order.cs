namespace GroceryManagementAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PerUnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentMethod { get; set; }
        public int PaymentStatusId { get; set; }
        public string? ShippingAddress { get; set; }
        public string? BillingAddress { get; set; }
        public string? ShippingMethod { get; set; }
        public string? OrderNotes { get; set; }
        public DateTime? OrderShipmentDate { get; set; }
        public DateTime? OrderDeliveryDate { get; set; }
    }

}
