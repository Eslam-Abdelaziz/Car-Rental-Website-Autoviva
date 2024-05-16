namespace AdminPanel.Models
{
	public class Model  : BaseEntity
	{
		public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
