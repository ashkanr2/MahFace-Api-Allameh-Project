using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Course;
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
    public class CommentRepository : ICommentRepository
    {
        private readonly AllamehPrroject _context;

        public CommentRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public async Task<Comment> GetById(Guid id)
        {
            try
            {
                var comment = await _context.Comments.FindAsync(id);
                if (comment == null)
                    throw new Exception("نظر پیدا نشد.");
                return comment;
            }
            catch (Exception ex)
            {
                throw new Exception($"خطا در دریافت نظر: {ex.Message}");
            }
        }

        public async Task<List<Comment>> GetAllUsersComments(Guid userId)
        {
            try
            {
                return await _context.Comments
                                     .Where(c => c.CreatedUserID == userId && !c.IsDeleted)
                                     .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"خطا در دریافت نظرات کاربر: {ex.Message}");
            }
        }

        public async Task<List<CommentDto>> GetAllCourseComments(Guid courseId)
        {
            try
            {
                return await _context.Comments
                                     .Where(c=>c.CourseId==courseId && !c.IsDeleted)
                                     .Select(c => new CommentDto
                                     {
                                         Id = c.Id,
                                         Text = c.Text,
                                         CreatedDate = c.CreatedDate,
                                         UserFirstName = _context.Users.FirstOrDefault(u => u.Id == c.CreatedUserID).Firstname,
                                         UserLastName = _context.Users.FirstOrDefault(u => u.Id == c.CreatedUserID).LastName
                                     })
                                     .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"خطا در دریافت نظرات دوره: {ex.Message}");
            }
        }

        public async Task<AddStatusVm> AddComment(Comment comment)
        {
            try
            {
                _context.Comments.Add(comment);
                await _context.SaveChangesAsync();

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "نظر با موفقیت افزوده شد.",
                    AddedId = comment.Id
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطا در ذخیره نظر: {ex.Message}"
                };
            }
        }


        public async Task<UpdateStatus> UpdateComment(Comment comment)
        {
            try
            {
                var existingComment = await GetById(comment.Id);
                if (existingComment == null)
                    throw new Exception("نظر مورد نظر برای به‌روزرسانی پیدا نشد.");

                existingComment.Description = comment.Description;
                existingComment.ISActive = comment.ISActive;

                _context.Comments.Update(existingComment);
                await _context.SaveChangesAsync();

                return new UpdateStatus
                {
                    IsValid = true,
                    StatusMessage = "نظر با موفقیت به‌روزرسانی شد."
                };
            }
            catch (Exception ex)
            {
                return new UpdateStatus
                {
                    IsValid = false,
                    StatusMessage = $"خطا در به‌روزرسانی نظر: {ex.Message}"
                };
            }
        }

        public async Task<UpdateStatus> DeleteComment(Guid id)
        {
            try
            {
                var comment = await GetById(id);
                if (comment == null)
                    throw new Exception("نظر مورد نظر برای حذف پیدا نشد.");

                comment.IsDeleted = true;
                comment.DeletedDate = DateTime.UtcNow;

                _context.Comments.Update(comment);
                await _context.SaveChangesAsync();

                return new UpdateStatus
                {
                    IsValid = true,
                    StatusMessage = "نظر با موفقیت حذف شد."
                };
            }
            catch (Exception ex)
            {
                return new UpdateStatus
                {
                    IsValid = false,
                    StatusMessage = $"خطا در حذف نظر: {ex.Message}"
                };
            }
        }

        public async Task<AddStatusVm> SeedData(List<Comment> comments)
        {
            try
            {
                // Add comments to the database
                await _context.Comments.AddRangeAsync(comments);
                await _context.SaveChangesAsync();

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "نظرات با موفقیت اضافه شدند.",
                    AddedId = null
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطا در افزودن نظرات: {ex.Message}",
                    AddedId = null
                };
            }
        }

    }

}
