using Models.Common.Student;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataBaseContext
{
    public class DataContext : DbContext
    {

        public DataContext() : base("Data Source=(local);Initial Catalog=PSSC;Integrated Security=SSPI")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ComplexType<RegistrationNumber>();
            modelBuilder.ComplexType<Credits>();
            modelBuilder.ComplexType<PlainText>();
        }

        public DbSet<Student> Student { get; set; }

    }
}
