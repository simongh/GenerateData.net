using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateData.Data
{
	public class Setting
	{
		[Key]
		[Column("SettingId")]
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		[Index("IX_Settings_Name", IsUnique = true)]
		public string Name { get; set; }
		public string Value { get; set; }
	}
}
