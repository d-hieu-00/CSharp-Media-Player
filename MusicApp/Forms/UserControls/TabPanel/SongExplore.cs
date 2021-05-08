using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MusicApp.Classes;
using MusicApp.Entitys;
using MusicApp.Forms.UserControls.TableSong;

namespace MusicApp.Forms.UserControls
{
    public partial class SongExplore : UserControl
    {
        public SongExplore()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_Sreach, 3);
            MainForm.RoundedControl(Btn_Reload, 3);
            MainForm.RoundedControl(Btn_PlayAllSongs, 3);
            MainForm.RoundedControl(Cbox_Genre);
            MainForm.RoundedControl(Cbox_Artist);
            MainForm.RoundedControl(Cbox_Order);
            MainForm.RoundedControl(PanelWarp_TboxNameSreach, 3);
            MainForm.RoundedControl(Lb_ColArtist);
            MainForm.RoundedControl(Lb_ColGenre);
            MainForm.RoundedControl(Lb_ColName);
            MainForm.RoundedControl(Lb_ColTime);
            MainForm.RoundedControl(Lb_ColYear);
        }

        public void LoadAllGenre()
        {
            var list = MyResources.Resources.MsgSongs.ListCategories;
            Cbox_Genre.Items.Clear();
            foreach (var i in list)
                Cbox_Genre.Items.Add(i.Name);
        }
        public void LoadAllArtist()
        {
            var list = MyResources.Resources.MsgSongs.ListArtists;
            Cbox_Artist.Items.Clear();
            foreach (var i in list)
                Cbox_Artist.Items.Add(i.Name);
        }

        public void LoadAllSongs()
        {
            var list = MyResources.Resources.MsgSongs.ListSongs;
            FlowPanel_TableSongs.Controls.Clear();
            foreach(var i in list)
            {
                var r = new RowTableSongs();
                r.SetData(i);
                FlowPanel_TableSongs.Controls.Add(r);
            }
        }

        public void LoadAll()
        {
            LoadAllArtist();
            LoadAllGenre();
            LoadAllSongs();
        }
        private void Cbox_DropDownClosed(object sender, EventArgs e)
        {
            Lb_Header.Focus();
        }

        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            LoadAll();
            MyResources.Main.SetCursorDefault();
            Lb_Artist.Focus();
        }

        private void Btn_Sreach_Click(object sender, EventArgs e)
        {
            var text = Tbox_NameSearch.Text.Trim().ToLower();
            if (text == "")
                return;
            foreach (Control i in FlowPanel_TableSongs.Controls)
            {
                var t = i.Tag as Song;
                if (t.SongTitle.ToLower().Contains(text))
                    i.Show();
                else
                    i.Hide();
            }
        }

        private void Cbox_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox_Genre.SelectedIndex < 0)
                return;
            Cbox_Artist.SelectedIndex = -1;
            var text = Cbox_Genre.SelectedItem.ToString();
            foreach (Control i in FlowPanel_TableSongs.Controls)
            {
                var t = i.Tag as Song;
                if ((string.Join(", ", t.Genre.ToArray())).Contains(text))
                    i.Show();
                else
                    i.Hide();
            }
        }

        private void Cbox_Artist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox_Artist.SelectedIndex < 0)
                return;
            Cbox_Genre.SelectedIndex = -1;
            var text = Cbox_Artist.SelectedItem.ToString();
            foreach (Control i in FlowPanel_TableSongs.Controls)
            {
                var t = i.Tag as Song;
                if (t.SongArtist.Contains(text))
                    i.Show();
                else
                    i.Hide();
            }
        }

        private void SortByName()
        {
            int i, j;
            int len = FlowPanel_TableSongs.Controls.Count;
            var ctls = FlowPanel_TableSongs.Controls;

            for (i = 0; i < len-1; i++)
                for (j=i+1; j<len; j++)
                {
                    var tag_i = ctls[i].Tag as Song;
                    var tag_j = ctls[j].Tag as Song;
                    if (tag_i.SongTitle.CompareTo(tag_j.SongTitle) > 0)
                    {
                        ctls.SetChildIndex(ctls[i], j);
                        ctls.SetChildIndex(ctls[j - 1], i);
                    }
                }
        }
        private void SortByArtist()
        {
            int i, j;
            int len = FlowPanel_TableSongs.Controls.Count;
            var ctls = FlowPanel_TableSongs.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Song;
                    var tag_j = ctls[j].Tag as Song;
                    if (tag_i.SongArtist.CompareTo(tag_j.SongArtist) > 0)
                    {
                        ctls.SetChildIndex(ctls[i], j);
                        ctls.SetChildIndex(ctls[j - 1], i);
                    }
                }
        }
        private void SortByTime()
        {
            int i, j;
            int len = FlowPanel_TableSongs.Controls.Count;
            var ctls = FlowPanel_TableSongs.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Song;
                    var tag_j = ctls[j].Tag as Song;
                    if (tag_i.Duration.CompareTo(tag_j.Duration) > 0)
                    {
                        ctls.SetChildIndex(ctls[i], j);
                        ctls.SetChildIndex(ctls[j - 1], i);
                    }
                }
        }
        private void SortByYear()
        {
            int i, j;
            int len = FlowPanel_TableSongs.Controls.Count;
            var ctls = FlowPanel_TableSongs.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Song;
                    var tag_j = ctls[j].Tag as Song;
                    if (tag_i.Year > tag_j.Year)
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
            else if (Cbox_Order.SelectedIndex == 2)
                SortByTime();
            else
                SortByYear();
        }

        private void Btn_PlayAllSongs_Click(object sender, EventArgs e)
        {
            MyResources.Resources.MsgSongs.CreatePlaylistAllSongs();
            MyResources.Main.PlayingTab.LoadPlaylist(0);
        }
    }
}
