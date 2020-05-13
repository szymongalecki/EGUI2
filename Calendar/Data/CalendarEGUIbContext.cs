using Microsoft.EntityFrameworkCore;
using CalendarEGUIc1.Models;

namespace CalendarEGUIc1.Data
{
    public class CalendarEGUIbContext : DbContext
    {

        public CalendarEGUIbContext(DbContextOptions<CalendarEGUIbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; }
    }
}