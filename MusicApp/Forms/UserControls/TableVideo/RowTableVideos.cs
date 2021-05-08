using System;
using System.Windows.Forms;
using MusicApp.Classes;
using MusicApp.Entitys;
using MusicApp.Entitys.Video;

namespace MusicApp.Forms.UserControls.TableVideo
{
    public partial class RowTableVideos : UserControl
    {
        public RowTableVideos()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_AddPlaylist, 3);
            MainForm.RoundedControl(Btn_Edit, 3);
            MainForm.RoundedControl(Lb_Director);
            MainForm.RoundedControl(Lb_Genre);
            MainForm.RoundedControl(Lb_Name);
            MainForm.RoundedControl(Lb_Time);
            MainForm.RoundedControl(Lb_Year);
        }
        public void SetData(Video item)
        {
            Tag = item;
            Lb_Name.Text = item.VideoTitle;
            Lb_Director.Text = string.Join(", ", item.Directors.ToArray());
            Lb_Genre.Text = string.Join(", ", item.Genre.ToArray());
            Lb_Time.Text = item.Duration;
            Lb_Year.Text = item.Year.ToString();
        }

        private void Btn_AddPlaylist_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var add = new AddVideoToPlaylist();
            add.SetData(Tag as Video);
            add.ShowDialog();
            Lb_Director.Focus();
            MyResources.Main.SetCursorDefault();
        }


        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var ed = new EditVideo();
            ed.SetData(Tag as Video);
            ed.ShowDialog();
            SetData(Tag as Video);
            Lb_Director.Focus();
            MyResources.Main.SetCursorDefault();
        }
    }
}
