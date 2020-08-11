namespace Tournament.DB.Configs
{
    public class Settings
    {
        private static string _dbConnectionString => @"";

        public static string GetDBConnectionString() => _dbConnectionString;
    }
}
