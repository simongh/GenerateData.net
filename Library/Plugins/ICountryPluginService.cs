using System.Collections.Generic;

namespace GenerateData.Plugins
{
	public interface ICountryPluginService
	{
		IEnumerable<CountryPlugin> GetPlugins(bool installedOnly = true);
		//CountryPlugin GetPlugin(string name);
		void PopulateDb(Data.Country country);
	}
}
