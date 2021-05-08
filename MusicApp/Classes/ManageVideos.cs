using AxWMPLib;
using MusicApp.Entitys;
using MusicApp.Entitys.Video;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMPLib;

namespace MusicApp.Classes
{
    public class ManageVideos
    {
        #region properties
        private readonly List<Video> listVideos = new List<Video>();
        private readonly List<VideoCategory> listCateories = new List<VideoCategory>();
        private readonly List<Director> listDirectors = new List<Director>();
        public List<Video> ListVideos { get => listVideos; }
        public List<VideoCategory> ListCategories { get => listCateories; }
        public List<Director> ListDirectors { get => listDirectors; }

        #endregion

        #region sort list by id (video, category, director)
        public void SortListVideo()
        {
            ListVideos.Sort(
                delegate (Video p1, Video p2)
                {
                    return p1.ID.CompareTo(p2.ID);
                });
        }
        public void SortListCategory()
        {
            ListCategories.Sort(
                delegate (VideoCategory p1, VideoCategory p2)
                {
                    return p1.ID.CompareTo(p2.ID);
                });
        }
        public void SortListDirectors()
        {
            ListDirectors.Sort(
                delegate (Director p1, Director p2)
                {
                    return p1.ID.CompareTo(p2.ID);
                });
        }

        #endregion
        public void CreatePlaylistAllVideos()
        {
            Playlist pl0 = new Playlist()
            {
                ID = 0,
                Title = "All videos"
            };
            foreach (Video i in ListVideos)
                pl0.IDVideos.Add(i.ID);
            MyResources.Resources.DeletePlaylistByID(0);
            MyResources.Resources.ListPlaylists.Add(pl0);
        }
        public void RemoveEmpty()
        {
            for (int i = 0; i < listCateories.Count; i++)
                if (listCateories[i].IDVideos.Count == 0)
                    listCateories.Remove(listCateories[i]);
            for (int i = 0; i < listDirectors.Count; i++)
                if (listDirectors[i].IDVideos.Count == 0)
                    listDirectors.Remove(listDirectors[i]);
        }

        #region Get next ID (video, playlist, category, director)
        public int GetNextIDVideo()
        {
            int _max = 0;
            foreach (Video i in ListVideos)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        public int GetNextIDCategory()
        {
            int _max = 0;
            foreach (VideoCategory i in ListCategories)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        public int GetNextIDDirector()
        {
            int _max = 0;
            foreach (Director i in ListDirectors)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }

        #endregion

        #region find list video by id (video, category)
        public Video FindVideoByID(int ID)
        {
            foreach (Video i in ListVideos)
                if (i.ID == ID)
                    return i;
            return null;
        }
        public List<Video> FindSongByCategoryID(int ID)
        {
            List<Video> tmp = new List<Video>();
            List<int> listID = null;
            int indexListID = 0;

            foreach (VideoCategory i in ListCategories)
            {
                if (i.ID == ID)
                {
                    listID = i.IDVideos;
                    break;
                }
            }

            foreach (Video i in ListVideos)
            {
                if (i.ID == listID[indexListID])
                {
                    tmp.Add(i);
                    if (++indexListID == listID.Count)
                        break;
                }
            }
            return tmp;
        }
        #endregion

        #region delete video ==> remove
        //have id delete
        public void DeleteVideoByID(int ID)
        {
            //delete on listcategory
            Task delCategory = new Task(() =>
            {
                foreach (VideoCategory i in ListCategories)
                {
                    if (i.IDVideos.IndexOf(ID) >= 0)
                    {
                        i.IDVideos.Remove(ID);
                        if (i.IDVideos.Count > 2)
                            i.SortListVideo();
                    }
                }
            });
            delCategory.Start();
            //delete on directory
            Task delDirectory = new Task(() =>
            {
                foreach (Director i in ListDirectors)
                {
                    if (i.IDVideos.IndexOf(ID) >= 0)
                    {
                        i.IDVideos.Remove(ID);
                        if (i.IDVideos.Count > 2)
                            i.SortListVideo();
                    }
                }
            });
            delDirectory.Start();
            //delete on listvideo
            Task delListVideo = new Task(() =>
            {
                foreach (Video i in ListVideos)
                {
                    if (i.ID == ID)
                    {
                        ListVideos.Remove(i);
                        break;
                    }
                }
                if (ListVideos.Count > 2)
                    SortListVideo();
            });
            delListVideo.Start();
            Task.WaitAll(delListVideo, delCategory, delDirectory);
        }
        #endregion

        #region insert, update video ==> sync data
        //have id song insert, update
        public void InsertVideo(Video video)
        {
            //insert video to category
            Task insertCategory = new Task(() =>
            {
                bool ck = false;
                List<string> tmp_genre = new List<string>(video.Genre);
                foreach (VideoCategory i in ListCategories)
                {
                    if (tmp_genre.Count == 0)
                        break;
                    if (tmp_genre.IndexOf(i.Name) >= 0)
                    {
                        i.IDVideos.Add(video.ID);
                        tmp_genre.Remove(i.Name);
                        ck = true;
                    }
                }
                if (!ck)
                {
                    foreach (string i in tmp_genre)
                    {
                        VideoCategory ctg = new VideoCategory()
                        {
                            Name = i,
                            ID = GetNextIDCategory()
                        };
                        ctg.IDVideos.Add(video.ID);
                        ListCategories.Add(ctg);
                    }
                    if (ListCategories.Count > 2)
                        SortListCategory();
                }
            });
            insertCategory.Start();
            //insert directory
            Task insertDirector = new Task(() =>
            {
                bool ck = false;
                List<string> tmp_director = new List<string>(video.Directors);
                foreach (Director i in ListDirectors)
                {
                    if (tmp_director.Count == 0)
                        break;
                    if (tmp_director.IndexOf(i.Name) >= 0)
                    {
                        i.IDVideos.Add(video.ID);
                        tmp_director.Remove(i.Name);
                        ck = true;
                    }
                }
                if (!ck)
                {
                    foreach (string i in tmp_director)
                    {
                        Director ctg = new Director()
                        {
                            Name = i,
                            ID = GetNextIDDirector()
                        };
                        ctg.IDVideos.Add(video.ID);
                        ListDirectors.Add(ctg);
                    }
                    if (ListDirectors.Count > 2)
                        SortListDirectors();
                }
            });
            insertDirector.Start();
            //insert video
            ListVideos.Add(video);
            if (ListCategories.Count > 2)
                SortListVideo();
            Task.WaitAll(insertCategory, insertDirector);
        }
        public void UpdateVideo(Video video)
        {
            DeleteVideoByID(video.ID);
            InsertVideo(video);
            RemoveEmpty();
        }
        #endregion
    }
}
