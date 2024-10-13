using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Interface.IRipositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _teacherRepository;

    public TeacherService(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    // Convert Teacher Entity to TeacherDto
    private TeacherDto MapToDto(Teacher teacher)
    {
        return new TeacherDto
        {
            Id = teacher.Id,
            UserId = teacher.UserId,
            UserName = teacher.User.UserName,  // Assuming User has a UserName property
            IsActive = teacher.ISActive,
            Description = teacher.Description,
            CreatedDate = teacher.CreatedDate
        };
    }

    // Convert TeacherDto to Teacher Entity
    private Teacher MapToEntity(TeacherDto teacherDto)
    {
        return new Teacher
        {
            Id = teacherDto.Id,
            UserId = teacherDto.UserId,
            ISActive = teacherDto.IsActive,
            Description = teacherDto.Description,
            CreatedDate = teacherDto.CreatedDate
        };
    }

    // Create a new teacher (uses repository)
    public async Task<TeacherDto> CreateTeacher(Guid userId)
    {
        var teacher = await _teacherRepository.CreateTeacher(userId);
        return MapToDto(teacher);
    }

    // Get all active teachers
    public async Task<IEnumerable<TeacherDto>> GetAllActiveTeachers()
    {
        var teachers = await _teacherRepository.GetAllActiveTeachers();
        return teachers.Select(t => MapToDto(t));
    }

    // Get all inactive teachers
    public async Task<IEnumerable<TeacherDto>> GetAllInactiveTeachers()
    {
        var teachers = await _teacherRepository.GetAllInactiveTeachers();
        return teachers.Select(t => MapToDto(t));
    }

    // Get a specific teacher by ID
    public async Task<TeacherDto> GetTeacherById(Guid teacherId)
    {
        var teachers = await _teacherRepository.GetAllActiveTeachers();
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        return teacher != null ? MapToDto(teacher) : null;
    }

    // Delete a teacher
    public async Task DeleteTeacher(Guid teacherId)
    {
        await _teacherRepository.DeleteTeacher(teacherId);
    }

    // Update a teacher
    public async Task UpdateTeacher(TeacherDto teacherDto)
    {
        var teacherEntity = MapToEntity(teacherDto);
        await _teacherRepository.UpdateTeacher(teacherEntity);
    }

    public async Task<TeacherDto> GetTeacherByUSerId(Guid userId)
    {
        var teachers = await _teacherRepository.GetAllActiveTeachers();
        var teacher = teachers.FirstOrDefault(t => t.UserId==userId);
        return teacher != null ? MapToDto(teacher) : null;
    }
}
