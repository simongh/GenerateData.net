using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GenerateData.Plugins
{
	internal class CountryPluginService : ICountryPluginService
	{
		private readonly Services.ISettingsService _settings;
		private readonly Repositories.CountryRepository _countries;
		private readonly Func<Type, CountryPlugin> _factory;

		public CountryPluginService(Services.ISettingsService settings, Repositories.CountryRepository countries, Func<Type, CountryPlugin> factory)
		{
			_settings = settings;
			_countries = countries;
			_factory = factory;
		}

		public IEnumerable<CountryPlugin> GetPlugins(bool installedOnly = true)
		{
			string[] installed = null;
			if (installedOnly)
			{
				installed = _settings.Get(Settings.InstalledCountries, v => v.Split('|'));
				return installed.Select(t => _factory(Type.GetType(t)));
			}
			else
				return GetTypesFromFiles().Select(t => _factory(t));
		}

		private IEnumerable<Type> GetTypesFromFiles()
		{
			var baset = typeof(CountryPlugin);

			var location = this.GetType().Assembly.Location;
			foreach (var f in Directory.EnumerateFiles(location, "*.dll"))
			{
				var ass = Assembly.ReflectionOnlyLoadFrom(f);
				var types = ass.GetTypes();
				foreach (var item in types)
				{
					if (item.BaseType == baset)
						yield return item;
				}
			}
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
