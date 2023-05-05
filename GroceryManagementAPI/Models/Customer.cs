namespace GroceryManagementAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? Address { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

}
