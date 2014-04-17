
namespace GenerateData.Repositories
{
	public interface ISettingRepository : IBaseRepository<Data.Setting>
	{
		Data.Setting Get(string name);
	}
}
