using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;

namespace GenerateData.Data
{
	public partial class Context : DbContext, IContext
	{
		public IDbSet<City> Cities { get; set; }
		public IDbSet<Configuration> Configurations { get; set; }
		public IDbSet<Country> Countries { get; set; }
		public IDbSet<Region> Regions { get; set; }
		public IDbSet<Setting> Settings { get; set; }
		public IDbSet<Session> Sessions { get; set; }
		public IDbSet<Account> Accounts { get; set; }

		public override int SaveChanges()
		{
			try
			{
				return base.SaveChanges();
			}
			catch (DbEntityValidationException ex)
			{
				var sb = new StringBuilder();

				foreach (var failure in ex.EntityValidationErrors)
				{
					sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
					foreach (var error in failure.ValidationErrors)
					{
						sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
						sb.AppendLine();
					}
				}

				throw new DbEntityValidationException(
					"Entity Validation Failed - errors follow:\n" +
					sb.ToString(), ex
					); // Add the original exception as the innerException
			}
		}
	}
}
