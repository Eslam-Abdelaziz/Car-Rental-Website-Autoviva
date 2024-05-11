namespace CarRental.Data.DTO.Requests
{
    public class AddEditBranchReq
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }

    }
}
