using MusicApp.Classes;
using MusicApp.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls.TableSongAlbum
{
    public partial class RowSongAlbum : UserControl
    {
        public RowSongAlbum()
        {
            InitializeComponent();
            MainForm.RoundedControl(Lb_Name, 3);
            MainForm.RoundedControl(Lb_Artist, 3);
            MainForm.RoundedControl(Btn_Play, 3);
        }
        public int GetID()
        {
            return Convert.ToInt32((Tag as Album).ID);
        }
        public bool CheckSelected()
        {
            if (Lb_Name.BackColor == Color.FromArgb(87, 198, 157))
                return false;
            return true;
        }
        public void RemoveSelected()
        {
            Lb_Name.BackColor = Color.FromArgb(87, 198, 157);
            Lb_Artist.BackColor = Color.FromArgb(87, 198, 157);
        }
        public void SetSelected()
        {
            Lb_Name.BackColor = Color.FromArgb(4, 170, 109);
            Lb_Artist.BackColor = Color.FromArgb(4, 170, 109);
        }
        public void SetData(Album album)
        {
            Tag = album;
            Lb_Name.Text = album.Name;
            Lb_Artist.Text = album.AlbumArtist;
            Name = album.Name;
        }
        private void Lb_Name_Click(object sender, EventArgs e)
        {
            if (CheckSelected())
                return;
            MyResources.Main.SetCursorLoading();
            MyResources.Main.SongAblumTab.LoadAlbumInfoByID(GetID());
            MyResources.Main.SongAblumTab.RemoveSelectedAlbum();
            SetSelected();
            Lb_Name.Focus();
            MyResources.Main.SetCursorDefault();
        }
        public bool CheckPlayingAlbum()
        {
            return Btn_Play.Name == "play";
        }
        public void RemovePlayingAlbum()
        {
            Btn_Play.BackgroundImage = Properties.Resources.play_button;
            Btn_Play.Name = "";
            Btn_Play.Enabled = true;
        }
        public void SetPlayingAlbum()
        {
            Btn_Play.BackgroundImage = Properties.Resources.music_track;
            Btn_Play.Name = "play";
            Btn_Play.Enabled = false;
        }
        private void Btn_Play_Click(object sender, EventArgs e)
        {
            MyResources.Main.PlayingTab.LoadSongAlbum(GetID());
            MyResources.Main.SongAblumTab.RemoveAlbumPlaying();
            SetPlayingAlbum();
            Lb_Name.Focus();
        }
    }
}
