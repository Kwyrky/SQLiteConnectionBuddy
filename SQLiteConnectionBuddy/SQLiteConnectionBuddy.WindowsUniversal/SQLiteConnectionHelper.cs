using SQLite;

namespace SQLiteConnectionBuddy
{
	public class SQLiteConnectionHelper : SQLiteConnectionHelperBase
	{
		#region Methods

		static SQLiteConnectionHelper()
		{
			DocumentsPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
		}

		private SQLiteConnectionHelper()
		{
		}

		private static SQLiteConnection GetSqlConnection(string dbName)
		{
			return new SQLiteConnection(dbName);
		}

		public static SQLiteConnection GetConnection(string dbName, bool local = false)
		{
			return local ? GetSqlConnection(dbName) : GetSqlConnection(GetFilename(dbName));
		}

		#endregion //Methods
	}
}
