namespace GroceryManagementAPI.Models
{
    public class DamagedProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? DamageDescription { get; set; }
        public bool IsDamagedAtManufacture { get; set; }
        public bool IsDamagedAtStore { get; set; }
        public bool IsDamagedDuringTransit { get; set; }
    }
}
