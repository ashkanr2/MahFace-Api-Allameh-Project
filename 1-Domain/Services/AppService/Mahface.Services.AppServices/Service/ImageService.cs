using AutoMapper;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{

    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public ImageService(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<ImageDto> GetImageById(Guid id)
        {
            var image = await _imageRepository.GetImageById(id);
            return _mapper.Map<ImageDto>(image);
        }

        public async Task<IEnumerable<ImageDto>> GetAllImages()
        {
            var images = await _imageRepository.GetAllImages();
            return _mapper.Map<IEnumerable<ImageDto>>(images);
        }

        public async Task<ImageDto> AddImage(ImageDto imageDto)
        {
            var Image = _mapper.Map<Image>(imageDto);
            var ImageResult = await _imageRepository.AddImage(Image);
            var ImageDto = _mapper.Map<ImageDto>(ImageResult);
            return ImageDto;
        }

        public async Task UpdateImage(ImageDto imageDto)
        {
            var image = _mapper.Map<Image>(imageDto);
            await _imageRepository.UpdateImage(image);
        }

        public async Task DeleteImage(Guid id)
        {
            await _imageRepository.DeleteImage(id);
        }
    }
}


