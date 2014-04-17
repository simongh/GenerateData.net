
namespace GenerateData.Repositories
{
	internal class SessionRepository : BaseRepository<Data.Session>, ISessionRepository
	{
		public SessionRepository(Data.IContext context)
			: base(context)
		{ }

		public override Data.Session Get(int id)
		{
			return Get(s => s.Id == id);
		}
	}
}
