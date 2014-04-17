using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateData.Data
{
	public class City
	{
		[Key]
		[Column("CityId")]
		public int Id { get; set; }
		//public int CountryId { get; set; }
		public int RegionId { get; set; }
		[Required]
		[StringLength(80)]
		public string Name { get; set; }

		//public virtual Country Country { get; set; }
		public virtual Region Region { get; set; }
	}
}
