using System;
using System.Collections.Generic;

namespace GenerateData.Plugins
{
	[Flags]
	public enum ExportTargets
	{
		InPage = 1,
		NewTab = 2,
		PromptDownload = 4,
		All = 7
	}

	public abstract class ExportTypePlugin
	{
		public abstract string Name { get; }

		public bool IsEnabled
		{
			get;
			protected set;
		}

		public IEnumerable<string> JsModules
		{
			get;
			protected set;
		}

		public IEnumerable<string> CssFiles
		{
			get;
			protected set;
		}

		public IEnumerable<string> CodeMirrorModes
		{
			get;
			protected set;
		}

		public abstract string ContentTypeHeader
		{
			get;
		}

		public ExportTargets CompatibleExportTargets
		{
			get;
			protected set;
		}

		public virtual string AdditionalSettingsHtml
		{
			get { return ""; }
		}

		public ExportTypePlugin()
		{
			JsModules = new string[] { };
			CssFiles = new string[] { };
			CodeMirrorModes = new string[] { };

			IsEnabled = true;
			CompatibleExportTargets = ExportTargets.All;
		}

		public abstract object Generate(object generator);

		public abstract string GetDownloadFilename(object generator);

		public void Install()
		{ }


	}
}
