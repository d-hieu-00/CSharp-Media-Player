using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.Classes;

namespace MusicApp.Forms.UserControls.TableNowPLaylist
{
    public partial class RowTableNowPLaylist : UserControl
    {
        public RowTableNowPLaylist()
        {
            InitializeComponent();
            MainForm.RoundedControl(Lb_Name, 3);
            MainForm.RoundedControl(Lb_Duration, 3);
            MainForm.RoundedControl(Btn_Status, 3);
            MainForm.RoundedControl(Btn_Del, 3);
        }
        #region get value
        public Dictionary<string, string> GetTag()
        {
            return Btn_Status.Tag as Dictionary<string, string>;
        }
        #endregion
        public void SetData(Dictionary<string, string> item)
        {
            Lb_Name.Text = item["name"];
            Lb_Duration.Text = item["duration"];
            Btn_Status.Tag = item;
            Tag = item;
        }

        public void SetPLaying()
        {
            var media = MyResources.Main.PlayingTab.GetMediaPlayer();
            Btn_Status.BackgroundImage = Properties.Resources.music_track;
            media.URL = (Btn_Status.Tag as Dictionary<string, string>)["dir"];
            Name = "Playing";
            Btn_Status.Enabled = false;
        }
        public void SetNotPlaying()
        {
            Btn_Status.BackgroundImage = Properties.Resources.play_button;
            Name = "";
            Btn_Status.Enabled = true;
        }

        private void Btn_Status_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            MyResources.Main.PlayingTab.RemovePlaying();
            if (Name == "")
                SetPLaying();
            Lb_Name.Focus();
            MyResources.Main.SetCursorDefault();
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            Name = "Del";
            MyResources.Main.PlayingTab.DeleteItemInNowPlaylist();
            Lb_Name.Focus();
            MyResources.Main.SetCursorDefault();
        }
    }
}
