using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface ITeacherRepository
    {
        Task<AddStatusVm> CreateTeacher(Guid userId);
        Task<IEnumerable<Teacher>> GetAllActiveTeachers();
        Task<IEnumerable<Teacher>> GetAllInactiveTeachers();
        Task DeleteTeacher(Guid teacherId);
        Task<Teacher> GetTeacherById(Guid teacherId);  // Optional, add if needed
        Task UpdateTeacher(Teacher teacher);           // Add this method
    }

}
