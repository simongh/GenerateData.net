using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateData.Data
{
	public class Region
	{
		[Key]
		[Column("RegionId")]
		public int Id { get; set; }
		public int CountryId { get; set; }
		[Required]
		[StringLength(35)]
		[Column(TypeName = "nvarchar")]
		public string Name { get; set; }
		[StringLength(2)]
		[Column(TypeName = "nvarchar")]
		public string ShortName { get; set; }
		[Required]
		public int Weight { get; set; }

		public virtual Country Country { get; set; }
		public virtual IList<City> Cities { get; set; }
	}
}
