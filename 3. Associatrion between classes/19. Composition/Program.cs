using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            // using a functionality of a seperate class
            // in two different other class using composition
            var logger = new Logger();

            var migrator = new DbMigrator(logger);
            migrator.Migrate();

            var installer = new Installer(logger);
            installer.Install();


            Console.ReadKey();
        }
    }
}
