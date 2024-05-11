namespace CarRental.Data.DTO.Responses
{
    public class StatisticsResponse
    {
        public int TotalRentals { get; set; }

        public int TotalPendingRentals { get; set; }

        public int TotalCompletedRentals { get; set; }

        public int TotalRejectedRentals { get; set; }

        public decimal TotalRevenue { get; set; }

        public decimal TotalPendingRevenue { get;set; }

        public decimal TotalCompletedRevenue { get; set; }
        
        public decimal TotalRejectedRevenue { get; set; }

        public int Cars { get; set; }

        public int Users { get; set; }

        public int Branches { get; set; }

        public int Brands { get; set; }
    }
    
}
