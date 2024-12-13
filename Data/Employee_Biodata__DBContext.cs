using EmployeeBiodataMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBiodataMVC.Data
{
    public class Employee_Biodata__DBContext : DbContext
    {
        public Employee_Biodata__DBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee_Biodata> Employee_Biodata { get; set; }

    }
}
