using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Entitys.Video
{
    public class VideoCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private readonly List<int> idVideos = new List<int>();
        public List<int> IDVideos { get => idVideos; }

        #region sort list video
        public void SortListVideo()
        {
            IDVideos.Sort();
        }
        #endregion
    }
}
