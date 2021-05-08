using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Entitys
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private readonly List<int> idSongs = new List<int>();
        public List<int> IDSongs { get => idSongs; }

        #region sort list song by id
        public void SortListSong()
        {
            IDSongs.Sort();
        }
        #endregion
    }
}
