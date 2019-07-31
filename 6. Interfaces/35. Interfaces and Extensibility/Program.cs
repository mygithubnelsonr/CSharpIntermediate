using System;

namespace Interfaces_and_Extensibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("DbMigration.log"));
            dbMigrator.Migrate();



            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
