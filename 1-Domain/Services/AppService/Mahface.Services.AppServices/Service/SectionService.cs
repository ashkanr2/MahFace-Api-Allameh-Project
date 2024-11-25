using AutoMapper;
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

        public async Task<SectionDto> AddSectionAsync(SectionDto sectionDto)
        {
            try
            {
                var section = _mapper.Map<Sections>(sectionDto); // تبدیل Dto به Entity
                await _sectionRepository.AddSection(section);
                return _mapper.Map<SectionDto>(section); // تبدیل Entity به Dto و بازگرداندن
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<SectionDto> UpdateSectionAsync(SectionDto sectionDto)
        {
            try
            {
                var section = _mapper.Map<Sections>(sectionDto); // تبدیل Dto به Entity
                await _sectionRepository.UpdateSection(section);
                return _mapper.Map<SectionDto>(section); // تبدیل Entity به Dto و بازگرداندن
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<bool> DeleteSectionAsync(Guid id)
        {
            try
            {
                await _sectionRepository.DeleteSection(id);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<SectionDto> GetSectionByIdAsync(Guid id)
        {
            var section = await _sectionRepository.GetById(id);
            return _mapper.Map<SectionDto>(section); // تبدیل Entity به Dto
        }

        public async Task<IEnumerable<SectionDto>> GetAllSectionsAsync()
        {
            var sections = await _sectionRepository.GetAll();
            return _mapper.Map<IEnumerable<SectionDto>>(sections); // تبدیل لیست Entity ها به Dto ها
        }
    }

}
