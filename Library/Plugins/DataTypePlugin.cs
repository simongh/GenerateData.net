using System.Collections.Generic;

namespace GenerateData.Plugins
{
	public abstract class DataTypePlugin
	{
		public abstract string Name { get; }

		public abstract string dataTypeFieldGroup { get; }

		public abstract int DataTypeFieldGroupOrder { get; }

		public virtual int ProcessOrder
		{
			get { return 1; }
		}

		public virtual bool IsEnabled
		{
			get;
			protected set;
		}

		public virtual IEnumerable<string> JsModules
		{
			get;
			protected set;
		}

		public virtual IEnumerable<string> CssFiles
		{
			get;
			protected set;
		}

		public virtual string ExampleColumnHtml
		{
			get { return ""; }
		}

		public virtual string OptionsColumnhtml
		{
			get { return ""; }
		}

		public virtual string HelpHtml
		{
			get { return "<p>No help available.</p>"; }
		}

		public DataTypePlugin()
		{
			IsEnabled = true;
			JsModules = new string[] { };
			CssFiles = new string[] { };
		}

		public abstract object Generate(object Generator, object context);

		public virtual void Install()
		{ }

		public virtual object GetRowGenerationOptions(object generator, object postData, int columnNumber, int columnCount)
		{
			return null;
		}

		public virtual object GetDataTypeMetaData()
		{
			return null;
		}
	}
}
