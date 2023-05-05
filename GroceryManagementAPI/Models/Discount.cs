namespace GroceryManagementAPI.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public int EligibleProductId { get; set; }
        public string? DiscountType { get; set; }
        public decimal MinimumDiscountPercentage { get; set; }
        public decimal MaximumDiscountPercentge { get; set; }
        public decimal MinimumPurchaseAmount { get; set; }
        public DateTime DiscountStartDate { get; set; }
        public TimeSpan DiscountStartTime { get; set; }
        public DateTime DiscountEndDate { get; set; }
        public TimeSpan DiscountEndTime { get; set; }
    }
}
