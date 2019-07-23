namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
            _logger.Log("DbMigrator:");
        }

        public void Migrate()
        {
            _logger.Log("we are migrating something now.");
        }
    }
}
