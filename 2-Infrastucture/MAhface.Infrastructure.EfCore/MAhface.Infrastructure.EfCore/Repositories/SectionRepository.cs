using MAhface.Domain.Core.Entities.Study.Section;
using MAhface.Domain.Core1.Dto;
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
    public class SectionRepository : ISectionRepository
    {
        private readonly AllamehPrroject _context;
        private readonly IUserRepository _userRepository;
        public SectionRepository(IUserRepository userRepository, AllamehPrroject context)
        {
            _context = context;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Retrieves a section by its ID.
        /// </summary>
        /// <param name="id">The ID of the section.</param>
        /// <returns>A Section or null if not found.</returns>
        public async Task<Sections> GetById(Guid id)
        {
            try
            {
                return await _context.Sections.FirstOrDefaultAsync(s => s.Id == id);
            }
            catch (Exception ex)
            {
                // Log exception if needed
                throw new Exception($"An error occurred while fetching the section by ID: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Retrieves all sections.
        /// </summary>
        /// <returns>A list of all sections.</returns>
        public async Task<IEnumerable<Sections>> GetAll()
        {
            try
            {
                return await _context.Sections.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log exception if needed
                throw new Exception($"An error occurred while fetching all sections: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Adds a new section to the database.
        /// </summary>
        /// <param name="section">The section to add.</param>
        /// <returns>A status indicating if the addition was successful or not.</returns>
        public async Task<AddStatusVm> AddSection(Sections section)
        {
            try
            {

                /// movaqat mibashad
                var adminId = await _userRepository.GetAdminUserId();
                section.ISActive=true;
                section.IsDeleted=false;
                section.CreatedDate=DateTime.Now;
                section.CreatedUserID = adminId;

                await _context.Sections.AddAsync(section);
                await _context.SaveChangesAsync();

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Section added successfully."
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"An error occurred while adding the section: {ex.Message}"
                };
            }
        }

        /// <summary>
        /// Updates an existing section in the database.
        /// </summary>
        /// <param name="section">The section to update.</param>
        /// <returns>A status indicating if the update was successful or not.</returns>
        public async Task<AddStatusVm> UpdateSection(Sections section)
        {
            try
            {
                var existingSection = await GetById(section.Id);
                if (existingSection == null)
                {
                    return new AddStatusVm
                    {
                        IsValid = false,
                        StatusMessage = "Section not found."
                    };
                }

                _context.Sections.Update(section);
                await _context.SaveChangesAsync();

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Section updated successfully."
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"An error occurred while updating the section: {ex.Message}"
                };
            }
        }

        /// <summary>
        /// Deletes a section by its ID.
        /// </summary>
        /// <param name="id">The ID of the section to delete.</param>
        /// <returns>A status indicating if the deletion was successful or not.</returns>
        public async Task<AddStatusVm> DeleteSection(Guid id)
        {
            try
            {
                var section = await GetById(id);
                if (section == null)
                {
                    return new AddStatusVm
                    {
                        IsValid = false,
                        StatusMessage = "Section not found."
                    };
                }

                _context.Sections.Remove(section);
                await _context.SaveChangesAsync();

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Section deleted successfully."
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"An error occurred while deleting the section: {ex.Message}"
                };
            }
        }
    }
}
