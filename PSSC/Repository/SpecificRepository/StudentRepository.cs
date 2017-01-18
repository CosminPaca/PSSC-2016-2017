using Models.Common.Student;
using Repository.DataBaseContext;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SpecificRepository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {

        public StudentRepository(DataContext context)
            : base(context)
        {
        }

        public DataContext PlutoContext
        {
            get { return Context as DataContext; }
        }

    }
}
