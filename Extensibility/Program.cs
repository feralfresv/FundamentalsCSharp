using System;

namespace Extensibility
{
    class Program
    {    
        static void Main(string[] args)
        {
            var migration = new Migration(new ConsoleLogger());
            migration.Migrate();

            var migration2 = new Migration(new FileLogger("C:/dev/FundamentalsCSharp/Extensibility/log.txt"));
            migration2.Migrate();
        }
    }
}
