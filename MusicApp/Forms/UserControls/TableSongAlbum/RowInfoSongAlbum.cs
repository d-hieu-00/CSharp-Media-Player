using MusicApp.Classes;
using MusicApp.Forms.UserControls.TableSong;
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
    public partial class RowInfoSongAlbum : UserControl
    {
        public RowInfoSongAlbum()
        {
            InitializeComponent();
            MainForm.RoundedControl(Lb_Name, 3);
            MainForm.RoundedControl(Lb_Time, 3);
            MainForm.RoundedControl(Btn_AddPlaylist);
        }

        public void SetData(Dictionary<string, string> item)
        {
            Lb_Name.Text = item["name"];
            Lb_Time.Text = item["duration"];
            Btn_AddPlaylist.Tag = item;
            Tag = item;
        }

        private void Btn_AddPlaylist_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var add = new AddSongToPlaylist();
            var s = MyResources.Resources.MsgSongs.FindSongByID(Convert.ToInt32((Tag as Dictionary<string, string>)["id"]));
            add.SetData(s);
            add.ShowDialog();
            Lb_Name.Focus();
            MyResources.Main.SetCursorDefault();
        }
    }
}
