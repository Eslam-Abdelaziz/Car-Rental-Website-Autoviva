namespace CarRental.Data.DTO.Requests
{
    public class RentalSearchRequest
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public decimal Price { get; set; }

        public int? RentalStatus { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }
    }
}
