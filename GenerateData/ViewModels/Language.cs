using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace GenerateData.ViewModels
{
	public class Language
	{
		public string GetStrings()
		{
			var t = typeof(Resources.Scripts);

			var d = t.GetProperties(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.GetProperty).Where(x => x.PropertyType == typeof(string)).ToDictionary(x => x.Name, x => x.GetValue(null).ToString());

			return JsonConvert.SerializeObject(d);
		}
	}
}