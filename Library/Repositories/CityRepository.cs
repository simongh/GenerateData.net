
namespace GenerateData.Repositories
{
	internal class CityRepository : BaseRepository<Data.City>, ICityRepository
	{
		public CityRepository(Data.IContext context)
			: base(context)
		{ }

		public override Data.City Get(int id)
		{
			return Get(c => c.Id == id);
		}
	}
}
