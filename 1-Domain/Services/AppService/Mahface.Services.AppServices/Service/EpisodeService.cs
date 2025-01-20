using AutoMapper;

using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using Microsoft.VisualBasic;
using Microsoft.IdentityModel.Tokens;
using MAhface.Domain.Core1.Entities.Study.Episode;
using MAhface.Domain.Core.Entities.Study.Season;



namespace Mahface.Services.AppServices.Service
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IEpisodeRepository _sectionRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly HttpClient _httpClient;
        private readonly ISeasonService _seasonService;

        public EpisodeService(IEpisodeRepository sectionRepository, IMapper mapper, IWebHostEnvironment webHostEnvironment, HttpClient httpClient , ISeasonService seasonService)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            _httpClient=httpClient;
            _seasonService = seasonService;
        }

        // Create a new section
        public async Task<AddStatusVm> CreateSection(CreateSectionRequest request)
        {
            var vm = new AddStatusVm();

            try
            {
                //var validURL = await ValidateVideoUrlAsync(request.URL);
                //if (!validURL)
                //{
                //    vm.IsValid = false;
                //    vm.StatusMessage = "آدرس ویدئو معتبر نمی باشد ";
                //    return vm;
                //}
                // Get the count of videos (sections) for this course and season

               var season = _seasonService.GetById(request.SeasionId);
                if (season == null)
                {
                    vm.IsValid = false;
                    vm.StatusMessage = "SeasonId  به درستی  پر نشده است  ";
                    return vm;
                }
                var videoCount = await _sectionRepository.GetVideoCountForCourse(season.CourseId, request.SeasionId);

                // If title is null, generate it based on the video count
                var title = request.Title ?? $"قسمت {videoCount + 1}"; // Set title like 'قسمت اول', 'قسمت دوم', etc.

                var section = new Episode
                {
                    Id = Guid.NewGuid(),
                    CourseId = season.CourseId,
                    SeasonId = request.SeasionId,
                    Title = title,
                    URL=request.URL,
                   };

                // Save section in database
                var createdSection = await _sectionRepository.CreateAsync(section);

                // Return status and section ID
                vm.IsValid = true;
                vm.AddedId = createdSection.Id;
                vm.StatusMessage = "با موفقیت اضافه شد ";
            }
            catch (Exception ex)
            {
                vm.IsValid = false;
                vm.StatusMessage = $"Error: {ex.Message}";
            }

            return vm;
        }

        // Update section
        public async Task<UpdateStatus> UpdateSection(Guid sectionId, UpdateSectionRequest request)
        {
            var vm = new UpdateStatus();

            try
            {
                // Get the existing section
                var section = await _sectionRepository.GetByIdAsync(sectionId);

                if (section == null)
                {
                    vm.IsValid = false;
                    vm.StatusMessage = "این قسمت پیدا نشد ";
                    return vm;
                }

                // Update the properties
                section.SeasonId = request.SeasionId.Value;
                section.Title = request.Title ?? section.Title;

                // Save the updated section
                await _sectionRepository.UpdateAsync(section);

                vm.IsValid = true;
                vm.StatusMessage = "با موفققیت اپدیت شد";
            }
            catch (Exception ex)
            {
                vm.IsValid = false;
                vm.StatusMessage = $"Error: {ex.Message}";
            }

            return vm;
        }

        // Get section details
        public async Task<EpisodeDto> GetSectionDetails(Guid sectionId)
        {
            var section = await _sectionRepository.GetByIdAsync(sectionId);

            if (section == null)
            {
                return null;
            }

            // Map to SectionDto to return to the client
            return _mapper.Map<EpisodeDto>(section);
        }

        public async Task<IEnumerable<EpisodeDto>> GetAllSectionsForCourse(Guid id)
        {
            var allData = await _sectionRepository.GetAll(); // Get all sections
            var sections = allData.Where(x => x.CourseId == id).ToList(); // Filter sections by CourseId

            // Map sections to SectionDto and return as Task
            return await Task.FromResult(_mapper.Map<IEnumerable<EpisodeDto>>(sections));
        }

        // متد آپلود ویدیو
        public async Task<AddStatusVm> UploadVideo(Guid sectionId, IFormFile videoFile)
        {
            var vm = new AddStatusVm();

            try
            {
                // بررسی اینکه ویدیو وجود دارد
                if (videoFile == null || videoFile.Length == 0)
                {
                    vm.IsValid = false;
                    vm.StatusMessage = "No video file provided.";
                    return vm;
                }

                // گرفتن مسیر پروژه برای ذخیره ویدیو
                var videoFolderPath = Path.Combine(_webHostEnvironment.WebRootPath, "videos"); // پوشه 'videos' در پروژه
                if (!Directory.Exists(videoFolderPath))
                {
                    Directory.CreateDirectory(videoFolderPath); // اگر پوشه وجود ندارد، آن را ایجاد می‌کنیم
                }

                // ایجاد نام یکتا برای فایل
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(videoFile.FileName)}";
                var filePath = Path.Combine(videoFolderPath, fileName);

                // ذخیره فایل ویدیو
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await videoFile.CopyToAsync(fileStream);
                }

                // به‌روزرسانی مدل سکشن با مسیر ویدیو
                var section = await _sectionRepository.GetByIdAsync(sectionId);
                if (section == null)
                {
                    vm.IsValid = false;
                    vm.StatusMessage = "Section not found!";
                    return vm;
                }

                // ایجاد HashUrl از فایل ویدیو
                section.URL = $"videos/{fileName}"; // مسیر ذخیره ویدیو

                // بروزرسانی سکشن با HashUrl جدید
                await _sectionRepository.UpdateAsync(section);

                // برگرداندن پاسخ
                vm.IsValid = true;
                vm.StatusMessage = "Video uploaded and section updated successfully!";
                vm.AddedId = section.Id;
            }
            catch (Exception ex)
            {
                vm.IsValid = false;
                vm.StatusMessage = $"Error: {ex.Message}";
            }

            return vm;
        }

        public async Task<bool> ValidateVideoUrlAsync(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;
            try
            {
                // بررسی اینکه URL معتبر و کامل باشد
                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    return false;

                using var httpClient = new HttpClient();

                // ارسال درخواست HEAD برای بررسی محتوا
                var request = new HttpRequestMessage(HttpMethod.Head, url);
                var response = await httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                    return false;

                // بررسی Content-Type
                var contentType = response.Content.Headers.ContentType?.MediaType;
                if (!string.IsNullOrEmpty(contentType) && contentType.StartsWith("videos/", StringComparison.OrdinalIgnoreCase))
                    return true;
                if (!contentType.IsNullOrEmpty() && contentType.Contains("binary/octet-stream"))
                    return true;


                return false;
            }
            catch
            {
                return false; // در صورت بروز خطا، URL نامعتبر تلقی می‌شود
            }
        }

        private string NormalizeUrl(string url)
        {
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "https://" + url; // Default to https
            }
            return url;
        }

        public int GetEpisodeCountOfCourse(Guid courseId)
        {
          return _sectionRepository.GetEpisodeCountOfCourse(courseId);
        }
    }


}
