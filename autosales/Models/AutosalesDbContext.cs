using Microsoft.EntityFrameworkCore;

namespace autosales.Models
{
    public partial class AutosalesDbContext : DbContext
    {
        public AutosalesDbContext()
        {

        }
        public AutosalesDbContext(DbContextOptions<AutosalesDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //to do: get connection string from json file
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = autosalesdb; Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // to set setting of dbsets
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
