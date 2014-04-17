
namespace GenerateData.Repositories
{
	internal class CountryRepository : BaseRepository<Data.Country>, ICountryRepository
	{
		public CountryRepository(Data.IContext context)
			: base(context)
		{ }

		public override Data.Country Get(int id)
		{
			return Get(c => c.Id == id);
		}
	}
}
