namespace AdminPanel.Models
{
    public class User
    {
		public string Id { get; set; }
		public string Email { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public Address Address { get; set; }
		public int? BranchId { get; set; } // Required foreign key property

		public string GetAddress { get => Address?.ToString(); }
		public string GetPhone { get => Address?.Phone?.ToString(); }

		public override string ToString()
		{
            return string.Format("{0} {1}",Firstname,Lastname);
		}
	}
}
