using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AMLibary
{
    class Episode
    {
        string _episodeFromAnime;
        public string description { get; set; }
        public int episodeNumber { get; set; }
        public string AirDate { get; set; }

        public Episode(string anime)
        {
            _episodeFromAnime = anime;
        }
    }
}
