using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.Classes;
using MusicApp.Entitys;
using MusicApp.Forms.UserControls.TablePlaylist;

namespace MusicApp.Forms.UserControls.TabPanel
{
    public partial class Playlists : UserControl
    {
        public Playlists()
        {
            InitializeComponent();

            //rounded
            MainForm.RoundedControl(Btn_Create, 3);
            MainForm.RoundedControl(Btn_Reload, 3);
            MainForm.RoundedControl(Btn_Search, 3);
            MainForm.RoundedControl(Lb_ColNameListPlaylist);
            MainForm.RoundedControl(Lb_NameInfoPlaylist);
            MainForm.RoundedControl(Lb_TimeInfoPlaylist);
            MainForm.RoundedControl(Lb_HeaderListPlaylist);
            MainForm.RoundedControl(Lb_HeaderPlaylistInfo);
            MainForm.RoundedControl(PanelWarp_TboxNameCreate, 2);
            MainForm.RoundedControl(PanelWarp_TboxNameSreach, 2);
        }

        public void RemovePlaylistByID(int ID)
        {
            foreach (RowPlaylist i in FlowPanel_ListPlaylist.Controls)
                if (i.GetID() == ID)
                {
                    FlowPanel_ListPlaylist.Controls.Remove(i);
                    return;
                }
        }
        public void UpdatePlaylistByID(int ID, string Name)
        {
            foreach (RowPlaylist i in FlowPanel_ListPlaylist.Controls)
                if (i.GetID() == ID)
                {
                    i.SetData(Name, ID.ToString());
                    return;
                }
        }
        public void LoadAllPlaylist()
        {
            MyResources.Main.SetCursorLoading();
            FlowPanel_ListPlaylist.Controls.Clear();
            foreach (var i in MyResources.Resources.ListPlaylists)
            {
                if (i.ID == 0)
                    continue;
                var r = new RowPlaylist();
                r.SetData(i.Title, i.ID.ToString());
                FlowPanel_ListPlaylist.Controls.Add(r);
            }
            MyResources.Main.SetCursorDefault();
        }
        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            LoadAllPlaylist();
            Lb_ColNameListPlaylist.Focus();
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var text = Tbox_NameSearch.Text.Trim();
            text = text.ToLower();
            if (text == "")
            {
                MyResources.Main.SetCursorDefault();
                return;
            }

            foreach (var i in FlowPanel_ListPlaylist.Controls)
            {
                var c = i as Control;
                if (c.Name.ToLower().Contains(text))
                    c.Show();
                else
                    c.Hide();
            }
            Lb_ColNameListPlaylist.Focus();
            MyResources.Main.SetCursorDefault();
        }
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var text = Tbox_NameCreate.Text.Trim();
            if (text == "")
            {
                MyResources.Main.SetCursorDefault();
                MessageBox.Show("Name is null !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = MyResources.Resources.InsertPlaylist(text);
            if (id < 0)
            {
                MyResources.Main.SetCursorDefault();
                MessageBox.Show("Name is duplicate !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var r = new RowPlaylist();
                r.SetData(text, id.ToString());
                FlowPanel_ListPlaylist.Controls.Add(r);
            }
            Lb_ColNameListPlaylist.Focus();
            MyResources.Main.SetCursorDefault();
        }
        public void RemoveSelectedPlaylist()
        {
            foreach(RowPlaylist i in FlowPanel_ListPlaylist.Controls)
                if (i.CheckSelected())
                {
                    i.RemoveSelected();
                    return;
                }
        }
        public void RemovePlayplistPlaying()
        {
            foreach (RowPlaylist i in FlowPanel_ListPlaylist.Controls)
                if (i.CheckPlayingPlaylist())
                {
                    i.RemovePlayingPlaylist();
                    return;
                }
        }
        public void RemoveItemInfo()
        {
            foreach (Control i in FlowPanel_ListInfoPlaylist.Controls)
                if (i.Name == "del")
                {
                    FlowPanel_ListInfoPlaylist.Controls.Remove(i);
                    return;
                }
        }
        public void LoadPlaylistInfoByID(int ID)
        {
            Playlist tmp = MyResources.Resources.GetPlaylistByID(ID);
            var listDic =  tmp.GetPlayingListDic();
            FlowPanel_ListInfoPlaylist.Controls.Clear();
            foreach (var i in listDic)
            {
                RowInfoPlaylist r = new RowInfoPlaylist();
                i.Add("id_playlist", ID.ToString());
                r.SetData(i);
                FlowPanel_ListInfoPlaylist.Controls.Add(r);
            }
        }

        private void Timer_CheckPlayingPlaylist_Tick(object sender, EventArgs e)
        {
            string typePlaying = MyResources.Main.PlayingTab.TypePlaying;
            if (typePlaying != null && typePlaying == "playlist")
            {
                RemovePlayplistPlaying();
                foreach (RowPlaylist i in FlowPanel_ListPlaylist.Controls)
                    if (i.GetID() == MyResources.Resources.IDNowPlaylist)
                    {
                        i.SetPlayingPlaylist();
                        return;
                    }
            }
            else
                RemovePlayplistPlaying();
        }
    }
}
