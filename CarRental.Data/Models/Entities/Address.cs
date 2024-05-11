
namespace CarRental.Data.Models.Entities
{
	public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }


        public int? BranchId { get; set; }
        public  Branch? Branch { get; set; }

        public string? UserId { get; set; }
        public  User? User { get; set; }
        public Address()
        {

        }

        public Address(int id , string street,string city,string state,int zipcode,string phone)
        {
            Id = id;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipcode;
            Phone = phone;
        }
        public Address( string street, string city, string state, int zipcode, string phone)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipcode;
            Phone = phone;
        }
        public override string ToString()
        {
            return string.Format("{0} , {1} , {2} {3}",Street,City,State,ZipCode);
        }
    }
}
