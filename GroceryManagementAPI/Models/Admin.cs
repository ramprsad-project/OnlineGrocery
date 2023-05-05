namespace GroceryManagementAPI.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public int RoleId { get; set; }
        public int AccountStatusId { get; set; }
    }
}
