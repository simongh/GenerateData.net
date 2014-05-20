using Newtonsoft.Json;

namespace GenerateData.ViewModels
{
	public class Constants
	{
		public bool ConsoleWarnings { get; set; }

		public bool ConsoleEventsPublish { get; set; }

		public bool ConsoleEventsSubscribe { get; set; }

		public bool ConsoleCoreEvents { get; set; }

		public string LimitDataTypeEvents { get; set; }

		public string LimitExportTypeEvents { get; set; }

		public string AnonymousUserDeniedMsg { get; set; }

		public int MaxGeneratedRows { get; set; }

		public bool IsDemoMode { get; set; }

		public string Theme { get; set; }

		public Constants()
		{
			LimitDataTypeEvents = "";
			LimitExportTypeEvents = "";
		}

		public string DebuggingToJson()
		{
			return JsonConvert.SerializeObject(new
			{
				CONSOLE_WARN = ConsoleWarnings,
				LIST_PUBLSH_EVENTS = ConsoleEventsPublish,
				LIST_SUBSCRIBE_EVENTS = ConsoleEventsSubscribe,
				LIST_CORE_EVENTS = ConsoleCoreEvents,
				LIMIT_DATA_TYPE_EVENTS = LimitDataTypeEvents,
				LIMIT_EXPORT_TYPE_EVENTS = LimitExportTypeEvents
			});
		}

		public string AnonDeniedMsgToJson()
		{
			return JsonConvert.SerializeObject(AnonymousUserDeniedMsg);
		}

		public string ThemeToJson()
		{
			return JsonConvert.SerializeObject(Theme);
		}
	}
}