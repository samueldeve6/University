using Microsoft.EntityFrameworkCore;
using UniversityApiBakend.Models.DataModels;


namespace UniversityApiBakend.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }

        //TO DO: Add DbSets (Tables of out Data Base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student> Students { get; set; }
         

    } 
}
