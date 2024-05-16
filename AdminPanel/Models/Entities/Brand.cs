using System.Collections.Generic;

namespace AdminPanel.Models
{
	public class Brand : BaseEntity
	{
        public string Name { get; set; }
        public List<Model> Models { get; set; }
        public override string ToString()
        {
            return Name;
        }

	}
}
