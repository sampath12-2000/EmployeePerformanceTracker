using Microsoft.EntityFrameworkCore;

namespace EmployeePerformanceTracker.Models
{
    public class EPTDBContext:DbContext
    {
        public EPTDBContext(DbContextOptions<EPTDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
