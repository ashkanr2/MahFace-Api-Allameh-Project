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
