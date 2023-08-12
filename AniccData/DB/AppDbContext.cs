using AniccData.Models;
using Microsoft.EntityFrameworkCore;

namespace AniccData.DB
{
    public class AppDbContext : DbContext
    {
        //private IConfiguration Configuration { get; set; }

        public AppDbContext()
        {
            //Configuration = configuration;
        }

        public DbSet<StudentCSV> StudentsCSV { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False");
        }
    }
}
