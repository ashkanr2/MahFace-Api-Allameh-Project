﻿using MAhface.Domain.Core.Entities.Study.Season;
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
    public class SeasonRepository : ISeasonRipository
    {
        private readonly AllamehPrroject _context;

        public SeasonRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public List<Seasons> GetAll()
        {
            
                try
                {
                    return _context.Seasons.Include(s => s.Course).ToList();
                }
                catch (Exception ex)
                {
                   
                    return new List<Seasons>(); 
                }
            
        }

        public string Create(Seasons season)
        {
            try
            {
                _context.Seasons.Add(season);
                _context.SaveChanges();
                return "Season created successfully.";
            }
            catch (Exception ex)
            {
                // Log exception
                return $"Error: {ex.Message}";
            }
        }

        public Seasons GetById(Guid id)
        {
            return _context.Seasons.Include(s => s.Course).FirstOrDefault(s => s.Id == id);
        }

        public string Update(Seasons season)
        {
            try
            {
                var existingSeason = _context.Seasons.Find(season.Id);
                if (existingSeason == null)
                {
                    return "Season not found.";
                }

                existingSeason.Title = season.Title;
                existingSeason.Description = season.Description;
                existingSeason.CourseId = season.CourseId;

                _context.SaveChanges();
                return "Season updated successfully.";
            }
            catch (Exception ex)
            {
                // Log exception
                return $"Error: {ex.Message}";
            }
        }
    }

}