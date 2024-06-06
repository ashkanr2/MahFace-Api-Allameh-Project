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
            Image image = new Image();
            image.Base64File = imageDto.Base64File;
            image.Url = imageDto.Url;
            var imageResult = await _imageRepository.AddImage(image);
            return _mapper.Map<ImageDto>(imageResult);
            //try
            //{
            //    var image = _mapper.Map<Image>(imageDto);
            //    var imageResult = await _imageRepository.AddImage(image);
            //    return _mapper.Map<ImageDto>(imageResult);
            //}
            //catch (Exception ex) {
            //    return null;
            //}


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

        public async Task<byte[]> GetImageBytes(Guid id)
        {
            var image = await _imageRepository.GetImageById(id);
            if (image == null) return null;
            return Convert.FromBase64String(image.Base64File);
        }

        public async Task<byte[]> GetImageBytesFromBase64(string base64String)
        {
            try
            {
                return Convert.FromBase64String(base64String);
            }
            catch (FormatException)
            {
                return null;
            }
        }
    }
}


