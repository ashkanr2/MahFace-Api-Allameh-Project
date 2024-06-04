using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core1.Interface.IRipositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{
    public class SeasonRipository : ISeasonRipository
    {
        public List<Seasons> GetAll { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Create(Seasons season)
        {
            throw new NotImplementedException();
        }

        public Seasons GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public string Update(Seasons season)
        {
            throw new NotImplementedException();
        }
    }
}
