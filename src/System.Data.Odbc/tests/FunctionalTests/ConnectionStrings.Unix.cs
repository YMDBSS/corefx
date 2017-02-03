namespace System.Data.Odbc.Tests
{
    public static class ConnectionStrings
    {
        // requires unixodbc and libsqliteodbc
        public const string WorkingConnection =
            "Driver=SQLite3;" +
            "Database=smoketests.sqlite;";
    }
}
