using MusicApp.Classes;
using MusicApp.Entitys;
using MusicApp.Forms.UserControls.TableSongAlbum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls
{
    public partial class SongAlbum : UserControl
    {
        public SongAlbum()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_Reload, 3);
            MainForm.RoundedControl(Btn_Search, 3);
            MainForm.RoundedControl(Lb_ColNameListAlbum);
            MainForm.RoundedControl(Lb_HeaderAlbumInfo);
            MainForm.RoundedControl(Lb_HeaderListAlbum);
            MainForm.RoundedControl(Lb_NameInfoAlbum);
            MainForm.RoundedControl(Lb_TimeInfoAlbum);
            MainForm.RoundedControl(Lb_ColArtist);
            MainForm.RoundedControl(Cbox_Artist);
            MainForm.RoundedControl(Cbox_Order);
            MainForm.RoundedControl(PanelWarp_TboxNameSreach, 2);
        }
        public void LoadAllSongAlbum()
        {
            MyResources.Main.SetCursorLoading();
            FlowPanel_ListAlbum.Controls.Clear();
            foreach (var i in MyResources.Resources.MsgSongs.ListAlbums)
            {
                if (i.ID == 0)
                    continue;
                var r = new RowSongAlbum();
                r.SetData(i);
                FlowPanel_ListAlbum.Controls.Add(r);
            }
            MyResources.Main.SetCursorDefault();
        }
        public void LoadAllSongArtist()
        {
            MyResources.Main.SetCursorLoading();
            Cbox_Artist.Items.Clear();
            foreach (var i in MyResources.Resources.MsgSongs.ListArtists)
                Cbox_Artist.Items.Add(i.Name);
            MyResources.Main.SetCursorDefault();
        }
        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            LoadAllSongAlbum();
            LoadAllSongArtist();
            Lb_ColArtist.Focus();
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

            foreach (var i in FlowPanel_ListAlbum.Controls)
            {
                var c = i as Control;
                if (c.Name.ToLower().Contains(text))
                    c.Show();
                else
                    c.Hide();
            }
            Lb_ColArtist.Focus();
            MyResources.Main.SetCursorDefault();
        }
        public void RemoveSelectedAlbum()
        {
            foreach (RowSongAlbum i in FlowPanel_ListAlbum.Controls)
                if (i.CheckSelected())
                {
                    i.RemoveSelected();
                    return;
                }
        }
        public void RemoveAlbumPlaying()
        {
            foreach (RowSongAlbum i in FlowPanel_ListAlbum.Controls)
                if (i.CheckPlayingAlbum())
                {
                    i.RemovePlayingAlbum();
                    return;
                }
        }
        public void LoadAlbumInfoByID(int ID)
        {
            var listDic = MyResources.Resources.MsgSongs.FindSongsByAlbumID(ID);
            FlowPanel_ListInfoAlbum.Controls.Clear();
            foreach (var i in listDic)
            {
                RowInfoSongAlbum r = new RowInfoSongAlbum();
                r.SetData(i);
                FlowPanel_ListInfoAlbum.Controls.Add(r);
            }
        }
        private void SortByName()
        {
            int i, j;
            int len = FlowPanel_ListAlbum.Controls.Count;
            var ctls = FlowPanel_ListAlbum.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Album;
                    var tag_j = ctls[j].Tag as Album;
                    if (tag_i.Name.CompareTo(tag_j.Name) > 0)
                    {
                        ctls.SetChildIndex(ctls[i], j);
                        ctls.SetChildIndex(ctls[j - 1], i);
                    }
                }
        }
        private void SortByArtist()
        {
            int i, j;
            int len = FlowPanel_ListAlbum.Controls.Count;
            var ctls = FlowPanel_ListAlbum.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Album;
                    var tag_j = ctls[j].Tag as Album;
                    if (tag_i.AlbumArtist.CompareTo(tag_j.AlbumArtist) > 0)
                    {
                        ctls.SetChildIndex(ctls[i], j);
                        ctls.SetChildIndex(ctls[j - 1], i);
                    }
                }
        }
        private void Cbox_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox_Order.SelectedIndex == 0)
                SortByName();
            else if (Cbox_Order.SelectedIndex == 1)
                SortByArtist();
        }
        private void Cbox_Artist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox_Artist.SelectedIndex < 0)
                return;
            var text = Cbox_Artist.SelectedItem.ToString();
            foreach (Control i in FlowPanel_ListAlbum.Controls)
            {
                var t = i.Tag as Album;
                if (t.AlbumArtist.Contains(text))
                    i.Show();
                else
                    i.Hide();
            }
        }
        private void Cbox_DropDownClosed(object sender, EventArgs e)
        {
            Lb_Artist.Focus();
        }
        private void Timer_CheckPlayingAlbum_Tick(object sender, EventArgs e)
        {
            string typePlaying = MyResources.Main.PlayingTab.TypePlaying;
            if (typePlaying != null && typePlaying == "album")
            {
                RemoveAlbumPlaying();
                foreach (RowSongAlbum i in FlowPanel_ListAlbum.Controls)
                    if (i.GetID() == MyResources.Resources.IDNowPlaylist)
                    {
                        i.SetPlayingAlbum();
                        return;
                    }
            }
            else
                RemoveAlbumPlaying();
        }
    }
}
