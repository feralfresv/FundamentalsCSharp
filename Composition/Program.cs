﻿using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigration = new DBMigration(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigration.Migrate();
            installer.Install();
        }
    }
}
