namespace AdminPanel.Models
{
    public class Color : BaseEntity
	{
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
	}
}
