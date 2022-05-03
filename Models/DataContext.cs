using Microsoft.EntityFrameworkCore;

namespace dotnet_Web_API_Tutorial.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Character> Characters {get; set;}
    }
}