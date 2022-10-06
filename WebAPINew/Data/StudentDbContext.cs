using Microsoft.EntityFrameworkCore;
using WebAPINew.Models;

namespace WebAPINew.Data
{

    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Studentinfo> Students{ get; set; }
    }
}
