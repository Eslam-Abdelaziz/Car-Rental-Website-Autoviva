namespace CarRental.Data.DTO.Entities
{
    public class UserDto
    {

        public string Id { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public AddressDto Address { get; set; }
        public int? BranchId { get; set; } // Required foreign key property

    }
}
