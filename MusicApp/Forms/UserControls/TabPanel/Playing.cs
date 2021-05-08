using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicApp.Classes;
using MusicApp.Forms.UserControls.TableNowPLaylist;
using MusicApp.Entitys;

namespace MusicApp.Forms.UserControls.TabPanel
{
    public partial class Playing : UserControl
    {
        public List<Dictionary<string, string>> NowPlaylist { get; set; }
        public string TypePlaying { get; set; }
        //public int IndexMediaPlaying { get; }
        public Playing()
        {
            InitializeComponent();
            MainForm.RoundedControl(Lb_Title, 3);
            MainForm.RoundedControl(Lb_Duration, 3);
            MainForm.RoundedControl(Lb_Name, 3);
            MainForm.RoundedControl(Btn_Reload, 3);
            FlowPanel_Header.Width = 0;
            WMP_Media.Focus();
        }
        public AxWindowsMediaPlayer GetMediaPlayer()
        {
            return WMP_Media;
        }
        public int GetIndexMediaPLaying()
        {
            foreach (Control i in FlowPanel_Playlist.Controls)
                if (i.Name == "Playing")
                    return NowPlaylist.IndexOf((i as RowTableNowPLaylist).GetTag());
            return -2;
        }
        public void TogglePlaylistPanel()
        {
            if (FlowPanel_Header.Width != 0)
                FlowPanel_Header.Width = 0;
            else
                FlowPanel_Header.Width = 403;
        }
        public void RemovePlaying()
        {
            foreach (Control i in FlowPanel_Playlist.Controls)
                if (i.Name == "Playing")
                {
                    (i as RowTableNowPLaylist).SetNotPlaying();
                    break;
                }
        }
        public void SetNewPlayingByIndex(int index)
        {
            var newItemPlaying = (FlowPanel_Playlist.Controls[index] as RowTableNowPLaylist);
            newItemPlaying.SetPLaying();
        }
        public void LoadPlaylist(int ID)
        {
            Playlist tmp = MyResources.Resources.GetPlaylistByID(ID);
            if (tmp == null)
            {
                WMP_Media.URL = null;
                FlowPanel_Playlist.Controls.Clear();
                MyResources.Resources.IDNowPlaylist = 0;
                NowPlaylist = null;
                return;
            }
            List<Dictionary<string, string>> list = tmp.GetPlayingListDic();
            NowPlaylist = list;
            if (list.Count == 0)
                WMP_Media.URL = null;
            MyResources.Resources.IDNowPlaylist = ID;
            FlowPanel_Playlist.Controls.Clear();
            for (int i=0; i< list.Count; i++)
            {
                RowTableNowPLaylist r = new RowTableNowPLaylist();
                r.SetData(list[i]);
                if (i == 0)
                    r.SetPLaying();
                else
                    r.SetNotPlaying();
                FlowPanel_Playlist.Controls.Add(r);
            }
            TypePlaying = "playlist";
        }
        public void LoadSongAlbum(int ID)
        {
            List<Dictionary<string, string>> list = MyResources.Resources.MsgSongs.FindSongsByAlbumID(ID);
            if (list == null)
            {
                WMP_Media.URL = null;
                FlowPanel_Playlist.Controls.Clear();
                MyResources.Resources.IDNowPlaylist = 0;
                NowPlaylist = null;
                return;
            }
            MyResources.Resources.IDNowPlaylist = ID;
            FlowPanel_Playlist.Controls.Clear();
            // if album null
            if (list.Count == 0)
                WMP_Media.URL = null;
            for (int i = 0; i < list.Count; i++)
            {
                RowTableNowPLaylist r = new RowTableNowPLaylist();
                r.SetData(list[i]);
                if (i == 0)
                    r.SetPLaying();
                else
                    r.SetNotPlaying();
                FlowPanel_Playlist.Controls.Add(r);
            }
            TypePlaying = "album";
        }
        public void DeleteItemInNowPlaylist()
        {
            bool IsDelNowPlaying = true;
            foreach (Control i in FlowPanel_Playlist.Controls)
            {
                if (i.Name == "Playing")
                    IsDelNowPlaying = false;
                if (i.Name == "Del")
                {
                    FlowPanel_Playlist.Controls.Remove(i);
                    NowPlaylist.Remove((i as RowTableNowPLaylist).GetTag());
                }
            }
            if (IsDelNowPlaying)
            {
                RowTableNowPLaylist r = FlowPanel_Playlist.Controls[0] as RowTableNowPLaylist;
                r.SetPLaying();
            }
        }
        public void InsertItemInNowPlaylist(Dictionary<string, string> item)
        {
            RowTableNowPLaylist r = new RowTableNowPLaylist();
            r.SetData(item);
            r.SetNotPlaying();
            FlowPanel_Playlist.Controls.Add(r);
            NowPlaylist.Add(item);
        }
        private bool CheckDiffPlaylist(List<Dictionary<string, string>> list)
        {
            List<Dictionary<string, string>> tmp1 = new List<Dictionary<string, string>>();
            List<Dictionary<string, string>> tmp2 = new List<Dictionary<string, string>>();
            tmp1.AddRange(list);
            tmp2.AddRange(NowPlaylist);
            foreach (var i in list)
                foreach (var j in NowPlaylist)
                    if (i["dir"] == j["dir"])
                    {
                        tmp1.Remove(i);
                        tmp2.Remove(j);
                    }

            if (tmp1.Count == 0 && tmp2.Count == 0)
                return false;
            // check insert
            if (tmp1.Count > 0)
                foreach (var i in tmp1)
                    NowPlaylist.Add(i);
            // check delete
            if (tmp2.Count > 0)
                foreach (var i in tmp2)
                    NowPlaylist.Remove(i);
            return true;
        }
        public void SwapItemPlaylistControls(int index1, int index2)
        {
            FlowPanel_Playlist.Controls.SetChildIndex(FlowPanel_Playlist.Controls[index1], index2);
            if (index1 > index2)
                index2 += 1;
            else
                index2 -= 1;
            FlowPanel_Playlist.Controls.SetChildIndex(FlowPanel_Playlist.Controls[index2], index1);
        }
        public void ReloadPlaylistByID()
        {
            List<Dictionary<string, string>> list;
            if (TypePlaying == "playlist")
            {
                Playlist tmp = MyResources.Resources.GetPlaylistByID(MyResources.Resources.IDNowPlaylist);
                list = tmp.GetPlayingListDic();
            }
            else
            {
                list = MyResources.Resources.MsgSongs.FindSongsByAlbumID(MyResources.Resources.IDNowPlaylist);
            }
            bool IsControlNowPlayingDeleted = false;
            RowTableNowPLaylist NowPlaying = FlowPanel_Playlist.Controls[0] as RowTableNowPLaylist;

            if (!CheckDiffPlaylist(list))
                return;

            FlowPanel_Playlist.Controls.Clear();
            if (list.IndexOf(NowPlaying.GetTag()) < 0)
                IsControlNowPlayingDeleted = true;
            else
            {
                list.Remove(NowPlaying.GetTag());
                FlowPanel_Playlist.Controls.Add(NowPlaying);
            }


            for (int i = 0; i < list.Count; i++)
            {
                RowTableNowPLaylist r = new RowTableNowPLaylist();
                r.SetData(list[i]);
                if (i == 0 && IsControlNowPlayingDeleted)
                    r.SetPLaying();
                else
                    r.SetNotPlaying();
                FlowPanel_Playlist.Controls.Add(r);
            }
        }
        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            if (NowPlaylist == null)
                return;
            ReloadPlaylistByID();
            WMP_Media.Focus();
            MyResources.Main.SetCursorDefault();
        }

        private void Timer_SetStatus_Tick(object sender, EventArgs e)
        {
            if (NowPlaylist != null)
            {
                string status = "No playing";
                foreach (RowTableNowPLaylist i in FlowPanel_Playlist.Controls)
                    if (i.Name == "Playing")
                    {
                        Dictionary<string, string> t = i.Tag as Dictionary<string, string>;
                        status = t["type"] + ": " + t["name"];
                        var f = status.Substring(0, 1).ToUpper();
                        status = f + status.Substring(1, status.Length - 1);
                        break;
                    }
                MyResources.Main.SetStatus(status);
            }
        }
    }
}
