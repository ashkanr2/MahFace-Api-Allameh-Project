using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{

    public class CoursesRepository : ICourseRipository
    {
        private readonly AllamehPrroject _context;

        public CoursesRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public async Task<List<Courses>> GetAllCourses()
        {
            return await _context.Courses
                .Include(c => c.Teacher)
                .Include(c => c.category)
                .Include(c => c.Seasons)
                .ThenInclude(s => s.Sections)
                .Include(c => c.Image)
                .ToListAsync();
        }

        public async Task<Courses> GetCourseById(Guid id)
        {
            return await _context.Courses
                .Include(c => c.Teacher)
                .Include(c => c.category)
                .Include(c => c.Seasons)
                    .ThenInclude(s => s.Sections)
                .Include(c => c.Image)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddCourse(Courses course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCourse(Courses course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourse(Guid id)
        {
            var course = await GetCourseById(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }
        }
    }

}
