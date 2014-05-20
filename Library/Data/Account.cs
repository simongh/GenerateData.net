using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenerateData.Data
{
	public class Account
	{
		[Key]
		[Column("AccountId")]
		public int Id { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime LastUpdated { get; set; }
		public DateTime LastLogin { get; set; }
		public DateTime DateExpires { get; set; }
		public AccountType AccountType { get; set; }
		[StringLength(50)]
		public string Firstname { get; set; }
		[StringLength(50)]
		public string Lastname { get; set; }
		[Required]
		[StringLength(100)]
		public string Email { get; set; }
		[Required]
		[StringLength(50)]
		public string Password { get; set; }
		[StringLength(100)]
		public string RecoveryQuestion { get; set; }
		[StringLength(100)]
		public string RecoveryAnswer { get; set; }
		public int RowsGenerated { get; set; }
		public int? MaxRecords { get; set; }

		public virtual IList<Data.Configuration> Configurations { get; set; }
	}
}
