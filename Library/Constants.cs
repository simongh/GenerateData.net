
namespace GenerateData
{
	public static class Constants
	{
	}

	public static class ErrorCodes
	{
		public const int NotLoggedIn = 1;
		public const int NonAdmin = 2;
		public const int FailedSqlStatement = 3;
		public const int InvalidParams = 4;
		public const int InvalidRequest = 5;
		public const int AccountAlreadyExists = 6;
	}

	public enum AccountType
	{
		Admin,
		User
	}

	public enum AccountSetup
	{
		Multiple,
		AnonymousAdmin

	}
}
