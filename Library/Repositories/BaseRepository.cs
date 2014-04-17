using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerateData.Repositories
{
	internal abstract class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected readonly Data.IContext Context;

		public BaseRepository(Data.IContext context)
		{
			Context = context;
		}

		public abstract T Get(int id);

		protected T Get(Func<T, bool> selector)
		{
			return Context.Set<T>().SingleOrDefault(selector);
		}

		public virtual IEnumerable<T> Query()
		{
			return Context.Set<T>();
		}

		public virtual void Delete(int id)
		{
			var item = Get(id);
			if (item == null)
				return;

			Context.Set<T>().Remove(item);
		}

		public virtual void Save()
		{
			Context.SaveChanges();
		}

		public virtual void Add(T item)
		{
			Context.Set<T>().Add(item);
		}
	}
}
