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
            try
            {
                return await _context.Courses
                    .Include(c=>c.Image)
                  .FirstOrDefaultAsync(c => c.Id == id);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while getting course by id", ex);
            }
        }

        public async Task<IEnumerable<Courses>> GetAllCourses()
        {
            try
            {
                return await _context.Courses
                     .Include(c => c.Image)
                   .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while getting all courses", ex);
            }
        }

        public async Task AddCourse(Courses course)
        {
            try
            {
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                await Console.Out.WriteLineAsync(ex.ToString());
                throw new Exception("Error occurred while adding course", ex);
            }
        }

        public async Task UpdateCourse(Courses course)
        {
            try
            {
                _context.Courses.Update(course);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while updating course", ex);
            }
        }

        public async Task DeleteCourse(Guid id)
        {
            try
            {
                var course = await _context.Courses.FindAsync(id);
                if (course != null)
                {
                    _context.Courses.Remove(course);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while deleting course", ex);
            }
        }
    }
}
