using AniccData.Models;
using Microsoft.EntityFrameworkCore;

namespace AniccData.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<StudentCSV> StudentsCSV { get; set; }

        private IConfiguration Configuration { get; set; }

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.Configuration.GetConnectionString("StudentDB"));
        }
    }
}
