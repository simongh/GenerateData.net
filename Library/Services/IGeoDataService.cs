using System.Collections.Generic;

namespace GenerateData.Services
{
	public interface IGeoDataService
	{
		IEnumerable<Data.Region> GetRegions();
		IEnumerable<Data.Region> GetRegions(int countryId);
		IEnumerable<Data.City> GetCities();
		IEnumerable<Data.City> GetCities(int regionId);
	}
}
