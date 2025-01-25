using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core.Interface.IServices;
using Microsoft.EntityFrameworkCore;


namespace Mahface.Services.AppServices.Service
{
    public class CoursesService : ICourseService
    {
        private readonly ICourseRipository _repository;
        private readonly ISeasonService _seasonService;
        private readonly IEpisodeService _sectionService;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IViewService _viewService;
        private readonly IImageService _imageService;
        private readonly ITeacherService _teacherService;
        public CoursesService(ICourseRipository repository, IMapper mapper, ISeasonService seasonService, IEpisodeService sectionService,
            IUserService userService, ICategoryService categoryService, IViewService viewService, IImageService imageService, ITeacherService teacherService)
        {
            _repository = repository;
            _mapper = mapper;
            _seasonService = seasonService;
            _sectionService = sectionService;
            _userService = userService;
            _categoryService = categoryService;
            _viewService = viewService;
            _imageService = imageService;
            _teacherService = teacherService;
        }

        // Get all courses
        public async Task<List<CourseDto>> GetAllCourses()
        {
            var courses = await _repository.GetAllCourses();
            var result = _mapper.Map<List<CourseDto>>(courses);
            foreach (var course in result)
            {
                var sumSeasons = _seasonService.GetAllCourseSeasons(course.Id).Count;
                var sumSection = await _sectionService.GetAllSectionsForCourse(course.Id);
                var userTeacher = await _userService.GetUserByTeacherId(course.TeacherId);
                var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                var category = await _categoryService.GetCategoryByIdAsync(course.CategoryId);
                course.TotalSeasons = sumSeasons;
                course.TotalSections = sumSection.Count();
                course.TotalDuration = 100;
                course.TeacherName = userTeacher.Firstname + " " + userTeacher.LastName;
                course.CategoryName=category.Title;
                course.TotalView= sumView == 0 ? 0 : sumView;

            }

            return result;
        }



        public async Task<List<CourseVm>> GetCoursesListAsync()
        {
            try
            {

                var courses = await _repository.NewGetAllCourses().ToListAsync();
                foreach (var course in courses)
                {
                    var sumSeasons = _seasonService.GetCourseSeasonsCount(course.Id);
                    var sumSection = _sectionService.GetEpisodeCountOfCourse(course.Id);
                    var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                    course.TotalSeasons = sumSeasons;
                    course.TotalSections = sumSection;
                    course.TotalDuration = 100;
                    course.TotalView= sumView == 0 ? 0 : sumView;

                }
                return courses; // به‌طور مستقیم نتیجه را برمی‌گردانیم
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }
        }



        public async Task<List<CourseVm>> GetAllCoursesWithFilterCategoryId(Guid categoryId)
        {
            try
            {

                var courses = await _repository.NewGetAllCourses().Where(c => c.CategoryId == categoryId).ToListAsync();
                foreach (var course in courses)
                {
                    var sumSeasons = _seasonService.GetCourseSeasonsCount(course.Id);
                    var sumSection = _sectionService.GetEpisodeCountOfCourse(course.Id);
                    var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                    course.TotalSeasons = sumSeasons;
                    course.TotalSections = sumSection;
                    course.TotalDuration = 100;
                    course.TotalView= sumView == 0 ? 0 : sumView;

                }
                return courses; // به‌طور مستقیم نتیجه را برمی‌گردانیم
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }

        }


        public async Task<List<NavVM>> GetAllCoursesTitleWithCategoryId(Guid categoryId)
        {
            try
            {

                var courses = await _repository.NewGetAllCourses().Where(c => c.CategoryId == categoryId).Select(x => new NavVM() { Id= x.Id, Title= x.Title }).ToListAsync();
                return courses;
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }

        }
        public async Task<List<CourseVm>> GetAllTeacherCourses(Guid userId)
        {
            try
            {
                var teacherId = (await _teacherService.GetTeacherByUSerId(userId))?.Id?? null;
                if (teacherId == null)
                {
                    return new List<CourseVm>();
                }
                var courses = await _repository.NewGetAllCourses().Where(c => c.TeacherId == teacherId).ToListAsync();
                foreach (var course in courses)
                {
                    var sumSeasons = _seasonService.GetCourseSeasonsCount(course.Id);
                    var sumSection = _sectionService.GetEpisodeCountOfCourse(course.Id);
                    var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                    course.TotalSeasons = sumSeasons;
                    course.TotalSections = sumSection;
                    course.TotalDuration = 100;
                    course.TotalView= sumView == 0 ? 0 : sumView;

                }
                return courses; // به‌طور مستقیم نتیجه را برمی‌گردانیم
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }

        }
        public async Task<List<CourseVm>> GetAllCoursesWithFilter(string Input)
        {
            try
            {


                var courses = await _repository.NewGetAllCourses().Where(c => EF.Functions.Like(c.Title, $"%{Input}%")).ToListAsync();
                foreach (var course in courses)
                {
                    var sumSeasons = _seasonService.GetCourseSeasonsCount(course.Id);
                    var sumSection = _sectionService.GetEpisodeCountOfCourse(course.Id);
                    var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                    course.TotalSeasons = sumSeasons;
                    course.TotalSections = sumSection;
                    course.TotalDuration = 100;
                    course.TotalView= sumView == 0 ? 0 : sumView;

                }
                return courses; // به‌طور مستقیم نتیجه را برمی‌گردانیم
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }
        }


        public async Task<CourseDetail> GetCourseById(Guid id)
        {
            // Fetch the course data from the repository
            var course = await _repository.GetCourseById(id);
            var userTeacher = await _userService.GetUserByTeacherId(course.TeacherId.Value);
            var category = await _categoryService.GetCategoryByIdAsync(course.CategoryId);
            if (course == null)
            {
                return null; // Or handle not found error appropriately
            }

            // Get the total number of seasons and sections for the course
            var sumSeasons = _seasonService.GetAllCourseSeasons(course.Id);
            var sumSection = await _sectionService.GetAllSectionsForCourse(course.Id);
            var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
            // Map the course entity to the CourseDto
            var result = _mapper.Map<CourseDto>(course);

            // Set total values
            result.TotalSeasons = sumSeasons.Count();
            result.TotalSections =sumSection.Count();
            result.TotalDuration = 100;////sumSection.Sum(s => s.Duration); // Assuming each section has a Duration field
            result.TotalView =sumView;
            result.CategoryName=category.Title;
            var courseDetail = _mapper.Map<CourseDetail>(result);
            courseDetail.TeacherName = userTeacher.Firstname + " " + userTeacher.LastName;
            // Set the seasons and their respective sections
            courseDetail.Seasons = sumSeasons.Select(season => new SeasonSVM
            {
                Id = season.Id.Value,
                Title = season.Title,
                SeasonsDescription = season.SeasonsDescription,
                CreatedAt=season.CreatedDate
            }).ToList();

            return courseDetail;
        }


        // Add a new course
        public async Task<AddStatusVm> AddCourse(AddCourseVm addCourse)
        {
            Courses courses = new();
            AddStatusVm addImageResult = new AddStatusVm() { IsValid= false };
            if (addCourse.ImageBase64 != null && addCourse.ImageBase64!="string" && addCourse.ImageBase64!="")
            {
                ImageDto image = new ImageDto();
                image.Url =addCourse.Title;
                image.Base64File= addCourse.ImageBase64;
                addImageResult = await _imageService.AddImage(image);
            }
            var teacher = await _teacherService.GetTeacherByUSerId(addCourse.CreatedUserID);
            if (teacher == null)
            {
                return new AddStatusVm
                {
                    IsValid =false,
                    StatusMessage="شما نقش استاد را  ندارید "
                };

            }
            courses.Id = new Guid();
            courses.Title = addCourse.Title;
            courses.CourseLevelId = addCourse.CourseLevelId;
            courses.TeacherId = teacher.Id;
            courses.CategoryId = addCourse.CategoryId;
            courses.CourseDescription = addCourse.CourseDescription;
            courses.Cost = addCourse.Cost; courses.ISActive = true;
            courses.ImageId = addImageResult.IsValid ? addImageResult.AddedId : null;
            courses.IsDeleted=false;
            courses.ISActive=true;
            courses.CreatedUserID=addCourse.CreatedUserID;
            courses.CreatedDate=DateTime.Now;


            var addResult = await _repository.AddCourse(courses);
            return addResult;

        }

        // Update an existing course
        public async Task<UpdateStatus> UpdateCourse(Guid id, AddCourseVm course)
        {
            try
            {
                var model = await _repository.GetCourseById(id);///// await GetCourseById(id);
                if (model==null)
                {

                    return new UpdateStatus
                    {
                        IsValid = false,
                        StatusMessage = "این دوره در سیستم پیدا نشد"
                    };
                }
                var teacher = await _teacherService.GetTeacherByUSerId(course.CreatedUserID);
                if (teacher != null)
                {
                    return new UpdateStatus
                    {
                        IsValid =false,
                        StatusMessage="شما نقش استاد را  ندارید "
                    };

                }
                model.Title = course.Title;
                model.TeacherId=teacher.Id;
                model.CategoryId=course.CategoryId;
                model.Description=course.CourseDescription;
                model.CategoryId= course.CategoryId;
                model.Cost=course.Cost;
                var x = model.Code;

                await _repository.UpdateCourse(model);
                return new UpdateStatus
                {
                    IsValid = true,
                    StatusMessage = "با موفقیت اپدیت شد"
                };
            }
            catch (Exception ex)
            {
                return new UpdateStatus
                {
                    IsValid = false,
                    StatusMessage = $"با مشکل مواجه شد : {ex.Message}"
                };
            }
        }

        // Delete a course
        public async Task<UpdateStatus> DeleteCourse(Guid id)
        {
            try
            {
                var model = await _repository.GetCourseById(id);///// await GetCourseById(id);
                if (model==null)
                {

                    return new UpdateStatus
                    {
                        IsValid = false,
                        StatusMessage = "این دوره در سیستم پیدا نشد"
                    };
                }

                var sections = (await _sectionService.GetAllSectionsForCourse(id));
                if (sections.Count() > 0)
                {
                    return new UpdateStatus
                    {
                        IsValid = false,
                        StatusMessage = "برای این دوره ویدئو بارگذاری شده است امکان حذف  وجود ندارد"
                    };
                }

                await _repository.DeleteCourse(id);
                return new UpdateStatus
                {
                    IsValid = true,
                    StatusMessage = "با موفقیت حذف شد "
                };
            }
            catch (Exception ex)
            {
                return new UpdateStatus
                {
                    IsValid = false,
                    StatusMessage = $"با مشکل مواجه شد: {ex.Message}"
                };
            }
        }

        public async Task<AddStatusVm> SeedCourses()
        {
             var courses = new List<Courses>
             {
               new Courses
               {
                   Id = Guid.Parse("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                   Title = "آموزش برنامه‌نویسی سی‌شارپ",
                   CourseLevelId = 1,
                   StarsNumber = 5,
                   TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                   CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                   CourseDescription = "دوره جامع و پروژه محور سی‌شارپ مناسب برای مبتدی تا پیشرفته.",
                   Cost = 1200000,
                   CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                   CreatedDate = DateTime.Now,
                   DeletedUserID = null,
                   DeletedDate = null,
                   ISActive = true,
                   IsDeleted = false
               },
               new Courses
               {
                   Id = Guid.Parse("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                   Title = "مدیریت مالی و سرمایه‌گذاری",
                   CourseLevelId = 2,
                   StarsNumber = 4,
                   TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                   CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // مالی و سرمایه‌گذاری
                   CourseDescription = "آشنایی با اصول مدیریت مالی و تکنیک‌های سرمایه‌گذاری در بازار.",
                   Cost = 1500000,
                   CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                   CreatedDate = DateTime.Now,
                   DeletedUserID = null,
                   DeletedDate = null,
                   ISActive = true,
                   IsDeleted = false
               },
               new Courses
               {
                   Id = Guid.Parse("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                   Title = "آموزش زبان  برای مبتدیان",
                   CourseLevelId = 1,
                   StarsNumber = 5,
                   TeacherId = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                   CategoryId = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"), // زبان‌های خارجی
                   CourseDescription = "دوره ویژه یادگیری زبان انگلیسی از سطح پایه با استفاده از روش‌های کاربردی.",
                   Cost = 800000,
                   CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                   CreatedDate = DateTime.Now,
                   DeletedUserID = null,
                   DeletedDate = null,
                   ISActive = true,
                   IsDeleted = false
               },
              new Courses
              {
                   Id = Guid.Parse("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                   Title = "مبانی هنر و طراحی",
                   CourseLevelId = 1,
                   StarsNumber = 4,
                   TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                   CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // هنر
                   CourseDescription = "آشنایی با اصول طراحی و نقاشی برای هنرجویان مبتدی.",
                  Cost = 900000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                  Title = "هوش مصنوعی و یادگیری ماشین",
                  CourseLevelId = 3,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), // آی‌تی و نرم‌افزار
                  CourseDescription = "دوره تخصصی برای یادگیری اصول هوش مصنوعی و پیاده‌سازی الگوریتم‌های یادگیری ماشین.",
                  Cost = 2000000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
               new Courses
              {
                  Id = Guid.Parse("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                  Title = "مبانی ریاضیات پایه",
                  CourseLevelId = 1,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // ریاضی
                  CourseDescription = "دوره‌ای مناسب برای آشنایی با اصول اولیه ریاضیات پایه و کاربردهای آن.",
                  Cost = 500000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                  Title = "فیزیک عمومی 1",
                  CourseLevelId = 1,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                  CategoryId = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"), // فیزیک
                  CourseDescription = "آشنایی با مفاهیم پایه‌ای فیزیک و حل مسائل کاربردی.",
                  Cost = 800000,
                  CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                  Title = "آمار و احتمالات مهندسی",
                  CourseLevelId = 2,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                  CategoryId = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), // مهندسی
                  CourseDescription = "یادگیری مفاهیم آمار و احتمالات برای حل مسائل مهندسی.",
                  Cost = 1000000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                  Title = "اصول بازاریابی دیجیتال",
                  CourseLevelId = 1,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // کسب‌وکار
                  CourseDescription = "آشنایی با اصول بازاریابی در دنیای دیجیتال و راه‌های جذب مشتری.",
                  Cost = 1500000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                  Title = "طراحی وب با HTML و CSS",
                  CourseLevelId = 1,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                  CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // طراحی وب
                  CourseDescription = "دوره‌ای جامع برای یادگیری طراحی صفحات وب با HTML و CSS.",
                  Cost = 1200000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                  Title = "برنامه‌نویسی پیشرفته با پایتون",
                  CourseLevelId = 2,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                  CourseDescription = "آموزش پیشرفته پایتون برای تحلیل داده، هوش مصنوعی و طراحی سیستم.",
                  Cost = 2000000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                  Title = "طراحی و مدل‌سازی  با Blender",
                  CourseLevelId = 2,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                  CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // طراحی گرافیکی
                  CourseDescription = "آشنایی با ابزارها و تکنیک‌های طراحی سه‌بعدی در نرم‌افزار Blender.",
                  Cost = 1800000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                  Title = "آموزش مقدماتی زبان جاوا",
                  CourseLevelId = 1,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                  CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                  CourseDescription = "آموزش مفاهیم اولیه برنامه‌نویسی با زبان جاوا برای مبتدیان.",
                  Cost = 900000,
                  CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                  Title = "اصول شبکه‌های کامپیوتری",
                  CourseLevelId = 1,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                  CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // شبکه
                  CourseDescription = "آشنایی با اصول پایه شبکه‌های کامپیوتری و پروتکل‌های ارتباطی.",
                  Cost = 1100000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                  Title = "تحلیل داده با SQL",
                  CourseLevelId = 2,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), // تحلیل داده
                  CourseDescription = "آموزش تحلیل داده‌های سازمانی با استفاده از زبان SQL.",
                  Cost = 1500000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                  Title = "یادگیری ماشین برای مبتدیان",
                  CourseLevelId = 1,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                  CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // هوش مصنوعی
                  CourseDescription = "آموزش مفاهیم پایه‌ای یادگیری ماشین و الگوریتم‌های آن.",
                  Cost = 2500000,
                  CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                  Title = "مبانی برق و الکترونیک",
                  CourseLevelId = 1,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                  CategoryId = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"), // برق و الکترونیک
                  CourseDescription = "یادگیری اصول پایه‌ای مدارهای الکترونیکی و کاربردهای آن‌ها.",
                  Cost = 800000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                  Title = "توسعه اپلیکیشن‌های موبایل با Flutter",
                  CourseLevelId = 2,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                  CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی موبایل
                  CourseDescription = "آموزش ساخت اپلیکیشن‌های موبایل برای اندروید و iOS با Flutter.",
                  Cost = 2200000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                  Title = "مدیریت پروژه‌های نرم‌افزاری",
                  CourseLevelId = 2,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // مدیریت پروژه
                  CourseDescription = "آشنایی با تکنیک‌ها و ابزارهای مدیریت پروژه‌های نرم‌افزاری.",
                  Cost = 1700000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                  Title = "طراحی رابط کاربری (UI)",
                  CourseLevelId = 1,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                  CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // طراحی UI
                  CourseDescription = "آموزش طراحی رابط کاربری زیبا و کاربردی با ابزارهای مدرن.",
                  Cost = 1200000,
                  CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                  Title = "توسعه وب ASP.NET Core",
                  CourseLevelId = 2,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                  CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // توسعه وب
                  CourseDescription = "آموزش ساخت برنامه‌های تحت وب بااستفاده از ASP.NETCore.",
                  Cost = 2500000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                  Title = "آموزش مقدماتی هوش مصنوعی",
                  CourseLevelId = 1,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // هوش مصنوعی
                  CourseDescription = "یادگیری اصول و تکنیک‌های پایه‌ای هوش مصنوعی.",
                  Cost = 1800000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                  Title = "برنامه‌نویسی شیءگرا با C#",
                  CourseLevelId = 2,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                  CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                  CourseDescription = "آموزش مفاهیم شیءگرایی و پیاده‌سازی آن با زبان C#.",
                  Cost = 2000000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              }
              };

            var result = await _repository.SeedData(courses);
            return result;  
        }
    }
}
