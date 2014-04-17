using System;

namespace GenerateData.Services
{
	public interface ISettingsService
	{
		string Get(string name);
		T Get<T>(string name, Func<string, T> convertor);
		void Set(string name, string value);
		void Set<T>(string name, T value);
	}
}
