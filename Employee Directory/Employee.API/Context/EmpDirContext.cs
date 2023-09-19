using Microsoft.EntityFrameworkCore;
using SharedLibrary.Domain;

namespace EmployeeAPI.Context
{
    public class EmpDirContext: DbContext
    {
        public EmpDirContext(DbContextOptions<EmpDirContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }  
    }
}
