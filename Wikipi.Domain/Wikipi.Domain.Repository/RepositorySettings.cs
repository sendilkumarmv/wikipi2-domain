namespace Wikipi.Domain.Repository
{
    public class RepositorySettings
    {
        public const string SECTION = "Settings:Repository";
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }

    }
}
