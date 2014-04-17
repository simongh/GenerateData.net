using System;
using System.Collections.Generic;
using System.Reflection;

namespace GenerateData.Config
{
	internal class ConfigService : IConfigService
	{
		private readonly Section _config;
		private readonly Services.ISettingsService _settings;

		public string DefaultExportType
		{
			get { return _config.DefaultExportType; }
		}

		public bool IsDemoMode
		{
			get { return _config.DemoMode; }
		}

		public bool AllowMultiUserAnonymous
		{
			get { return _settings.Get(Settings.AllowAnonymousAccess, x => x.Equals(bool.TrueString, StringComparison.InvariantCultureIgnoreCase)); }
		}

		public string ConnectionStringName
		{
			get { return _config.ConnectionStringName; }
		}

		public int MaxGeneratedRows
		{
			get { return _config.MaxGeneratedRows; }
		}

		public int DefaultNumberOfRows
		{
			get { return _config.DefaultNumberOfRows; }
		}

		public int MaxDemoRows
		{
			get { return _config.MaxDemoRows; }
		}

		public string Version
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
				//var ass = Assembly.GetExecutingAssembly();
				//var fvi = FileVersionInfo.GetVersionInfo(ass.Location);
				//return fvi.ProductVersion;
			}
		}

		public bool IsInstalled
		{
			get { return _settings.Get(Settings.InstallationComplete, x => x.Equals(bool.TrueString, StringComparison.InvariantCultureIgnoreCase)); }
		}

		public string DefaultLanguage
		{
			get { return _config.DefaultLanguage; }
		}

		public IEnumerable<string> DataTypeGroups
		{
			get;
			private set;
		}

		public IEnumerable<string> Continents
		{
			get;
			private set;
		}

		public string DefaultTheme
		{
			get { return _config.DefaultTheme; }
		}

		public ConfigService(Section config, Services.ISettingsService settings)
		{
			_config = config;
			_settings = settings;

			Continents = new string[] { "africa", "asia", "central_america", "europe", "north_america", "oceania", "south_america" };
			DataTypeGroups = new string[] { "human_data", "geo", "credit_card_data", "text", "numeric", "math", "other" };
		}
	}
}
