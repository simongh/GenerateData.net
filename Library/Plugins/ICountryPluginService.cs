using System.Collections.Generic;

namespace GenerateData.Plugins
{
	interface ICountryPluginService
	{
		IEnumerable<CountryPlugin> GetPlugins();
		CountryPlugin GetPlugin(string name);
		void PopulateDb(Data.Country country);
	}
}
