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

        public async Task<Image> AddImage(Image image)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.IsSystemAccount);
                if (user == null)
                {
                    throw new Exception("System account user not found.");
                }

                image.CreatedUserID = user.Id;
                image.CreatedDate = DateTime.UtcNow;

                _context.Images.Add(image);
                await _context.SaveChangesAsync();
                return image;
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new Exception("An error occurred while adding the image.", ex);
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
