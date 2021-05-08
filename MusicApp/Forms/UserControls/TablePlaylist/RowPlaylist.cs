using System;
using System.Drawing;
using System.Windows.Forms;
using MusicApp.Classes;

namespace MusicApp.Forms.UserControls.TablePlaylist
{
    public partial class RowPlaylist : UserControl
    {
        public RowPlaylist()
        {
            InitializeComponent();

            MainForm.RoundedControl(Btn_Del, 3);
            MainForm.RoundedControl(Btn_Edit, 3);
            MainForm.RoundedControl(Lb_Name, 3);
            MainForm.RoundedControl(Btn_Play, 3);
        }

        public int GetID()
        {
            return Convert.ToInt32(Btn_Del.Name);
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
        }

        public void SetSelected()
        {
            Lb_Name.BackColor = Color.FromArgb(4, 170, 109);
        }

        public void SetData(string Name, string ID)
        {
            Lb_Name.Text = Name;
            Btn_Edit.Name = ID;
            Btn_Del.Name = ID;
            this.Name = Name;
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            MyResources.Resources.DeletePlaylistByID(Convert.ToInt32(Btn_Del.Name));
            MyResources.Main.PlaylistTab.RemovePlaylistByID(GetID());
            Lb_Name.Focus();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            EditPlaylist edit = new EditPlaylist();
            edit.SetData(Convert.ToInt32(Btn_Edit.Name), Name);
            edit.ShowDialog();
            Lb_Name.Focus();
        }

        private void Lb_Name_Click(object sender, EventArgs e)
        {
            if (CheckSelected())
                return;
            MyResources.Main.SetCursorLoading();
            MyResources.Main.PlaylistTab.LoadPlaylistInfoByID(GetID());
            MyResources.Main.PlaylistTab.RemoveSelectedPlaylist();
            SetSelected();
            Lb_Name.Focus();
            MyResources.Main.SetCursorDefault();
        }
        public bool CheckPlayingPlaylist()
        {
            return Btn_Play.BackgroundImage == Properties.Resources.music_track;
        }
        public void RemovePlayingPlaylist()
        {
            Btn_Play.BackgroundImage = Properties.Resources.play_button;
            Btn_Play.Enabled = true;
        }

        public void SetPlayingPlaylist()
        {
            Btn_Play.BackgroundImage = Properties.Resources.music_track;
            Btn_Play.Enabled = false;
        }
        private void Btn_Play_Click(object sender, EventArgs e)
        {
            if (CheckPlayingPlaylist())
                return;
            MyResources.Main.PlayingTab.LoadPlaylist(GetID());
            SetPlayingPlaylist();
            Lb_Name.Focus();
        }
    }
}
