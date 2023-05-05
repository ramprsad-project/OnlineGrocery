namespace GroceryManagementAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MerchantId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string? ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Status { get; set; }
        public int HelpfulVotes { get; set; }
        public string? ReviewResponse { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string? ResponseStatus { get; set; }
    }
}
