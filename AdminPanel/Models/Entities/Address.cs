namespace AdminPanel.Models
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
            return string.Format("{0} , {1} , {2} {3}", Street, City, State, ZipCode);
        }

	}
}
