namespace formApp.Models
{
    public class FormModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required int Age { get; set; }
        public required string PhoneNo { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }

    }
}
