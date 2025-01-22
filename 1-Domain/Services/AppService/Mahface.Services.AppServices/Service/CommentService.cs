using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Course;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICourseRipository _courseRipository;
        public CommentService(ICommentRepository commentRepository, IUserRepository userRepository, ICourseRipository courseRipository)
        {
            _commentRepository = commentRepository;
            _userRepository = userRepository;
           _courseRipository=courseRipository;
        }

        public async Task<CommentDto> GetById(Guid id)
        {
            try
            {
                var comment = await _commentRepository.GetById(id);
                if (comment == null) throw new Exception("نظر پیدا نشد.");

                var user = await _userRepository.GetUserByIdAsync(comment.CreatedUserID);
                return new CommentDto
                {
                    Id = comment.Id,
                    Text = comment.Description,
                    UserFirstName = user.Firstname,
                    UserLastName = user.LastName,
                    CreatedDate = comment.CreatedDate
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"خطا در دریافت نظر: {ex.Message}");
            }
        }

        public async Task<List<CommentDto>> GetAllUsersComments(Guid userId)
        {
            try
            {
                var comments = await _commentRepository.GetAllUsersComments(userId);

                var commentDtos = new List<CommentDto>();
                foreach (var comment in comments)
                {
                    var user = await _userRepository.GetUserByIdAsync(comment.CreatedUserID);
                    if (user == null)
                        throw new Exception("کاربر مورد نظر پیدا نشد.");

                    commentDtos.Add(new CommentDto
                    {
                        Id = comment.Id,
                        Text = comment.Text,
                        UserFirstName = user.Firstname, // Ensure correct property name
                        UserLastName = user.LastName,
                        CreatedDate = comment.CreatedDate
                    });
                }

                return commentDtos;
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
                return await _commentRepository.GetAllCourseComments(courseId);
            }
            catch (Exception ex)
            {
                throw new Exception($"خطا در دریافت نظرات دوره: {ex.Message}");
            }
        }

        public async Task<AddStatusVm> AddComment(AddCommentVm addCommentVm)
        {
            try
            {
                // Validate if the user exists
                var user = await _userRepository.GetUserByIdAsync(addCommentVm.UserId);
                if (user == null)
                    return new AddStatusVm
                    {
                        IsValid = false,
                        StatusMessage = "کاربر مورد نظر یافت نشد."
                    };

                // Create the Comment object
                var comment = new Comment
                {
                    Id = Guid.NewGuid(),
                    CreatedUserID = addCommentVm.UserId,
                    CourseId=addCommentVm.CourseId, 
                    UserId=addCommentVm.UserId,
                    CreatedDate = DateTime.Now,
                    Text = addCommentVm.Text,
                    ISActive = true,
                    IsDeleted = false,
                    Code = 0, 
                };

                // Add comment through repository
                return await _commentRepository.AddComment(comment);
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطا در افزودن نظر: {ex.Message}"
                };
            }
        }

        public async Task<UpdateStatus> UpdateComment(Comment comment)
        {
            try
            {
                return await _commentRepository.UpdateComment(comment);
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
                return await _commentRepository.DeleteComment(id);
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

        public async Task<AddStatusVm> SeedComments()
        {
            try
            {
                 
                var courses =  _courseRipository.NewGetAllCourses().Select(x=>x.Id).ToList();
                var users = await _userRepository.GetAllUsersAsync();
                var comments = new List<Comment>();

               
                var persianComments = new List<string>
                {
                    "این دوره خیلی عالی بود و من خیلی چیز یاد گرفتم.",
                    "ممنون از توضیحات خوب و کامل استاد.",
                    "مطالب کاملا کاربردی و جذاب بود.",
                    "کیفیت دوره خیلی خوب بود، پیشنهاد می‌کنم.",
                    "روش تدریس استاد خیلی حرفه‌ای و ساده بود.",
                    "پشتیبانی دوره واقعا عالی بود و خیلی سریع پاسخ می‌دادند.",
                    "خیلی ممنون از تیم آموزشی برای برگزاری این دوره مفید.",
                    "جزوه‌ها و تمرینات دوره بسیار کامل بودند.",
                    "برای افرادی که تازه می‌خواهند شروع کنند، این دوره فوق‌العاده است.",
                    "دوره به‌روز و مطابق با تکنولوژی‌های جدید تدریس شد.",
                    "محیط یادگیری خیلی دوستانه و خوب بود.",
                    "کیفیت ویدیوهای آموزشی بسیار بالا بود.",
                    "توضیحات استاد واضح و دقیق بود و هیچ ابهامی باقی نمی‌گذاشت.",
                    "این دوره یکی از بهترین دوره‌هایی بود که شرکت کردم.",
                    "نحوه ارائه مطالب به صورت گام به گام بسیار عالی بود.",
                    "پروژه‌های عملی دوره خیلی کمک کرد مطالب را بهتر یاد بگیرم.",
                    "تمرین‌های زیادی برای یادگیری بهتر در نظر گرفته شده بود.",
                    "دوره جامع و کاملی بود و تمام موضوعات مرتبط را پوشش می‌داد.",
                    "از تمام تیم آموزشی بابت این دوره ارزشمند تشکر می‌کنم.",
                    "سطح دوره خیلی خوب بود و برای همه قابل فهم بود.",
                    "ساختار دوره خیلی حرفه‌ای و برنامه‌ریزی شده بود.",
                    "بعد از این دوره توانستم در شغلم پیشرفت کنم.",
                    "به نظرم این دوره برای هر کسی که دنبال یادگیری حرفه‌ای است، لازم است.",
                    "درس‌های کاربردی زیادی در این دوره ارائه شد.",
                    "پیشنهاد می‌کنم حتماً این دوره را بگذرانید."
                };



                var userIds = new List<Guid>
                {
                    Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                    Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                    Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                    Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Guid.Parse("e2caf058-47c5-4c10-3fc6-08dd1604c009"),
                    Guid.Parse("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                    Guid.Parse("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                    Guid.Parse("9f5dac63-d870-4424-7166-08dd2064841e"),
                    Guid.Parse("b373c277-e096-465f-a7e2-08dd33ff4451"),
                    Guid.Parse("c13acae2-6d50-47cf-f711-08dd347f841d"),
                    Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966")
                };

                var random = new Random();

                foreach (var course in courses)
                {
                    foreach (var commentText in persianComments)
                    {
                        var randomUserId = userIds[random.Next(userIds.Count)];

                        comments.Add(new Comment
                        {
                            Id = Guid.NewGuid(),
                            CreatedUserID = randomUserId, // استفاده از ایدی تصادفی
                            CourseId = course,
                            CreatedDate = DateTime.UtcNow,
                            Text = commentText,
                            ISActive = true,
                            IsDeleted = false,
                            Code = 0,
                            UserId = randomUserId,
                        });
                    }
                }

                var result = await _commentRepository.SeedData(comments);

                return result;
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطا در تولید نظرات: {ex.Message}",
                    AddedId = null
                };
            }
        }



    }

}
