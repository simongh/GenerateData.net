using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateData.Data
{
	public class Session
	{
		[Key]
		[Column("SessionId")]
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Key { get; set; }
		public string Data { get; set; }
		public int Expires { get; set; }
	}
}
