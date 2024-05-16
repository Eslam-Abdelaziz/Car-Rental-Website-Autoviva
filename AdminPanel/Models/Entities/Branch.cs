namespace AdminPanel.Models
{
    public class Branch : BaseEntity
	{
        public string Name { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return Name;
        }

	}
}
