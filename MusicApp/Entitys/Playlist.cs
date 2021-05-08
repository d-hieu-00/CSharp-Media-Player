using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;
using MusicApp.Classes;

namespace MusicApp.Entitys
{
    public class Playlist
    {
        private readonly List<int> idSongs = new List<int>();
        private readonly List<int> idVideos = new List<int>();
        public int ID { get; set; }
        public string Title { get; set; }
        public List<int> IDSongs { get => idSongs; }
        public List<int> IDVideos { get => idVideos; }

        #region sort list by id
        public void SortListSong()
        {
            IDSongs.Sort();
        }
        public void SortListVideo()
        {
            IDVideos.Sort();
        }
        #endregion

        #region get playlist string, axplayer
        // name, id, type
        public List<Dictionary<string, string>> GetPlayingListDic()
        {
            List<Dictionary<string, string>> tmp = new List<Dictionary<string, string>>();

            foreach (int id in IDSongs)
            {
                Song i = MyResources.Resources.MsgSongs.FindSongByID(id);
                if (i != null)
                {
                    tmp.Add(new Dictionary<string, string>()
                    {
                        { "name", i.SongTitle },
                        { "id", i.ID.ToString() },
                        { "type", "song" },
                        { "dir", i.FullDir },
                        { "duration", i.Duration }
                    });
                }
            }
            foreach (int id in IDVideos)
            {
                Video.Video i = MyResources.Resources.MsgVideos.FindVideoByID(id);
                if (i != null)
                {
                    tmp.Add(new Dictionary<string, string>()
                    {
                        { "name", i.VideoTitle },
                        { "id", i.ID.ToString() },
                        { "type", "video" },
                        { "dir", i.FullDir },
                        { "duration", i.Duration }
                    });
                }
            }
            
            tmp.Sort(
                delegate (Dictionary<string, string> p1, Dictionary<string, string> p2)
                {
                    return p1["name"].CompareTo(p2["name"]);
                });
            return tmp;
        }
        #endregion
    }
}
