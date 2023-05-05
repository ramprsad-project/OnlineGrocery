namespace GroceryManagementAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public decimal MRP { get; set; }
        public int ProductCategoryId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? ProductDimensions { get; set; }
        public string? Image { get; set; }
    }
}
