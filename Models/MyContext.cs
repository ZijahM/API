using Microsoft.EntityFrameworkCore;

namespace myAPI.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<User> Users { get; set;}
        public DbSet<Student> Students { get; set;}

    }
}
