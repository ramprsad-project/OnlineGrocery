namespace GroceryManagementAPI.Models
{
    public class Merchant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? Logo { get; set; }
        public string? Description { get; set; }
        public string? Website { get; set; }
        public bool StatusIs { get; set; }
    }
}
