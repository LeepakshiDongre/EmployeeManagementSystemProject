using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystemProject.Models;

namespace EmployeeManagementSystemProject.Data
{
    public class EmployeeManagementSystemProjectContext : DbContext
    {
        public EmployeeManagementSystemProjectContext (DbContextOptions<EmployeeManagementSystemProjectContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagementSystemProject.Models.Employee> Employee { get; set; } = default!;
    }
}
