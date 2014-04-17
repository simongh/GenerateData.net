
namespace GenerateData.Repositories
{
	internal class SettingRepository : BaseRepository<Data.Setting>, ISettingRepository
	{
		public SettingRepository(Data.IContext context)
			: base(context)
		{ }

		public override Data.Setting Get(int id)
		{
			return Get(r => r.Id == id);
		}

		public Data.Setting Get(string name)
		{
			return Get(s => s.Name.Equals(name, System.StringComparison.InvariantCultureIgnoreCase));
		}
	}
}
