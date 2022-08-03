namespace challenge.Database
{
    using Microsoft.EntityFrameworkCore;

    public class ChallengeDbContext : DbContext
    {
        public ChallengeDbContext()
        {
        }

        public ChallengeDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("datasource=challenge.db");
        }

        public virtual DbSet<NoteDbModel> Notes { get; set; } = null;
    }
}
