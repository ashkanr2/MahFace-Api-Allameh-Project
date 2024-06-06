using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{

    public class CoursesRepository : ICourseripository
    {
        private readonly AllamehPrroject _context;

        public CoursesRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public async Task<Courses> GetCourseById(Guid id)
        {
            return await _context.Courses
                .Include(c => c.Image)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Courses>> GetAllCourses()
        {
            return await _context.Courses
                .Include(c => c.Image)
                .ToListAsync();
        }

        public async Task AddCourse(Courses course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCourse(Courses course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCourse(Guid id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }
        }
    }
}
