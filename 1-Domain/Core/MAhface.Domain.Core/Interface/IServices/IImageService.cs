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
        Task<ImageDto> AddImage(ImageDto imageDto);
        Task UpdateImage(ImageDto imageDto);
        Task DeleteImage(Guid id);
        Task<byte[]> GetImageBytes(Guid id);
        Task<byte[]> GetImageBytesFromBase64(string base64String);
    }
}
