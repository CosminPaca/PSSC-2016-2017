using Models.Common.Student;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SpecificRepository
{
    public interface IStudentRepository : IRepository<Student>
    {

    }
}
