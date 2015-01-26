using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibary
{
    class AnimeList
    {
        public List<Anime> animeList { get; set; }

        public void AddAnimeToList(Anime anime)
        {
            animeList.Add(anime);
        }
    }
}
