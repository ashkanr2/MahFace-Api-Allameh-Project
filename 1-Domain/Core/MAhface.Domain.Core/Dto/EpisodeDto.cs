using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class EpisodeDto
    {
        public Guid Id { get; set; }

        public string SeasonTitle { get; set; } // This will hold the title of the season
        public string EpisodeTitle { get; set; } // This will hold the title of the episode

        public string URL { get; set; }
        public Guid SeasionId { get; set; }
        public Guid CourseId { get; set; }
        public string SeasonName { get; set; } // Name of the season




    }



}
