using System;
using System.Collections;
using System.Linq;

namespace GenerateData.Services
{
	internal class ConfigurationService
	{
		private readonly Repositories.IConfigurationRepository _configurations;

		public Data.Account CurrentUser { get; set; }

		public ConfigurationService(Repositories.IConfigurationRepository configurations)
		{
			_configurations = configurations;
		}

		public object GetPublicDataSet(int configurationId)
		{
			var result = _configurations.Query().SingleOrDefault(c => c.Id == configurationId && c.Status == Data.Status.Public);

			return result;
		}

		public IEnumerable GetUsersConfigurations()
		{
			return _configurations.Query().Where(c => c.AccountId == CurrentUser.Id).OrderBy(c => c.LastUpdated).ToList();
		}

		public void DeleteConfiguration(int configurationId)
		{
			var item = _configurations.Query().SingleOrDefault(c => c.Id == configurationId && c.AccountId == CurrentUser.Id);
			if (item == null)
				return;

			_configurations.Delete(item);
		}

		public void SaveConfiguration(object data)
		{
			//check configid != 0
			//status = private
			//acountid=currentuser
			//json encode data to content
			//create date=now
			//lastupdate = now
			throw new NotImplementedException();
		}

		public void CopyConfiguration(object data)
		{
			throw new NotImplementedException();
		}

		public void UpdateStatus(int configurationId, Data.Status status)
		{
			var item = _configurations.Query().SingleOrDefault(c => c.Id == configurationId && c.AccountId == CurrentUser.Id);
			if (item == null)
				return;

			item.Status = status;
			_configurations.Save();
		}

		public void UpdateRowsGenerated(int configurationId, int count)
		{
			var item = _configurations.Query().SingleOrDefault(c => c.Id == configurationId && c.AccountId == CurrentUser.Id);
			if (item == null)
				return;

			item.RowsGenerated += count;
			item.Account.RowsGenerated += count;
			_configurations.Save();
		}
	}
}
