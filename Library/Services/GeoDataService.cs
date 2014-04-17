using System.Collections.Generic;
using System.Linq;

namespace GenerateData.Services
{
	internal class GeoDataService : IGeoDataService
	{
		private readonly Repositories.ICountryRepository _countries;
		private readonly Repositories.IRegionRepository _regions;
		private readonly Repositories.ICityRepository _cities;

		public GeoDataService(Repositories.ICountryRepository countries, Repositories.IRegionRepository regions, Repositories.ICityRepository cities)
		{
			_countries = countries;
			_regions = regions;
			_cities = cities;
		}

		public IEnumerable<Data.Region> GetRegions()
		{
			return _regions.Query().ToList();
		}

		public IEnumerable<Data.Region> GetRegions(int countryId)
		{
			return _regions.Query().Where(r => r.CountryId == countryId).ToList();
		}

		public IEnumerable<Data.City> GetCities()
		{
			return _cities.Query().ToList();
		}

		public IEnumerable<Data.City> GetCities(int regionId)
		{
			return _cities.Query().Where(c => c.RegionId == regionId).ToList();
		}
	}
}
