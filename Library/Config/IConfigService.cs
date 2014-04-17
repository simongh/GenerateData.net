using System.Collections.Generic;

namespace GenerateData.Config
{
	public interface IConfigService
	{
		string DefaultExportType { get; }
		bool IsDemoMode { get; }
		bool AllowMultiUserAnonymous { get; }
		string ConnectionStringName { get; }
		int MaxGeneratedRows { get; }
		int DefaultNumberOfRows { get; }
		int MaxDemoRows { get; }
		string Version { get; }
		bool IsInstalled { get; }
		string DefaultLanguage { get; }
		IEnumerable<string> DataTypeGroups { get; }
		IEnumerable<string> Continents { get; }
		string DefaultTheme { get; }
	}
}
