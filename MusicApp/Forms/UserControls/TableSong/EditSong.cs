using MusicApp.Entitys;
using System;
using System.Drawing;
using System.Windows.Forms;
using MusicApp.Classes;
using System.Collections.Generic;

namespace MusicApp.Forms.UserControls.TableSong
{
    public partial class EditSong : Form
    {
        private bool dragging;
        private Point startPoint;
        public EditSong()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_Close);
            MainForm.RoundedControl(Btn_OK);
            MainForm.RoundedControl(this);
            MainForm.RoundedControl(PanelWarp_NumYear);
            MainForm.RoundedControl(PanelWarp_TboxAlbum);
            MainForm.RoundedControl(PanelWarp_TboxArtist);
            MainForm.RoundedControl(PanelWarp_TboxComposers);
            MainForm.RoundedControl(PanelWarp_TboxGenres);
            MainForm.RoundedControl(PanelWarp_TboxSubTitle);
            MainForm.RoundedControl(PanelWarp_TboxTitle);
        }

        public void SetData(Song song)
        {
            Tag = song;
            Lb_Header.Text += " " + song.SongTitle;
            Tbox_Genre.Text = string.Join(", ", song.Genre.ToArray());
            Tbox_Composers.Text = string.Join(", ", song.Composers.ToArray());
            Tbox_Title.Text = song.SongTitle;
            Tbox_SubTitle.Text = song.SongSubTitle;
            Tbox_Artist.Text = song.SongArtist;
            Tbox_Album.Text = song.AlbumTitle;
            Num_Year.Value = song.Year;
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
            Song s = Tag as Song;
            List<string> g = new List<string>(Tbox_Genre.Text.Split(','));
            List<string> p = new List<string>(Tbox_Composers.Text.Split(','));
            g.Remove("");
            p.Remove("");
            s.SongTitle = Tbox_Title.Text.Trim();
            s.SongSubTitle = Tbox_SubTitle.Text.Trim();
            s.SongArtist = Tbox_Artist.Text.Trim();
            s.AlbumTitle = Tbox_Album.Text.Trim();
            s.Year = (uint) Num_Year.Value;
            s.Genre.Clear();
            s.Composers.Clear();
            foreach (string i in g)
                s.Genre.Add(i.Trim());
            foreach (string i in p)
                s.Composers.Add(i.Trim());
            if (!s.SaveInfo())
                MessageBox.Show("Error save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MyResources.Resources.MsgSongs.UpdateSong(s);
            MyResources.Main.SongExploreTab.LoadAllArtist();
            MyResources.Main.SongExploreTab.LoadAllGenre();
            Close();
        }
    }
}
