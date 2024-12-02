using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly AllamehPrroject _context;

        public ImageRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public async Task<Image> GetImageById(Guid id)
        {
            try
            {
                return await _context.Images.FindAsync(id);
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new Exception("An error occurred while getting the image by ID.", ex);
            }
        }

        public async Task<IEnumerable<Image>> GetAllImages()
        {
            try
            {
                return await _context.Images.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new Exception("An error occurred while getting all images.", ex);
            }
        }
       
        public async Task<AddStatusVm> AddImage(Image image)
        {
            try
            {
                // Fetch the system account user
                var systemUser = await _context.Users.FirstOrDefaultAsync(u => u.IsSystemAccount);
                if (systemUser == null)
                {
                    throw new Exception("کاربر اکانت سیستمی یافت نشد.");
                }

                // Set metadata for the new image
                image.CreatedUserID = systemUser.Id;
                image.CreatedDate = DateTime.UtcNow;

                // Add the image to the database
                _context.Images.Add(image);
                await _context.SaveChangesAsync();
                AddStatusVm addStatusVm = new AddStatusVm();
                addStatusVm.IsValid = true;
                addStatusVm.StatusMessage="با موفقیت اضافه شد ";
                addStatusVm.AddedId=image.Id;
                return addStatusVm; // Return the added image with its Id
            }
            catch (Exception ex)
            {
                // Log the exception if required
                throw new Exception($"خطایی در افزودن تصویر به پایگاه داده رخ داده است: {ex.Message}", ex);
            }
        }


        public async Task UpdateImage(Image image)
        {
            try
            {
                _context.Images.Update(image);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new Exception("An error occurred while updating the image.", ex);
            }
        }

        public async Task DeleteImage(Guid id)
        {
            try
            {
                var image = await _context.Images.FindAsync(id);
                if (image != null)
                {
                    _context.Images.Remove(image);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new Exception("An error occurred while deleting the image.", ex);
            }
        }

       
    }

}
