using System.Data.Entity;

namespace CountryApp
{ 
    class CountryDBContext:DbContext
    {
        public CountryDBContext(): base("DbConntectionString")
        {}

        public DbSet<City> cities { get; set; }
        public DbSet<Region> regions { get; set; }
        public DbSet<CountryDb> countries { get; set; }
    }
}
