using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.Study;
public interface ITeacherService
{
    Task<TeacherDto> CreateTeacher(Guid userId);
    Task<IEnumerable<TeacherDto>> GetAllActiveTeachers();
    Task<IEnumerable<TeacherDto>> GetAllInactiveTeachers();
    Task<TeacherDto> GetTeacherById(Guid teacherId);
    Task DeleteTeacher(Guid teacherId);
    Task UpdateTeacher(TeacherDto teacherDto);
    Task<TeacherDto> GetTeacherByUSerId(Guid userId);
}
