using Microsoft.Build.Framework;
using System.Text.Json.Serialization;

namespace CarRental.UI.Models.Cars
{
    public class IndexCarSearchReq
    {

        [JsonIgnore]
        public string? Keyword { get; set; }

        [JsonIgnore]
        public int? Sort { get; set; }

		public string? Brand { get; set; }
        [JsonIgnore]
        public string? Model { get; set; }
        [JsonIgnore]

        public int? MinYear { get; set; }
        [JsonIgnore]

        public int? MaxYear { get; set; }

        [Required]
        public string RentBranch { get; set; } = string.Empty;

        public string? ReturnBranch { get; set; }

		[Required]
        public DateTime From { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

		public int? MinPrice { get; set; }


		public int? MaxPrice { get; set; }
        [JsonIgnore]

        public bool? Gasoline { get; set; }
		[JsonIgnore]
		public bool? Eletric { get; set; }




    }

}
