using System;
using System.Collections.Generic;

namespace GenerateData.Plugins
{
	internal class CountryPluginService
	{
		private readonly Services.ISettingsService _settings;
		private readonly Repositories.CountryRepository _countries;

		public CountryPluginService(Services.ISettingsService settings, Repositories.CountryRepository countries)
		{
			_settings = settings;
			_countries = countries;
		}

		public IEnumerable<CountryPlugin> GetPlugins()
		{
			throw new NotImplementedException();
		}

		public CountryPlugin GetPlugin(string name)
		{
			throw new NotImplementedException();
		}

		public void PopulateDb(Data.Country country)
		{
			_countries.Add(country);
			_countries.Save();
		}
	}
}
