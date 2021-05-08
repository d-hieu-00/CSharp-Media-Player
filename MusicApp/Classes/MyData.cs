using AxWMPLib;
using MusicApp.Entitys;
using MusicApp.Entitys.Video;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicApp.Classes
{
    public class MyData
    {
        #region Properties
        private readonly List<FolderImport> listFolders = new List<FolderImport>();
        private readonly List<Playlist> listPlaylists = new List<Playlist>();
        private readonly ManageSongs msgSongs = new ManageSongs();
        private readonly ManageVideos msgVideos = new ManageVideos();
        public int IDNowPlaylist { get; set; }
        public List<FolderImport> ListFolders { get => listFolders; }
        public List<Playlist> ListPlaylists { get => listPlaylists; }
        public ManageSongs MsgSongs { get => msgSongs; }
        public ManageVideos MsgVideos { get => msgVideos; }
        #endregion

        #region get next id of listFolder
        public int GetNextIDFolderImport()
        {
            int _max = 0;
            foreach (FolderImport i in listFolders)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        public int GetNextIDPlaylist()
        {
            int _max = 0;
            foreach (Playlist i in ListPlaylists)
                _max = Math.Max(_max, i.ID);
            return _max + 1;
        }
        #endregion

        #region get FolderImport by ID, reload | get playlist by id
        public FolderImport GetByFolderImportByID(int ID)
        {
            foreach (FolderImport i in ListFolders)
                if (i.ID == ID)
                    return i;
            return null;
        }
        public void ReloadFolder()
        {

            for (int i=0; i<ListFolders.Count; i++)
            {
                string dir = ListFolders[i].Dir;
                RemoveFolderByID(ListFolders[i].ID);
                AddFolderFromPath(dir);
            }
        }
        public Playlist GetPlaylistByID(int ID)
        {
            foreach (Playlist i in ListPlaylists)
                if (i.ID == ID)
                    return i;
            return null;
        }
        public Playlist GetPlaylistByTitile(string Name)
        {
            foreach (Playlist i in ListPlaylists)
                if (i.Title.ToLower() == Name.ToLower())
                    return i;
            return null;
        }

        #endregion

        #region add, remove folder

        // 1: audio file, 2: video file, 0: is not media file
        private int CheckIsFileMediaOrNot(string Name)
        {
            string[] tmp = Name.Split('.');
            string TypeFile = tmp[tmp.Length - 1];
            if (MyResources.ArrayAudioFilter.IndexOf(TypeFile.ToLower()) >= 0)
                return 1;
            if (MyResources.ArrayVideoFilter.IndexOf(TypeFile.ToLower()) >= 0)
                return 2;
            return 0;
        }
        private bool CheckIsDuplicateDir(string dir)
        {
            foreach (FolderImport i in ListFolders)
                if (i.Dir == dir)
                    return true;
            return false;
        }
        public void AddFolderFromPath (string dir)
        {
            //split files
            if (CheckIsDuplicateDir(dir))
                return;
            FolderImport fldImp = new FolderImport()
            {
                ID = GetNextIDFolderImport(),
                Dir = dir
            };
            ListFolders.Add(fldImp);
            List<string> dirAudio = new List<string>();
            List<string> dirVideo = new List<string>();
            foreach (FileInfo i in new DirectoryInfo(dir).GetFiles())
            {
                if (CheckIsFileMediaOrNot(i.Name) == 1)
                    dirAudio.Add(i.FullName);
                else if (CheckIsFileMediaOrNot(i.Name) == 2)
                    dirVideo.Add(i.FullName);
            }
            //add audio
            foreach (string i in dirAudio)
            {
                int id = MsgSongs.GetNextIDSong();
                Song tmp = new Song()
                {
                    FullDir = i,
                    ID = id
                };
                var t = tmp.GetInfo();
                if (t == false)
                    continue;
                

                MsgSongs.InsertSong(tmp);
                fldImp.IDSong.Add(id);
            }
            //add video
            foreach (string i in dirVideo)
            {
                int id = MsgVideos.GetNextIDVideo();
                Video tmp = new Video()
                {
                    FullDir = i,
                    ID = id
                };
                var t = tmp.GetInfo();
                if (t == false)
                    continue;
                MsgVideos.InsertVideo(tmp);
                fldImp.IDVideo.Add(id);
            }
            //sort
            fldImp.SortListSong();
            fldImp.SortListVideo();
            MsgSongs.SortListSong();
            MsgSongs.SortListAlbum();
            MsgSongs.SortListArtist();
            MsgSongs.SortListCategory();
            MsgVideos.SortListVideo();
            MsgVideos.SortListCategory();
        }
        public void RemoveFolderByID(int ID)
        {
            FolderImport fldImp = GetByFolderImportByID(ID);
            foreach (int i in fldImp.IDSong)
                MsgSongs.DeleteSongByID(i);
            foreach (int i in fldImp.IDVideo)
                MsgVideos.DeleteVideoByID(i);
            ListFolders.Remove(fldImp);
            MyResources.Main.SettingTab.LoadDataTable();
        }
        #endregion

        #region del, insert, update playlist (have handle in nowplaylist)
        // delele playlist
        public void DeletePlaylistByID(int ID)
        {
            foreach (Playlist i in ListPlaylists)
            {
                if (i.ID == ID)
                {
                    ListPlaylists.Remove(i);
                    break;
                }
            }
        }
        // insert playlist
        private bool CheckDuplicateNamePlaylist(string name)
        {
            foreach (var i in ListPlaylists)
                if (i.Title == name)
                    return true;
            return false;
        }
        public int InsertPlaylist(string name)
        {
            if (CheckDuplicateNamePlaylist(name))
                return -1;
            int id = GetNextIDPlaylist();
            ListPlaylists.Add(new Playlist()
            {
                Title = name,
                ID = id
            });
            return id;
        }
        // delete video in playlist
        private void DeleteVideoInPlaylist(int IDPlaylist, int IDVideo)
        {
            foreach (Playlist i in ListPlaylists)
            {
                if (i.ID == IDPlaylist)
                {
                    i.IDVideos.Remove(IDVideo);
                    break;
                }
            }
        }
        // delete video in playlist
        private void DeleteSongInPlaylist(int IDPlaylist, int IDSong)
        {
            foreach (Playlist i in ListPlaylists)
            {
                if (i.ID == IDPlaylist)
                {
                    i.IDSongs.Remove(IDSong);
                    break;
                }
            }
        }
        // insert video to playlist
        public void InsertVideoToPlaylist(int IDPlaylist, int IDVideo)
        {
            foreach (Playlist i in ListPlaylists)
            {
                if (i.ID == IDPlaylist)
                {
                    i.IDVideos.Add(IDVideo);
                    break;
                }
            }
        }
        // insert song to playlist
        public void InsertSongToPlaylist(int IDPlaylist, int IDSong)
        {
            foreach (Playlist i in ListPlaylists)
            {
                if (i.ID == IDPlaylist)
                {
                    i.IDSongs.Add(IDSong);
                    break;
                }
            }
        }
        // update Name playlist
        public void UpdateNamePlaylist(int ID, string NamePlaylist)
        {
            foreach (Playlist i in ListPlaylists)
            {
                if (i.ID == ID)
                {
                    i.Title = NamePlaylist;
                    break;
                }
            }
        }
        // delete video, song in playlist
        public void DeleteItemInPlaylistID(int ID_Playlist, int ID_item, string type)
        {
            if (type == "song")
                DeleteSongInPlaylist(ID_Playlist, ID_item);
            else
                DeleteVideoInPlaylist(ID_Playlist, ID_item);
        }
        // insert song, video to playist
        public void InsertItemToPlaylistID(int ID_Playlist, int ID_item, string type)
        {
            if (type == "song")
                InsertSongToPlaylist(ID_Playlist, ID_item);
            else
                InsertVideoToPlaylist(ID_Playlist, ID_item);
        }
        #endregion
    }
}
