using System;

namespace Extensibility
{
    public class Migration
    {
        private readonly ILogger _logger;
        public Migration(ILogger logger)
        {
            this._logger = logger;

        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
