using System;

namespace Interfaces_and_Extensibility
{

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");

            // details of migrating the database

            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}
