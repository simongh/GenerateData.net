using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateData.Data
{
	public class Country
	{
		[Key]
		[Column("CountryId")]
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		public virtual IList<Region> Regions { get; set; }
		//public virtual IList<City> Cities { get; set; }
	}
}
