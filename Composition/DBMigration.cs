namespace Composition
{
    class DBMigration
    {
        private readonly Logger _logger;

        public DBMigration(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migration bla bla bla...etc");
        }
    }
}
