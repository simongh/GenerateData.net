using System.Configuration;

namespace GenerateData.Services
{
	public class ServiceModule : Ninject.Modules.NinjectModule
	{
		public override void Load()
		{
			Bind<Config.Section>().ToMethod(x => (Config.Section)ConfigurationManager.GetSection("generateData"));

			Bind<IMailService>().To<MailService>();
			Bind<ISettingsService>().To<SettingsService>();
			Bind<IGeoDataService>().To<GeoDataService>();
			Bind<Config.IConfigService>().To<Config.ConfigService>();
		}
	}
}
