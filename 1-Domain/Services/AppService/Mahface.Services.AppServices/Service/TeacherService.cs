using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
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
    public async Task<AddStatusVm> CreateTeacher(Guid userId)
    {
        AddStatusVm vm = new AddStatusVm();
        var result = await _teacherRepository.CreateTeacher(userId);
        return result;
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

    public async Task<AddStatusVm> SeedTeachers()
    {
        
            var teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                    UserId = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                    Description = null,
                    CreatedUserID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Teacher
                {
                    Id = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                    UserId = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                    Description = null,
                    CreatedUserID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Teacher
                {
                    Id = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                    UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Description = null,
                    CreatedUserID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Teacher
                {
                    Id = Guid.Parse("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                    UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Description = null,
                    CreatedUserID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Teacher
                {
                    Id = Guid.Parse("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                    UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Description = null,
                    CreatedUserID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Teacher
                {
                    Id = Guid.Parse("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                    UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Description = null,
                    CreatedUserID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Teacher
                {
                    Id = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                    UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Description = null,
                    CreatedUserID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                }
            };

            var result = await _teacherRepository.SeedData(teachers);
            return result;  
       
    }
}
