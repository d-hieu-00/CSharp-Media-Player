using System;
using System.Windows.Forms;
using MusicApp.Classes;
using MusicApp.Entitys;

namespace MusicApp.Forms.UserControls.TableSong
{
    public partial class RowTableSongs : UserControl
    {
        public RowTableSongs()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_AddPlaylist, 3);
            MainForm.RoundedControl(Btn_Edit, 3);
            MainForm.RoundedControl(Lb_Artist);
            MainForm.RoundedControl(Lb_Genre);
            MainForm.RoundedControl(Lb_Name);
            MainForm.RoundedControl(Lb_Time);
            MainForm.RoundedControl(Lb_Year);
        }

        public void SetData(Song item)
        {
            Tag = item;
            Lb_Name.Text = item.SongTitle;
            Lb_Artist.Text = item.SongArtist;
            Lb_Genre.Text = string.Join(", ", item.Genre.ToArray());
            Lb_Time.Text = item.Duration;
            Lb_Year.Text = item.Year.ToString();
        }

        private void Btn_AddPlaylist_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var add = new AddSongToPlaylist();
            add.SetData(Tag as Song);
            add.ShowDialog();
            Lb_Artist.Focus();
            MyResources.Main.SetCursorDefault();
        }


        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var ed = new EditSong();
            ed.SetData(Tag as Song);
            ed.ShowDialog();
            SetData(Tag as Song);
            Lb_Artist.Focus();
            MyResources.Main.SetCursorDefault();
        }
    }
}
