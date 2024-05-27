
using MAhface.Domain.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Interface.IServices
{
    public interface ICourseService
    {
        public List<CourseDto> GetAll();

        public CourseDto GetById(Guid Id);

        public string Update(CourseDto course);

        public string Create(CourseDto course);

        public string IsDeleted(Guid Id);

        public List<CourseDto> GetByCategoryId(Guid categoryId);

        public List<CourseDto> GetByTeacherId(Guid teacherId);

        public List<CourseDto> GetStudentId(Guid studentId);


    }
}
