using OgrenciTakipYazilim.Data.Contexts;
using System.Data.Entity.Migrations;

namespace OgrenciTakipYazilim.Data.Migrations
{
    public class Configuration : DbMigrationsConfiguration<OgrenciTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
