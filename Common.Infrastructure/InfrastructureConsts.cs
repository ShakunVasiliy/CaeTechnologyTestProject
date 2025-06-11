namespace Common.Infrastructure
{
    public static class InfrastructureConsts
    {
        public static class Config
        {
            public const string DefaultFileName = "appsettings.json";

            public static class ConnectionString
            {
                public const string SaleGraphDb = $"{nameof(SaleGraphDb)}";
            }
        }

        public static class DbTypes
        {
            public const string Date = "date";
        }
    }
}
