using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface ICommentService
    {
        Task<CommentDto> GetById(Guid id);
        Task<List<CommentDto>> GetAllUsersComments(Guid userId);
        Task<List<CommentDto>> GetAllCourseComments(Guid courseId);
        Task<AddStatusVm> AddComment(AddCommentVm addCommentVm);
        Task<UpdateStatus> UpdateComment(Comment comment);
        Task<UpdateStatus> DeleteComment(Guid id);
        Task<AddStatusVm> SeedComments();
    }
}
