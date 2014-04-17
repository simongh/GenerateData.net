
namespace GenerateData.Repositories
{
	internal class AccountRepository : BaseRepository<Data.Account>, IAccountRepository
	{
		public AccountRepository(Data.IContext context)
			: base(context)
		{ }

		public override Data.Account Get(int id)
		{
			return Get(a => a.Id == id);
		}
	}
}
