using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibary
{
    class EpisodeList
    {
        public List<Episode> episodeList { get; set; }

        public void AddEpisodeToList(Episode episode)
        {
            episodeList.Add(episode);
        }
    }
}
