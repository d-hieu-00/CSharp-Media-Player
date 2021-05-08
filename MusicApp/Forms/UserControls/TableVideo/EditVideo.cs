using MusicApp.Entitys;
using System;
using System.Drawing;
using System.Windows.Forms;
using MusicApp.Classes;
using MusicApp.Entitys.Video;
using System.Collections.Generic;

namespace MusicApp.Forms.UserControls.TableVideo
{
    public partial class EditVideo : Form
    {
        private bool dragging;
        private Point startPoint;
        public EditVideo()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_Close);
            MainForm.RoundedControl(Btn_OK);
            MainForm.RoundedControl(this);
            MainForm.RoundedControl(PanelWarp_NumYear);
            MainForm.RoundedControl(PanelWarp_TboxProducers);
            MainForm.RoundedControl(PanelWarp_TboxDirectors);
            MainForm.RoundedControl(PanelWarp_TboxPublisher);
            MainForm.RoundedControl(PanelWarp_TboxGenres);
            MainForm.RoundedControl(PanelWarp_TboxSubTitle);
            MainForm.RoundedControl(PanelWarp_TboxTitle);
        }

        public void SetData(Video video)
        {
            Tag = video;
            Lb_Header.Text += " " + video.VideoTitle;
            Tbox_Genre.Text = string.Join(", ", video.Genre.ToArray());
            Tbox_Publisher.Text = video.Publisher;
            Tbox_Title.Text = video.VideoTitle;
            Tbox_SubTitle.Text = video.VideoSubTitle;
            Tbox_Directors.Text = string.Join(", ", video.Directors.ToArray());
            Tbox_Producers.Text = string.Join(", ", video.Producers.ToArray());
            Num_Year.Value = video.Year;
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
            Cursor = Cursors.WaitCursor;
            Video s = Tag as Video;
            List<string> g = new List<string>(Tbox_Genre.Text.Split(','));
            List<string> d = new List<string>(Tbox_Directors.Text.Split(','));
            List<string> p = new List<string>(Tbox_Producers.Text.Split(','));
            g.Remove("");
            d.Remove("");
            p.Remove("");
            s.VideoTitle = Tbox_Title.Text.Trim();
            s.VideoSubTitle = Tbox_SubTitle.Text.Trim();
            s.Publisher = Tbox_Publisher.Text.Trim();
            s.Year = (uint)Num_Year.Value;
            s.Genre.Clear();
            s.Directors.Clear();
            s.Producers.Clear();
            foreach (string i in g)
                s.Genre.Add(i.Trim());
            foreach (string i in d)
                s.Directors.Add(i.Trim());
            foreach (string i in p)
                s.Producers.Add(i.Trim());
            if (!s.SaveInfo())
            {
                MessageBox.Show("Error save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
            }
            MyResources.Resources.MsgVideos.UpdateVideo(s);
            MyResources.Main.VidExploreTab.LoadAllDirectors();
            MyResources.Main.VidExploreTab.LoadAllGenre();
            Cursor = Cursors.Default;
            Close();
        }
    }
}
