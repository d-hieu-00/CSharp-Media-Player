using MusicApp.Classes;
using MusicApp.Entitys;
using MusicApp.Entitys.Video;
using MusicApp.Forms.UserControls.TableVideo;
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
    public partial class VidExplore : UserControl
    {
        public VidExplore()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_Sreach, 3);
            MainForm.RoundedControl(Btn_Reload, 3);
            MainForm.RoundedControl(Btn_PlayAllVideos, 3);
            MainForm.RoundedControl(Cbox_Genre);
            MainForm.RoundedControl(Cbox_Director);
            MainForm.RoundedControl(Cbox_Order);
            MainForm.RoundedControl(PanelWarp_TboxNameSreach, 3);
            MainForm.RoundedControl(Lb_ColDirectors);
            MainForm.RoundedControl(Lb_ColGenre);
            MainForm.RoundedControl(Lb_ColName);
            MainForm.RoundedControl(Lb_ColTime);
            MainForm.RoundedControl(Lb_ColYear);
        }

        public void LoadAllGenre()
        {
            var list = MyResources.Resources.MsgVideos.ListCategories;
            Cbox_Genre.Items.Clear();
            foreach (var i in list)
                Cbox_Genre.Items.Add(i.Name);
        }
        public void LoadAllDirectors()
        {
            var list = MyResources.Resources.MsgVideos.ListDirectors;
            Cbox_Director.Items.Clear();
            foreach (var i in list)
                Cbox_Director.Items.Add(i.Name);
        }
        public void LoadAllVideos()
        {
            var list = MyResources.Resources.MsgVideos.ListVideos;
            FlowPanel_TableVideos.Controls.Clear();
            foreach (var i in list)
            {
                var r = new RowTableVideos();
                r.SetData(i);
                FlowPanel_TableVideos.Controls.Add(r);
            }
        }
        public void LoadAll()
        {
            LoadAllDirectors();
            LoadAllGenre();
            LoadAllVideos();
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
            Lb_ColDirectors.Focus();
        }
        private void Btn_Sreach_Click(object sender, EventArgs e)
        {
            var text = Tbox_NameSearch.Text.Trim().ToLower();
            if (text == "")
                return;
            foreach (Control i in FlowPanel_TableVideos.Controls)
            {
                var t = i.Tag as Video;
                if (t.VideoTitle.ToLower().Contains(text))
                    i.Show();
                else
                    i.Hide();
            }
        }
        private void Cbox_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox_Genre.SelectedIndex < 0)
                return;
            Cbox_Director.SelectedIndex = -1;
            var text = Cbox_Genre.SelectedItem.ToString();
            foreach (Control i in FlowPanel_TableVideos.Controls)
            {
                var t = i.Tag as Video;
                if ((string.Join(", ", t.Genre.ToArray())).Contains(text))
                    i.Show();
                else
                    i.Hide();
            }
        }
        private void Cbox_Director_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox_Director.SelectedIndex < 0)
                return;
            Cbox_Genre.SelectedIndex = -1;
            var text = Cbox_Director.SelectedItem.ToString();
            foreach (Control i in FlowPanel_TableVideos.Controls)
            {
                var t = i.Tag as Video;
                if ((string.Join(", ",t.Directors)).Contains(text))
                    i.Show();
                else
                    i.Hide();
            }
        }
        private void SortByName()
        {
            int i, j;
            int len = FlowPanel_TableVideos.Controls.Count;
            var ctls = FlowPanel_TableVideos.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Video;
                    var tag_j = ctls[j].Tag as Video;
                    if (tag_i.VideoTitle.CompareTo(tag_j.VideoTitle) > 0)
                    {
                        ctls.SetChildIndex(ctls[i], j);
                        ctls.SetChildIndex(ctls[j - 1], i);
                    }
                }
        }
        private void SortByTime()
        {
            int i, j;
            int len = FlowPanel_TableVideos.Controls.Count;
            var ctls = FlowPanel_TableVideos.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Video;
                    var tag_j = ctls[j].Tag as Video;
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
            int len = FlowPanel_TableVideos.Controls.Count;
            var ctls = FlowPanel_TableVideos.Controls;

            for (i = 0; i < len - 1; i++)
                for (j = i + 1; j < len; j++)
                {
                    var tag_i = ctls[i].Tag as Video;
                    var tag_j = ctls[j].Tag as Video;
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
                SortByTime();
            else
                SortByYear();
        }
        private void Btn_PlayAllVideos_Click(object sender, EventArgs e)
        {
            MyResources.Resources.MsgVideos.CreatePlaylistAllVideos();
            MyResources.Main.PlayingTab.LoadPlaylist(0);
        }
    }
}
