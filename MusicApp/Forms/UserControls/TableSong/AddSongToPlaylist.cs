using MusicApp.Classes;
using MusicApp.Entitys;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls.TableSong
{
    public partial class AddSongToPlaylist : Form
    {
        private bool dragging;
        private Point startPoint;
        public AddSongToPlaylist()
        {
            InitializeComponent();

            MainForm.RoundedControl(Cbox_Playlist);
            MainForm.RoundedControl(Btn_Close);
            MainForm.RoundedControl(Btn_OK);
            MainForm.RoundedControl(this);

            Cursor = Cursors.WaitCursor;
            Cbox_Playlist.Items.Clear();
            Cbox_Playlist.Items.Add("Play now");
            foreach (var i in MyResources.Resources.ListPlaylists)
            {
                if (i.ID == 0)
                    continue;
                Cbox_Playlist.Items.Add(i.Title);
            }
            Cursor = Cursors.Default;
            if (Cbox_Playlist.Items.Count > 0)
                Cbox_Playlist.SelectedIndex = 0;
        }

        public void SetData(Song song)
        {
            Lb_Header.Text += " " + song.SongTitle;
            Name = song.ID.ToString();
        }

        #region handle default form
        private void Lb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_Close_MouseEnter(object sender, EventArgs e)
        {
            Btn_Close.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void Lb_Close_MouseLeave(object sender, EventArgs e)
        {
            Btn_Close.BackColor = Color.FromArgb(5, 144, 142);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }

        #region handle FormDagging
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #endregion

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Cbox_Playlist.SelectedIndex == 0)
            {
                Song s = MyResources.Resources.MsgSongs.FindSongByID(Convert.ToInt32(Name));
                Playlist p = new Playlist()
                {
                    ID = 0,
                    Title = s.SongTitle
                };
                p.IDSongs.Add(s.ID);
                MyResources.Resources.DeletePlaylistByID(0);
                MyResources.Resources.ListPlaylists.Add(p);
                MyResources.Main.PlayingTab.LoadPlaylist(0);
            }
            else
            {
                var pl = MyResources.Resources.GetPlaylistByTitle(Cbox_Playlist.SelectedItem.ToString());
                pl.IDSongs.Add(Convert.ToInt32(Name));
            }
            Close();
        }
        private void Cbox_DropDownClosed(object sender, EventArgs e)
        {
            Lb_Header.Focus();
        }
    }
}
