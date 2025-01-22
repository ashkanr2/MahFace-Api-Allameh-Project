using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface ICommentRepository
    {

        Task<Comment> GetById(Guid id);
        Task<List<Comment>> GetAllUsersComments(Guid userId);
        Task<List<CommentDto>> GetAllCourseComments(Guid courseId);
        Task<AddStatusVm> AddComment(Comment comment);
        Task<UpdateStatus> UpdateComment(Comment comment);
        Task<UpdateStatus> DeleteComment(Guid id);
        Task<AddStatusVm> SeedData(List<Comment> comments);


    }
}
