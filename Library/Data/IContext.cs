using System.Data.Entity;

namespace GenerateData.Data
{
	public interface IContext
	{
		IDbSet<City> Cities { get; set; }
		IDbSet<Configuration> Configurations { get; set; }
		IDbSet<Country> Countries { get; set; }
		IDbSet<Region> Regions { get; set; }
		IDbSet<Setting> Settings { get; set; }
		IDbSet<Session> Sessions { get; set; }
		IDbSet<Account> Accounts { get; set; }

		DbSet<T> Set<T>() where T : class;
		int SaveChanges();
	}
}
