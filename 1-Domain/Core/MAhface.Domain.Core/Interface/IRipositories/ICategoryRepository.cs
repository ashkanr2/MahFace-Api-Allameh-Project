using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategoryByIdAsync(Guid id);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<IEnumerable<NavVM>> GetAllTitleCategoriesAsync();
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(Guid id);
        Task<AddStatusVm> SeedData(List<Category> categories);
    }
}
