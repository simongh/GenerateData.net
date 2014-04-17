using System;

namespace GenerateData.Services
{
	internal class SettingsService : ISettingsService
	{
		private readonly Repositories.ISettingRepository _settings;

		public SettingsService(Repositories.ISettingRepository settings)
		{
			_settings = settings;
		}

		public string Get(string name)
		{
			return Get(name, s => s);
		}

		public void Set(string name, string value)
		{
			Set<string>(name, value);
		}

		public T Get<T>(string name, Func<string, T> convertor)
		{
			var result = _settings.Get(name);
			if (name == null)
				throw new ApplicationException("unknown setting");

			return convertor(result.Value);
		}

		public void Set<T>(string name, T value)
		{
			var result = _settings.Get(name);
			if (name == null)
				throw new ApplicationException("unknown setting");

			result.Value = value == null ? null : value.ToString();
		}
	}
}
