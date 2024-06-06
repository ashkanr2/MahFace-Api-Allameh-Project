using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IImageService
    {
        Task<ImageDto> GetImageById(Guid id);
        Task<IEnumerable<ImageDto>> GetAllImages();
        public Task<ImageDto> AddImage(ImageDto imageDto);
        Task UpdateImage(ImageDto image);
        Task DeleteImage(Guid id);
    }
}
