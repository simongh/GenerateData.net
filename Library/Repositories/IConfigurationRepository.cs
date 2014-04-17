
namespace GenerateData.Repositories
{
	public interface IConfigurationRepository : IBaseRepository<Data.Configuration>
	{
		void Delete(Data.Configuration item);
	}
}
