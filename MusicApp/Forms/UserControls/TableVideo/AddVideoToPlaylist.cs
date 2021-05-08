using MusicApp.Classes;
using MusicApp.Entitys;
using MusicApp.Entitys.Video;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls.TableVideo
{
    public partial class AddVideoToPlaylist : Form
    {
        private bool dragging;
        private Point startPoint;
        public AddVideoToPlaylist()
        {
            InitializeComponent();

            MainForm.RoundedControl(Cbox_Playlist);
            MainForm.RoundedControl(Btn_Close);
            MainForm.RoundedControl(Btn_OK);
            MainForm.RoundedControl(this);

            Cursor = Cursors.WaitCursor;
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

        public void SetData(Video video)
        {
            Lb_Header.Text += " " + video.VideoTitle;
            Name = video.ID.ToString();
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
            var pl = MyResources.Resources.GetPlaylistByTitile(Cbox_Playlist.SelectedItem.ToString());
            pl.IDVideos.Add(Convert.ToInt32(Name));
            Close();
        }
    }
}
