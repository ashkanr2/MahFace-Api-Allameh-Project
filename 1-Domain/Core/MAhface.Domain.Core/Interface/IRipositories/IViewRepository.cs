using MAhface.Domain.Core.Entities.BasicInfo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface IViewRepository
    {
        Task<View> GetById(Guid id);
        Task<View> GetByUserAndSectionId(Guid userId, Guid SectionId);
        Task<IEnumerable<View>> GetByCourseId(Guid courseId);
        Task<int> CountOfCourseView(Guid courseId);
        Task<int> CountOfCourseViewForUser(Guid userId);
        Task AddView(View view);
        Task UpdateView(View view);


    }

}
