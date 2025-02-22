﻿using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
                    return _context.Seasons.Include(s => s.Course)
                    .Include(e => e.Episodes)
                    .OrderBy(x=>x.CreatedDate).ToList();
                }
                catch (Exception ex)
                {
                ErrorLog error = new ErrorLog();
                error.Entityname="Season";
                error.ActionName="GetAll";
                error.Exeption=ex.Message;
                error.ActionType="Ripository";
                _context.ErrorLogs.Add(error);
                return new List<Seasons>(); 
                }
            
        }

        public string Create(Seasons season)
        {
            //var CreateUserId = _context.Users.FirstOrDefault(x => x.IsSystemAccount).Id;
            try
            {
                season.CreatedDate= DateTime.Now;
                //season.CreatedUserID=CreateUserId;
                _context.Seasons.Add(season);
                _context.SaveChanges();
                return "با موفقیت اضافه شد";
            }
            catch (Exception ex)
            {
                ErrorLog error = new ErrorLog();
                error.Entityname="Season";
                error.ActionName="Create";
                error.Exeption=ex.Message;
                error.ActionType="Ripository";
                error.UserId=season.CreatedUserID;
                _context.ErrorLogs.Add(error);
                // Log exception
                return $"Error: {ex.Message}";
            }
        }

        public Seasons GetById(Guid id)
        {
            return _context.Seasons.
                Include(s => s.Course)
                .Include(e=>e.Episodes)
                .FirstOrDefault(s => s.Id == id);
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
                existingSeason.SeasonsDescription = season.SeasonsDescription;
                existingSeason.CourseId = season.CourseId;
                existingSeason.Description=existingSeason.Description + season.Description;
                _context.SaveChanges();
                return "Season updated successfully.";
            }
            catch (Exception ex)
            {
                ErrorLog error = new ErrorLog();
                error.Entityname="Season";
                error.ActionName="Update";
                error.Exeption=ex.Message;
                error.ActionType="Ripository";
                error.UserId = season.CreatedUserID;
                _context.ErrorLogs.Add(error);
                // Log exception
                return $"Error: {ex.Message}";
            }
        }



        public AddStatusVm SeedData(List<Seasons> seasons)
        {
            var status = new AddStatusVm
            {
                IsValid = false,
                StatusMessage = "An error occurred while adding seasons.",
                AddedId = null
            };

            try
            {
                // Add the seasons to the DbSet
                _context.Seasons.AddRange(seasons);

                // Save changes to the database
                _context.SaveChanges();

                // Set the status to indicate success
                status.IsValid = true;
                status.StatusMessage = "Seasons added successfully.";
                status.AddedId = seasons.FirstOrDefault()?.Id; // Assuming all seasons have the same Id
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.WriteLine($"An error occurred: {ex.Message}");

                // Set the status to indicate failure
                status.IsValid = false;
                status.StatusMessage = $"An error occurred: {ex.Message}";
                status.AddedId = null;
            }

            return status;
        }

        public int GetCount(Guid courseId)
        {
            try
            {
                // Count the number of seasons for the specified course
                int seasonCount = _context.Seasons
                                          .Count(s => s.CourseId == courseId);

                return seasonCount;
            }
            catch (Exception ex)
            {
                // Log and handle the error
                throw new Exception($"Error fetching season count for course ID: {courseId}", ex);
            }
        }

        public void DeleteById(Guid Id)
        {
            var entity =_context.Seasons.FirstOrDefault(x => x.Id==Id);
            entity.IsDeleted= true;
            entity.DeletedDate= DateTime.Now;
            _context.SaveChanges();
        }
    }

}
