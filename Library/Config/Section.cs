using System.Configuration;

namespace GenerateData.Config
{
	public class Section : ConfigurationSection
	{
		private const string DEMOMODE = "demoMode";
		private const string MAXGENROWS = "maxGeneratedRows";
		private const string DEFAULTNUMROWS = "defaultNumberOfRows";
		private const string MAXDEMOROWS = "maxDemoRows";
		private const string CONNSNAME = "connectionStringName";
		private const string DEFAULTLANGUAGE = "defaultLanguage";
		private const string DEFAULTEXPORTTYPE = "defaultExportType";
		private const string DEFAULTTHEME = "defaultTheme";

		[ConfigurationProperty(DEMOMODE, DefaultValue = false)]
		public bool DemoMode
		{
			get { return (bool)this[DEMOMODE]; }
			set { this[DEMOMODE] = value; }
		}

		[ConfigurationProperty(MAXGENROWS, DefaultValue = 100000)]
		public int MaxGeneratedRows
		{
			get { return (int)this[MAXGENROWS]; }
			set { this[MAXGENROWS] = value; }
		}

		[ConfigurationProperty(DEFAULTNUMROWS, DefaultValue = 100)]
		public int DefaultNumberOfRows
		{
			get { return (int)this[DEFAULTNUMROWS]; }
			set { this[DEFAULTNUMROWS] = value; }
		}

		[ConfigurationProperty(MAXDEMOROWS, DefaultValue = 100)]
		public int MaxDemoRows
		{
			get { return (int)this[MAXDEMOROWS]; }
			set { this[MAXDEMOROWS] = value; }
		}

		[ConfigurationProperty(CONNSNAME, IsRequired = true)]
		public string ConnectionStringName
		{
			get { return (string)this[CONNSNAME]; }
			set { this[CONNSNAME] = value; }
		}

		[ConfigurationProperty(DEFAULTLANGUAGE, DefaultValue = "en")]
		public string DefaultLanguage
		{
			get { return (string)this[DEFAULTLANGUAGE]; }
			set { this[DEFAULTLANGUAGE] = value; }
		}

		[ConfigurationProperty(DEFAULTEXPORTTYPE, DefaultValue = "HTML")]
		public string DefaultExportType
		{
			get { return (string)this[DEFAULTEXPORTTYPE]; }
			set { this[DEFAULTEXPORTTYPE] = value; }
		}

		[ConfigurationProperty(DEFAULTTHEME, DefaultValue = "classic")]
		public string DefaultTheme
		{
			get { return (string)this[DEFAULTTHEME]; }
			set { this[DEFAULTTHEME] = value; }
		}
	}
}
