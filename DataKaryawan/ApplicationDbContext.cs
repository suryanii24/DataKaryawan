using DataKaryawan.Models.DataKaryawan;
using Microsoft.EntityFrameworkCore;

namespace DataKaryawan
{
    public class ApplicationDbContext : DbContext
    {       
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }
            public DbSet<EmployeeUnit> EmployeeUnits { get; set; }
            public DbSet<EmployeePosition> EmployeePositions { get; set; }        
    }
}
