using MusicApp.Classes;
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
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_Playing);
            MainForm.RoundedControl(Btn_About);
            MainForm.RoundedControl(Btn_Setting);
            MainForm.RoundedControl(Btn_SongAlbum);
            MainForm.RoundedControl(Btn_SongExplore);
            MainForm.RoundedControl(Btn_Playlist);
            MainForm.RoundedControl(Btn_VidExplore);
            PicboxLogo.Focus();
        }

        private void ResetFontBtn()
        {
            Btn_Playing.Font = new Font(Btn_Playing.Font, FontStyle.Regular);
            Btn_About.Font = new Font(Btn_About.Font, FontStyle.Regular);
            Btn_Setting.Font = new Font(Btn_Setting.Font, FontStyle.Regular);
            Btn_SongAlbum.Font = new Font(Btn_SongAlbum.Font, FontStyle.Regular);
            Btn_SongExplore.Font = new Font(Btn_SongExplore.Font, FontStyle.Regular);
            Btn_Playlist.Font = new Font(Btn_Playlist.Font, FontStyle.Regular);
            Btn_VidExplore.Font = new Font(Btn_VidExplore.Font, FontStyle.Regular);
        }

        private void PicboxLogo_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(MyResources.linkProfile);
        }

        private void Btn_Playing_Click(object sender, EventArgs e)
        {
            ResetFontBtn();
            var c = (sender as Control);
            c.Font = new Font(c.Font, FontStyle.Bold);
            MyResources.Main.Btn_Playing_Click();
            PicboxLogo.Focus();
        }

        private void Btn_Playlist_Click(object sender, EventArgs e)
        {
            ResetFontBtn();
            var c = (sender as Control);
            c.Font = new Font(c.Font, FontStyle.Bold);
            MyResources.Main.Btn_Playlist_Click();
            PicboxLogo.Focus();
        }

        private void Btn_SongExplore_Click(object sender, EventArgs e)
        {
            ResetFontBtn();
            var c = (sender as Control);
            c.Font = new Font(c.Font, FontStyle.Bold);
            MyResources.Main.Btn_SongExplore_Click();
            PicboxLogo.Focus();
        }

        private void Btn_SongAlbum_Click(object sender, EventArgs e)
        {
            ResetFontBtn();
            var c = (sender as Control);
            c.Font = new Font(c.Font, FontStyle.Bold);
            MyResources.Main.Btn_SongAlbum_Click();
            PicboxLogo.Focus();
        }

        private void Btn_VidExplore_Click(object sender, EventArgs e)
        {
            ResetFontBtn();
            var c = (sender as Control);
            c.Font = new Font(c.Font, FontStyle.Bold);
            MyResources.Main.Btn_VidExplore_Click();
            PicboxLogo.Focus();
        }
        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            ResetFontBtn();
            var c = (sender as Control);
            c.Font = new Font(c.Font, FontStyle.Bold);
            MyResources.Main.Btn_Setting_Click();
            PicboxLogo.Focus();
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            ResetFontBtn();
            var c = (sender as Control);
            c.Font = new Font(c.Font, FontStyle.Bold);
            MyResources.Main.Btn_About_Click();
            PicboxLogo.Focus();
        }
    }

}
