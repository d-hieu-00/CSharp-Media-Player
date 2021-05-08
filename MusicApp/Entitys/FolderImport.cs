using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.Entitys
{
    public class FolderImport
    {
        #region properties
        public int ID { get; set; }
        public string Dir { get; set; }
        private readonly List<int> idSong = new List<int>();
        public List<int> IDSong { get => idSong; }
        private readonly List<int> idVideo = new List<int>();
        public List<int> IDVideo { get => idVideo; }
        #endregion

        #region sort list by id
        public void SortListSong()
        {
            IDSong.Sort();
        }
        public void SortListVideo()
        {
            IDVideo.Sort();
        }
        #endregion
    }
}
