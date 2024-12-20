﻿using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Interface.IRipositories
{
    public interface ICourseRipository
    {
        Task<List<Courses>> GetAllCourses();
        Task<Courses> GetCourseById(Guid id);
        Task AddCourse(Courses course);
        Task UpdateCourse(Courses course);
        Task DeleteCourse(Guid id);
    }

}
