using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;

[Route("api/[controller]")]
[ApiController]
public class SeasonController : ControllerBase
{
    private readonly ISeasonService _seasonService;

    public SeasonController(ISeasonService seasonService)
    {
        _seasonService = seasonService;
    }
    /// <summary>
    /// دریافت تمامی فصول
    /// این متد لیستی از تمام فصول موجود را برمی‌گرداند.
    /// </summary>

    [HttpGet("GetAllSeasons")]
    public  ActionResult<List<SeasonsDto>> GetAllSeasons()
    {
        try
        {
            var seasons = _seasonService.GetAll();

            return seasons;
        }
        catch (Exception ex)
        {

            return StatusCode(500, "An error occurred while processing your request.");
        }
    }


    /// <summary>
    /// دریافت فصل بر اساس شناسه
    /// این متد اطلاعات یک فصل خاص را با استفاده از شناسه آن بازیابی می‌کند.
    /// </summary>

    [HttpGet("GetById")]
    public ActionResult<SeasonsDto> GetById(Guid id)
    {
        var season = _seasonService.GetById(id);
        if (season == null)
        {
            return NotFound();
        }
        return Ok(season);
    }
    /// <summary>
    /// دریافت تمامی فصول مرتبط با یک دوره خاص
    /// این متد لیستی از فصول مربوط به یک دوره خاص را برمی‌گرداند.
    /// </summary>

    [HttpGet("GetAllByCourseId")]
    public ActionResult<List<SeasonsDto>> GetAllCourseSeasons(Guid courseId)
    {
        var seasons = _seasonService.GetAllCourseSeasons(courseId).OrderBy(x=>x.CreatedDate);
        return Ok(seasons);
    }


    /// <summary>
    /// افزودن فصل جدید
    /// این متد یک فصل جدید را با استفاده از اطلاعات ورودی ایجاد می‌کند.
    /// </summary>

    [HttpPost("AddSeason")]
    public ActionResult<string> Create(AddSeasonVM seasonVm)
    {
        SeasonsDto seasonDto = new SeasonsDto();
        seasonDto.Title = seasonVm.Title;
        seasonDto.SeasonsDescription = seasonVm.SeasonsDescription;
        seasonDto.CourseId = seasonVm.CourseId;
        seasonDto.Id=new Guid();
        var result = _seasonService.Create(seasonDto);
        return Ok(result);
    }
    /// <summary>
    /// به‌روزرسانی فصل
    /// این متد اطلاعات یک فصل موجود را بر اساس شناسه آن و داده‌های ورودی به‌روزرسانی می‌کند.
    /// </summary>

    [HttpPut("Update")]
    public ActionResult<string> Update( SeasonVm seasonVm)
    {
        SeasonsDto seasonDto = new SeasonsDto();
        seasonDto.Title = seasonVm.Title;
        seasonDto.SeasonsDescription = seasonVm.SeasonsDescription;
        seasonDto.CourseId = seasonVm.CourseId;
        seasonDto.Id=seasonVm.Id;
        var result = _seasonService.Update(seasonDto);
        return Ok(result);
    }

   


}
