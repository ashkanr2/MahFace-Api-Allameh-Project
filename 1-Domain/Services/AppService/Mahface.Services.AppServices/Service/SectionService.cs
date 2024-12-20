﻿using AutoMapper;
using MAhface.Domain.Core.Entities.Study.Section;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;

        public SectionService(ISectionRepository sectionRepository, IMapper mapper)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }

        // Create a new section
        public async Task<AddStatusVm> CreateSection(CreateSectionRequest request)
        {
            var vm = new AddStatusVm();

            try
            {
                // Get the count of videos (sections) for this course and season
                var videoCount = await _sectionRepository.GetVideoCountForCourse(request.CourseId, request.SeasionId);

                // If title is null, generate it based on the video count
                var title = request.Title ?? $"قسمت {videoCount + 1}"; // Set title like 'قسمت اول', 'قسمت دوم', etc.

                var section = new Sections
                {
                    Id = Guid.NewGuid(),
                    CourseId = request.CourseId,
                    SeasionId = request.SeasionId,
                    Title = title,
                    CreatedUserID = request.CreatedUserId,
                    CreatedDate = DateTime.UtcNow,
                    ISActive = true,
                    IsDeleted = false,
                    Code = videoCount + 1, // This will give the video order
                };

                // Save section in database
                var createdSection = await _sectionRepository.CreateAsync(section);

                // Return status and section ID
                vm.IsValid = true;
                vm.AddedId = createdSection.Id;
                vm.StatusMessage = "Section created successfully!";
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
                    vm.StatusMessage = "Section not found!";
                    return vm;
                }

                // Update the properties
                section.SeasionId = request.SeasionId.Value;
                section.CourseLevel = request.CourseLevel.Value;
                section.Title = request.Title ?? section.Title;

                // Save the updated section
                await _sectionRepository.UpdateAsync(section);

                vm.IsValid = true;
                vm.StatusMessage = "Section updated successfully!";
            }
            catch (Exception ex)
            {
                vm.IsValid = false;
                vm.StatusMessage = $"Error: {ex.Message}";
            }

            return vm;
        }

        // Get section details
        public async Task<SectionDto> GetSectionDetails(Guid sectionId)
        {
            var section = await _sectionRepository.GetByIdAsync(sectionId);

            if (section == null)
            {
                return null;
            }

            // Map to SectionDto to return to the client
            return _mapper.Map<SectionDto>(section);
        }

        public async Task<IEnumerable<SectionDto>> GetAllSectionsForCourse(Guid id)
        {
            var allData = await _sectionRepository.GetAll(); // Get all sections
            var sections = allData.Where(x => x.CourseId == id).ToList(); // Filter sections by CourseId

            // Map sections to SectionDto and return as Task
            return await Task.FromResult(_mapper.Map<IEnumerable<SectionDto>>(sections));
        }

    }


}
