﻿using MAhface.Domain.Core1.Entities.BasicInfo.Business;
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
        //private readonly AllamehPrroject _context;

        //public ImageRepository(AllamehPrroject context)
        //{
        //    _context = context;
        //}

        //public async Task<Image> GetImageByIdAsync(Guid id)
        //{
        //    return await _context.Images.FindAsync(id);
        //}

        //public async Task<IEnumerable<Image>> GetAllImagesAsync()
        //{
        //    return await _context.Images.ToListAsync();
        //}

        //public async Task AddImageAsync(Image image)
        //{
        //    _context.Images.Add(image);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateImageAsync(Image image)
        //{
        //    _context.Images.Update(image);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteImageAsync(Guid id)
        //{
        //    var image = await _context.Images.FindAsync(id);
        //    if (image != null)
        //    {
        //        _context.Images.Remove(image);
        //        await _context.SaveChangesAsync();
        //    }
        //}
    }

}