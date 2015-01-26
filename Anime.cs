using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibary
{
    class Anime
    {
        string _AnimeName;
        public string description { get; set; }
        public int score { get; set; }
        public int TOTAL_EPISODES { get; set; }
        public string status { get; set; }
        public string airPeriode { get; set; }
        public string studio { get; set; }
        public EpisodeList episodeList { get; set; }

        public Anime(string name)
        {
            _AnimeName = name;
        }

        public void SetupInformation()
        {
            XmlParser parser = new XmlParser();
            studio = parser.fetchElementInfoByName("series_episodes");
        }

        public List<string> fetchGenreList()
        {
            List<string> genres = new List<string>();
            return genres;
        }
    }
}
