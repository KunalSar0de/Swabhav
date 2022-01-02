using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeptEmpApp.EF
{
    class AurionproContext:DbContext
    {
        public AurionproContext()
        {
            
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> employee { get; set; }
    }
    
}
