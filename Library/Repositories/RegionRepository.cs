
namespace GenerateData.Repositories
{
	internal class RegionRepository : BaseRepository<Data.Region>, IRegionRepository
	{
		public RegionRepository(Data.IContext context)
			: base(context)
		{ }

		public override Data.Region Get(int id)
		{
			return Get(r => r.Id == id);
		}
	}
}
