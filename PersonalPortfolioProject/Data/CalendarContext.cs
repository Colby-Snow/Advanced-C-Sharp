using Microsoft.EntityFrameworkCore;
using PersonalPortfolioProject.Models;

namespace PersonalPortfolioProject.Data
{
    public class CalendarContext : DbContext
    {
        public CalendarContext(DbContextOptions<CalendarContext> options)
            : base(options)
        {
        }

        public DbSet<Calendar> Calendar { get; set; }
    }
}