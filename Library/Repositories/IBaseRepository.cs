using System.Collections.Generic;

namespace GenerateData.Repositories
{
	public interface IBaseRepository<T> where T : class
	{
		T Get(int id);
		IEnumerable<T> Query();
		void Delete(int id);
		void Save();
		void Add(T item);
	}
}
