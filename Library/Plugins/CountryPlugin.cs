using System;
using System.Collections.Generic;

namespace GenerateData.Plugins
{
	public abstract class CountryPlugin
	{
		public string Continent
		{
			get;
			protected set;
		}

		public string CountryName
		{
			get;
			protected set;
		}

		public IDictionary<string, string> CountryData
		{
			get;
			protected set;
		}

		public IEnumerable<string> Regions
		{
			get;
			protected set;
		}

		public IDictionary<string, string> ExtendedData
		{
			get;
			protected set;
		}

		public abstract void Install();

		public virtual void Uninstall()
		{ }

		public IDictionary<string, string> RegionalExtendedData(string key)
		{
			throw new NotImplementedException();
		}
	}
}
