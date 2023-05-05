namespace GroceryManagementAPI.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public TimeSpan Time { get; set; }
        public string? PaymentMethod { get; set; }
        public int OrderId { get; set; }
        public int PaymentStatusId { get; set; }
        public string? TransactionId { get; set; }
        public string? CardType { get; set; }
        public string? CardLast4Digits { get; set; }
        public string? Address { get; set; }
    }

}
