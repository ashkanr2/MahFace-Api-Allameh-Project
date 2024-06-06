
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface IImageRepository
    {
        Task<Image> GetImageById(Guid id);
        Task<IEnumerable<Image>> GetAllImages();
        public Task<Image> AddImage(Image image);
        Task UpdateImage(Image image);
        Task DeleteImage(Guid id);
    }

}
