namespace GroceryManagementAPI.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? CategoryImage { get; set; }
        public int CategoryStatusId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
