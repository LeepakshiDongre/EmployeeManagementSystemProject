using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystemProject.Models;  // Make sure this matches your actual namespace

namespace EmployeeManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}