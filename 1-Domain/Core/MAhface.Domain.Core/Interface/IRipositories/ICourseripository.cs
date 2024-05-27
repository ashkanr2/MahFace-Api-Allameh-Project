using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Interface.IRipositories
{
    public interface ICourseripository
    {
        public List<Courses> GetAll();

        public Courses GetById(Guid Id);

        public string Update(Courses course);

        public string Create(Courses course);


    }
}
