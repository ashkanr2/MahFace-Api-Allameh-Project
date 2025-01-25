using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AllamehPrroject _context;

        public CategoryRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {

            try
            {
                var sss = await _context.Categories.Where(x => !x.IsDeleted).ToListAsync();
                return await _context.Categories.ToListAsync();
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task<IEnumerable<NavVM>> GetAllTitleCategoriesAsync()
        {

            try
            {
                var categories = await _context.Categories.Where(x => !x.IsDeleted).Select(x => new NavVM() { Id= x.Id, Title= x.Title }).ToListAsync();
                return categories;
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                category.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<AddStatusVm> SeedData(List<Category> categories)
        {

            try
            {
                // Add comments to the database
                await _context.Categories.AddRangeAsync(categories);
                await _context.SaveChangesAsync();

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "دسته بندی ها  با موفقیت اضافه شدند.",
                    AddedId = null
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطا در افزودن دسته بندی ها: {ex.Message}",
                    AddedId = null
                };
            }
        }
    }
}
