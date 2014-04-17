using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateData.Data
{
	public enum Status
	{
		Private,
		Public
	}

	public class Configuration
	{
		[Key]
		[Column("ConfigurationId")]
		public int Id { get; set; }
		public Status Status { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime LastUpdated { get; set; }
		public int AccountId { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; }
		[Required]
		public string Value { get; set; }
		public int RowsGenerated { get; set; }

		public virtual Account Account { get; set; }
	}
}
