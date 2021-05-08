using AxWMPLib;
using MusicApp.Entitys;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMPLib;

namespace MusicApp.Classes
{
    public class ManageSongs
    {
        #region properties
        private readonly List<Song> listSongs = new List<Song>();
        private readonly List<Album> listAlbums = new List<Album>();
        private readonly List<Artist> listArtists = new List<Artist>();
        private readonly List<SongCategory> listCateories = new List<SongCategory>();
        public List<Song> ListSongs { get => listSongs; }
        public List<Album> ListAlbums { get => listAlbums; }
        public List<Artist> ListArtists { get => listArtists; }
        public List<SongCategory> ListCategories { get => listCateories; }
        #endregion

        #region sort list by id (song, album, artist, playlist, category)
        public void SortListSong()
        {
            ListSongs.Sort(
                delegate (Song p1, Song p2)
                {
                    return p1.ID.CompareTo(p2.ID);
                });
        }
        public void SortListAlbum()
        {
            ListAlbums.Sort(
                delegate (Album p1, Album p2)
                {
                    return p1.ID.CompareTo(p2.ID);
                });
        }
        public void SortListArtist()
        {
            ListArtists.Sort(
                delegate (Artist p1, Artist p2)
                {
                    return p1.ID.CompareTo(p2.ID);
                });
        }
        public void SortListCategory()
        {
            ListCategories.Sort(
                delegate (SongCategory p1, SongCategory p2)
                {
                    return p1.ID.CompareTo(p2.ID);
                });
        }
        #endregion

        public void CreatePlaylistAllSongs()
        {
            Playlist pl0 = new Playlist()
            {
                ID = 0,
                Title = "All songs"
            };
            foreach (Song i in ListSongs)
                pl0.IDSongs.Add(i.ID);
            MyResources.Resources.DeletePlaylistByID(0);
            MyResources.Resources.ListPlaylists.Add(pl0);
        }
        public void RemoveEmpty()
        {
            for (int i=0; i<ListAlbums.Count; i++)
                if (ListAlbums[i].IDSongs.Count == 0)
                    ListAlbums.Remove(ListAlbums[i]);
            for (int i = 0; i < ListCategories.Count; i++)
                if (ListCategories[i].IDSongs.Count == 0)
                    ListCategories.Remove(ListCategories[i]);
            for (int i = 0; i < ListArtists.Count; i++)
                if (ListArtists[i].IDSongs.Count == 0)
                    ListArtists.Remove(ListArtists[i]);
        }

        #region Get next ID (song, album, artist, playlist, category)
        public int GetNextIDSong()
        {
            int _max = 0;
            foreach (Song i in ListSongs)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        public int GetNextIDAlbum()
        {
            int _max = 0;
            foreach (Album i in ListAlbums)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        public int GetNextIDArtist()
        {
            int _max = 0;
            foreach (Artist i in ListArtists)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        public int GetNextIDCategory()
        {
            int _max = 0;
            foreach (SongCategory i in ListCategories)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        #endregion

        #region find list song by id (song, album, artist, playlist, category)
        public Song FindSongByID(int ID)
        {
            foreach (Song i in ListSongs)
                if (i.ID == ID)
                    return i;
            return null;
        }
        public List<Dictionary<string, string>> FindSongsByAlbumID(int ID)
        {
            Playlist tmp_pl = new Playlist()
            {
                ID = 0
            };

            foreach (Album i in ListAlbums)
            {
                if (i.ID == ID)
                {
                    tmp_pl.IDSongs.AddRange(new List<int>(i.IDSongs));
                    tmp_pl.Title = i.AlbumArtist;
                    break;
                }
            }

            return tmp_pl.GetPlayingListDic();
        }
        public List<Song> FindSongByArtistID(int ID)
        {
            List<Song> tmp = new List<Song>();
            List<int> listID = null;
            int indexListID = 0;

            foreach (Artist i in ListArtists)
            {
                if (i.ID == ID)
                {
                    listID = i.IDSongs;
                    break;
                }
            }

            foreach (Song i in ListSongs)
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
        public List<Song> FindSongByCategoryID(int ID)
        {
            List<Song> tmp = new List<Song>();
            List<int> listID = null;
            int indexListID = 0;

            foreach (SongCategory i in ListCategories)
            {
                if (i.ID == ID)
                {
                    listID = i.IDSongs;
                    break;
                }
            }

            foreach (Song i in ListSongs)
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

        #region delete song ==> remove
        //have id delete
        public void DeleteSongByID(int ID)
        {
            //delete on ablum
            Task delAlbum = new Task(() =>
            {
                foreach (Album i in ListAlbums)
                {
                    if (i.IDSongs.IndexOf(ID) >= 0)
                    {
                        i.IDSongs.Remove(ID);
                        if (i.IDSongs.Count > 2)
                            i.SortListSong();
                    }
                }
            });
            delAlbum.Start();
            //delete on artist
            Task delArt = new Task(() =>
            {
                foreach (Artist i in ListArtists)
                {
                    if (i.IDSongs.IndexOf(ID) >= 0)
                    {
                        i.IDSongs.Remove(ID);
                        if (i.IDSongs.Count > 2)
                            i.SortListSong();
                        break;
                    }
                }
            });
            delArt.Start();
            //delete on listcategory
            Task delCategory = new Task(() =>
            {
                foreach (SongCategory i in ListCategories)
                {
                    if (i.IDSongs.IndexOf(ID) >= 0)
                    {
                        i.IDSongs.Remove(ID);
                        if (i.IDSongs.Count > 2)
                            i.SortListSong();
                    }
                }
            });
            delCategory.Start();
            //delete on listsong
            foreach (Song i in ListSongs)
            {
                if (i.ID == ID)
                {
                    ListSongs.Remove(i);
                    break;
                }
            }
            if (listSongs.Count > 2)
                SortListSong();
            Task.WhenAll(delAlbum, delArt, delCategory);
        }
        #endregion

        #region insert, update song ==> sync data
        //have id song insert, update
        public void InsertSong(Song song)
        {
            //insert song to album
            Task insertAlbum = new Task(() =>
            {
                bool ck = false;
                foreach(Album i in ListAlbums)
                {
                    if (i.AlbumArtist == song.SongArtist && i.Name == song.AlbumTitle)
                    {
                        i.IDSongs.Add(song.ID);
                        ck = true;
                    }
                }
                if (!ck)
                {
                    Album alb = new Album()
                    {
                        Name = song.AlbumTitle,
                        AlbumArtist = song.SongArtist,
                        ID = GetNextIDAlbum()
                    };
                    alb.IDSongs.Add(song.ID);
                    ListAlbums.Add(alb);
                    if (ListAlbums.Count > 2)
                        SortListAlbum();
                }
            });
            insertAlbum.Start();
            //insert song to artist
            Task insertArtist = new Task(() => 
            {
                bool ck = false;
                foreach (Artist i in ListArtists)
                {
                    if (song.SongArtist == i.Name)
                    {
                        i.IDSongs.Add(song.ID);
                        ck = true;
                        break;
                    }
                }
                if (!ck)
                {
                    Artist art = new Artist()
                    {
                        Name = song.SongArtist,
                        ID = GetNextIDArtist()
                    };
                    art.IDSongs.Add(song.ID);
                    ListArtists.Add(art);
                    if (ListArtists.Count > 2)
                        SortListArtist();
                }
            });
            insertArtist.Start();
            //insert song to category
            Task insertCatehory = new Task(() =>
            {
                bool ck = false;
                List<string> tmp_genre = new List<string>(song.Genre);
                foreach (SongCategory i in ListCategories)
                {
                    if (tmp_genre.Count == 0)
                        break;
                    if (tmp_genre.IndexOf(i.Name) >= 0)
                    {
                        i.IDSongs.Add(song.ID);
                        tmp_genre.Remove(i.Name);
                        ck = true;
                    }
                }
                if (!ck)
                {
                    foreach (string i in tmp_genre)
                    {
                        SongCategory ctg = new SongCategory()
                        {
                            Name = i,
                            ID = GetNextIDCategory()
                        };
                        ctg.IDSongs.Add(song.ID);
                        ListCategories.Add(ctg);
                    }
                    if (ListCategories.Count > 2)
                        SortListCategory();
                }
            });
            insertCatehory.Start();
            //insert song
            ListSongs.Add(song);
            if (listSongs.Count > 2)
                SortListSong();
            Task.WaitAll(insertAlbum, insertArtist, insertCatehory);
        }
        public void UpdateSong(Song song)
        {
            DeleteSongByID(song.ID);
            InsertSong(song);
            RemoveEmpty();
        }
        #endregion
    }
}
