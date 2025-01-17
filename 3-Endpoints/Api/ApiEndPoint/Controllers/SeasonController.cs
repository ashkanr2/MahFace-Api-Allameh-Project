using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class SeasonController : ControllerBase
{
    private readonly ISeasonService _seasonService;

    public SeasonController(ISeasonService seasonService)
    {
        _seasonService = seasonService;
    }

    [HttpGet("GetAllSeasons")]
    public ActionResult<List<SeasonsDto>> GetAll()
    {
        var seasons = _seasonService.GetAll();
        return Ok(seasons);
    }

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

    [HttpGet("GetAllByCourseId")]
    public ActionResult<List<SeasonsDto>> GetAllCourseSeasons(Guid courseId)
    {
        var seasons = _seasonService.GetAllCourseSeasons(courseId).OrderBy(x=>x.CreatedDate);
        return Ok(seasons);
    }

    //[HttpGet("GetBySectionId")]
    //public ActionResult<SeasonsDto> GetBySectionId(Guid sectionId)
    //{
    //    var seasons = _seasonService.GetBySectionId(sectionId);
    //    return Ok(seasons);
    //}

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
