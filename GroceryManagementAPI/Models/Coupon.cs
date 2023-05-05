namespace GroceryManagementAPI.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string? DiscountCode { get; set; }
        public string? CouponCode { get; set; }
        public string? CouponType { get; set; }
        public decimal CouponValue { get; set; }
        public DateTime CouponStartDate { get; set; }
        public DateTime CouponEndDate { get; set; }
        public decimal CouponMinimumPurchase { get; set; }
        public decimal CouponMaximumDiscount { get; set; }
        public int CouponUsageLimit { get; set; }
        public int CouponUsageCount { get; set; }
        public int CouponStatusId { get; set; }
    }

}
