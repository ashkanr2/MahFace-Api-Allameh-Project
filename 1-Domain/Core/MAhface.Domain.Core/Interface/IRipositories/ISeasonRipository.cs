using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface ISeasonRipository
    {
        public List<Seasons> GetAll();

        public int GetCount(Guid CourseId);
        public Seasons GetById(Guid Id);

        public string Update(Seasons season);

        public string Create(Seasons season);

        AddStatusVm SeedData(List<Seasons> seasons);

    }
}
