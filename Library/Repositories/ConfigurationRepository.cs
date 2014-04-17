
namespace GenerateData.Repositories
{
	internal class ConfigurationRepository : BaseRepository<Data.Configuration>, IConfigurationRepository
	{
		public ConfigurationRepository(Data.IContext context)
			: base(context)
		{ }

		public override Data.Configuration Get(int id)
		{
			return Get(c => c.Id == id);
		}

		public void Delete(Data.Configuration item)
		{
			Context.Configurations.Remove(item);
		}
	}
}
