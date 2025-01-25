using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AllamehPrroject _context;
        private readonly ICategoryService _categoryService;

        public CategoriesController( ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// دریافت تمامی دسته‌بندی‌ها
        /// این متد لیستی از تمام دسته‌بندی‌های موجود در سیستم را برمی‌گرداند.
        /// </summary>

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            try
            {
                var result = await _categoryService.GetAllCategoriesAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
          

        }

        /// <summary>
        /// دریافت عناوین دسته‌بندی‌ها
        /// این متد لیستی از عناوین دسته‌بندی‌ها را برمی‌گرداند.
        /// </summary>

        [HttpGet("GetAllTitleCategoriesAsync")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllTitleCategoriesAsync()
        {
            try
            {
                var result = await _categoryService.GetAllTitleCategoriesAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        /// <summary>
        /// دریافت اطلاعات دسته‌بندی بر اساس شناسه
        /// این متد اطلاعات یک دسته‌بندی مشخص را با استفاده از شناسه آن بازیابی می‌کند.
        /// </summary>

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Category>> GetById(Guid id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        /// <summary>
        /// جستجو در دسته‌بندی‌ها
        /// این متد دسته‌بندی‌هایی را که با ورودی جستجو مطابقت دارند، برمی‌گرداند.
        /// </summary>

        [HttpGet("Search/{input}")]
        public async Task<ActionResult<IEnumerable<Category>>> Search(string input)
        {
            var categories = await _categoryService.SearchCategories(input);

            if (categories == null || !categories.Any())
            {
                return NotFound();
            }

            return Ok(categories);
        }



        /// <summary>
        /// افزودن دسته‌بندی جدید
        /// این متد یک دسته‌بندی جدید را بر اساس اطلاعات ورودی ایجاد کرده و در سیستم ذخیره می‌کند.
        /// </summary>

        [HttpPost("AddCategory")]
        public async Task<ActionResult<Category>> AddCategory(CategoryVm categoryVm)
        {
            Category category = new Category();
            category.Title=categoryVm.Title;
            category.Description=categoryVm.Description;
            category.OrderNo=categoryVm.OrderNo;
            category.IsDeleted=false;
            category.ISActive=true;
            category.CreatedUserID=_context.Users.FirstOrDefault(x => x.IsSystemAccount).Id;
            category.CreatedDate=DateTime.Now;
            _context.Categories.Add(category);
            try
            {

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return CreatedAtAction("GetById", new { id = category.Id }, category);
        }

        /// <summary>
        /// حذف نرم دسته‌بندی
        /// این متد وضعیت حذف نرم (soft delete) را برای یک دسته‌بندی مشخص تنظیم می‌کند.
        /// </summary>

        [HttpDelete("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsDeleted=true;
            await _context.SaveChangesAsync();

            return NoContent();
        }


       
    }
}
