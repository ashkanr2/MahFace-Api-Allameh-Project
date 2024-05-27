﻿using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
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

        public CategoriesController(AllamehPrroject context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("GetById")]
        public async Task<ActionResult<Category>> GetById(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCategory(Guid id, Category category)
        //{
        //    if (id != category.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(category).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CategoryExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
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

        //DELETE: api/Categories/5
        [HttpDelete("IsDeleted")]
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

        private bool CategoryExists(Guid id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
