using MAhface.Domain.Core.Entities.BasicInfo.Business;
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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)
        {
            return await _categoryRepository.GetCategoryByIdAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllCategoriesAsync();
        }


        public async Task<IEnumerable<NavVM>> GetAllTitleCategoriesAsync()
        {
            return await _categoryRepository.GetAllTitleCategoriesAsync();
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _categoryRepository.AddCategoryAsync(category);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            await _categoryRepository.UpdateCategoryAsync(category);
        }

        public async Task DeleteCategoryAsync(Guid id)
        {
            await _categoryRepository.DeleteCategoryAsync(id);
        }

        public async Task<IEnumerable<Category>> SearchCategories(string input)
        {
            var allData = await _categoryRepository.GetAllCategoriesAsync();
            var result = allData.Where(x => x.Title.Contains(input));
            return result;
        }

        public async Task<AddStatusVm> SeedCategories()
        {
            try
            {
                var categories = new List<Category>
                {
                    new Category
                    {
                        Id = Guid.Parse("4a6ef880-e352-49dc-0976-08dd0d886873"),
                        Title = "تستی",
                        Description = "string",
                        ParentCategoryId = null,
                        OrderNo = 0,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now ,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                        Title = "دانشگاهی علوم پایه پزشکی",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 7,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now ,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"),
                        Title = "زبان های خارجی",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 3,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"),
                        Title = "هنر",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 9,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                        Title = "برنامه نویسی",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 1,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                        Title = "دانشگاهی فنی و مهندسی",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 6,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                        Title = "آی تی  و نرم افزار",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 2,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                        Title = "مالی و سرمایه گذاری",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 5,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                        Title = "علوم پایه",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 8,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    },
                    new Category
                    {
                        Id = Guid.Parse("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                        Title = "مدیریت و کسب وکار",
                        Description = "",
                        ParentCategoryId = null,
                        OrderNo = 4,
                        CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                        CreatedDate = DateTime.Now,
                        ISActive = true,
                        IsDeleted = false
                    }
                };

                var result = await _categoryRepository.SeedData(categories);
                return result;
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطا در تولید دسته بندی ها: {ex.Message}",
                    AddedId = null
                };
            }
        }
    }
}
