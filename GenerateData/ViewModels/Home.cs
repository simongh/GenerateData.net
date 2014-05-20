
using System.Collections.Generic;
namespace GenerateData.ViewModels
{
	public class Home
	{
		public string Theme
		{
			get;
			set;
		}

		public string CurrentLanguage
		{
			get;
			set;
		}

		public bool IsLoggedIn
		{
			get;
			set;
		}

		public AccountSetup UserAccountSetup
		{
			get;
			set;
		}

		public AccountType AccountType
		{
			get;
			set;
		}

		public IDictionary<string, string> Languages
		{
			get;
			set;
		}
	}
}