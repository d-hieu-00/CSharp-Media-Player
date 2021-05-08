using AxWMPLib;
using MusicApp.Classes;
using MusicApp.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicApp.Forms.UserControls
{
    public partial class ControlMedia : UserControl
    {
        private bool rewinding = false;
        private bool changingVolume = false;
        private bool isPLaying = false;
        private int loopMode = 1; //1: Loop playlist, 2: loop one
        private AxWindowsMediaPlayer media = null;

        public ControlMedia()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_PlayPause, 10);
            MainForm.RoundedControl(Btn_Playlist, 5);
            MainForm.RoundedControl(Btn_FullScreen, 5);
            MainForm.RoundedControl(Btn_Volume, 5);
            MainForm.RoundedControl(Btn_Next, 10);
            MainForm.RoundedControl(Btn_Previous, 10);
            MainForm.RoundedControl(Btn_Shuffle, 3);
            MainForm.RoundedControl(Btn_Loop, 3);
            MainForm.RoundedControl(ProgressBar_Volume);
            MainForm.RoundedControl(ProgressBar_Duration);
        }

        #region progress bar
        private void RewindProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            rewinding = true;
            var c = sender as ProgressBar;
            var len = c.Width;
            var x = e.Location.X;
            /*c.Maximum = (int)media.Ctlcontrols.currentItem.duration;
            var val = Convert.ToInt32((x * 1.0 / len) * c.Maximum);
            c.Value = (val > c.Maximum) ? c.Maximum : (val < 0) ? 0 : val;
            media.Ctlcontrols.currentPosition = (x * 1.0 / len) * media.Ctlcontrols.currentItem.duration;*/
            var val = Convert.ToInt32((x * 1.0 / len) * c.Maximum);
            c.Value = (val > c.Maximum) ? c.Maximum : (val < 0) ? 0 : val;
            Timer_RaseTime.Stop();
        }

        private void RewindProgressBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (rewinding)
            {
                var c = sender as ProgressBar;
                var len = c.Width;
                var x = e.Location.X;
                var val = Convert.ToInt32((x * 1.0 / len) * c.Maximum);
                c.Value = (val > c.Maximum) ? c.Maximum : (val < 0) ? 0 : val;
                /*c.Maximum = (int)media.Ctlcontrols.currentItem.duration;
                var val = Convert.ToInt32((x * 1.0 / len) * c.Maximum);
                c.Value = (val > c.Maximum) ? c.Maximum : (val < 0) ? 0 : val;
                media.Ctlcontrols.currentPosition = (x * 1.0 / len) * media.Ctlcontrols.currentItem.duration;*/
            }
        }

        private void RewindProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            rewinding = false;
            var c = sender as ProgressBar;
            var len = c.Width;
            var x = e.Location.X;
            c.Maximum = (int)media.Ctlcontrols.currentItem.duration;
            var val = Convert.ToInt32((x * 1.0 / len) * c.Maximum);
            c.Value = (val > c.Maximum) ? c.Maximum : (val < 0) ? 0 : val;
            media.Ctlcontrols.currentPosition = (x * 1.0 / len) * media.Ctlcontrols.currentItem.duration;
            Timer_RaseTime.Start();
        }
        // volume
        private void ChangeVolumeProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            changingVolume = true;
            var c = sender as ProgressBar;
            var len = c.Width;
            var x = e.Location.X;
            var val = Convert.ToInt32((x * 1.0 / len) * c.Maximum);
            c.Value = (val > 100) ? 100 : (val < 0) ? 0 : val;
            media.settings.volume = c.Value;
            if (c.Value == 0)
            {
                Btn_Volume.BackgroundImage = Properties.Resources.mute;
            }
            else
            {
                Btn_Volume.BackgroundImage = Properties.Resources.volume;
            }
        }

        private void ChangeVolumeProgressBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (changingVolume)
            {
                var c = sender as ProgressBar;
                var len = c.Width;
                var x = e.Location.X;
                var val = Convert.ToInt32((x * 1.0 / len) * c.Maximum);
                c.Value = (val > 100) ? 100 : (val < 0) ? 0 : val;
                media.settings.volume = c.Value;
                if (c.Value == 0)
                {
                    Btn_Volume.BackgroundImage = Properties.Resources.mute;
                }
                else
                {
                    Btn_Volume.BackgroundImage = Properties.Resources.volume;
                }
            }
        }

        private void ChangeVolumeProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            changingVolume = false;
        }
        #endregion

        #region media
        public void SetMedia()
        {
            media = MyResources.Main.PlayingTab.GetMediaPlayer();
            Timer_RaseTime.Start();
            ProgressBar_Volume.Value = media.settings.volume;
            Timer_Loop.Enabled = true;
        }
        private void Btn_PlayPause_Click(object sender, EventArgs e)
        {
            if (isPLaying)
            {
                media.Ctlcontrols.pause();
                isPLaying = false;
                Btn_PlayPause.BackgroundImage = Properties.Resources.play_button;
            }
            else
            {
                media.Ctlcontrols.play();
                isPLaying = true;
                Btn_PlayPause.BackgroundImage = Properties.Resources.pause;
            }
            ProgressBar_Duration.Focus();
        }
        private void Btn_Playlist_Click(object sender, EventArgs e)
        {
            MyResources.Main.PlayingTab.TogglePlaylistPanel();
            ProgressBar_Duration.Focus();
        }
        private void Btn_Volume_Click(object sender, EventArgs e)
        {
            var val = ProgressBar_Volume.Value;
            if (val == 0)
            {
                Btn_Volume.BackgroundImage = Properties.Resources.volume;
                ProgressBar_Volume.Value = 25;
                media.settings.volume = 25;
            }
            else
            {
                Btn_Volume.BackgroundImage = Properties.Resources.mute;
                ProgressBar_Volume.Value = 0;
                media.settings.volume = 0;
            }
            ProgressBar_Duration.Focus();
        }
        private void Btn_FullScreen_Click(object sender, EventArgs e)
        {
            if (media == null)
                return;
            media.uiMode = "mini";
            media.fullScreen = true;
        }
        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (media == null || MyResources.Main.PlayingTab.NowPlaylist == null)
                return;
            List<Dictionary<string, string>> playlist = MyResources.Main.PlayingTab.NowPlaylist;
            int indPLaying = MyResources.Main.PlayingTab.GetIndexMediaPLaying();
            MyResources.Main.PlayingTab.RemovePlaying();
            if (indPLaying == 0)
                MyResources.Main.PlayingTab.SetNewPlayingByIndex(playlist.Count - 1);
            else
                MyResources.Main.PlayingTab.SetNewPlayingByIndex(indPLaying - 1);
            ProgressBar_Duration.Focus();
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (media == null || MyResources.Main.PlayingTab.NowPlaylist == null)
                return;
            List<Dictionary<string, string>> playlist = MyResources.Main.PlayingTab.NowPlaylist;
            int indPLaying = MyResources.Main.PlayingTab.GetIndexMediaPLaying();
            MyResources.Main.PlayingTab.RemovePlaying();
            if (indPLaying == playlist.Count - 1)
                MyResources.Main.PlayingTab.SetNewPlayingByIndex(0);
            else
                MyResources.Main.PlayingTab.SetNewPlayingByIndex(indPLaying + 1);
            ProgressBar_Duration.Focus();
        }
        private void Btn_Loop_Click(object sender, EventArgs e)
        {
            if (loopMode == 1)
            {
                Btn_Loop.BackgroundImage = Properties.Resources.loop_one;
                loopMode = 2;
                //media.settings.setMode("loop", true);
                //Timer_Loop.Enabled = false;
            }
            else if (loopMode == 2)
            {
                Btn_Loop.BackgroundImage = Properties.Resources.reload;
                loopMode = 1;
                ///Timer_Loop.Enabled = true;
            }
            ProgressBar_Duration.Focus();
        }
        private void RandomPLaylist()
        {
            List<Dictionary<string, string>> playlist = MyResources.Main.PlayingTab.NowPlaylist;
            List<int> arrRand = new List<int>();
            for (int i = 0; i < playlist.Count; i++)
                arrRand.Add(i);
            
            for (int i = 0; i<arrRand.Count; i++)
            {
                int j = new Random().Next(0, arrRand.Count);
                if (i == j)
                    continue;
                var tmp = playlist[arrRand[i]];
                playlist[arrRand[i]] = playlist[arrRand[j]];
                playlist[arrRand[j]] = tmp;
                MyResources.Main.PlayingTab.SwapItemPlaylistControls(arrRand[i], arrRand[j]);
            }
        }
        private void Btn_Shuffle_Click(object sender, EventArgs e)
        {
            if (media == null || MyResources.Main.PlayingTab.NowPlaylist == null)
                return;
            MyResources.Main.SetCursorLoading();
            RandomPLaylist();
            Lb_End.Focus();
            MyResources.Main.SetCursorDefault();
        }
        #endregion


        #region timer
        private void Timer_RaseTime_Tick(object sender, EventArgs e)
        {
            if (media != null && media.playState != WMPPlayState.wmppsUndefined)
            {
                int _max, _curr;
                _max = (int)media.Ctlcontrols.currentItem.duration;
                _curr = (int)media.Ctlcontrols.currentPosition;
                if (_curr > _max)
                    _curr = _max;
                else if (_curr < 0)
                    _curr = 0;
                ProgressBar_Duration.Maximum = _max;
                ProgressBar_Duration.Value = _curr;
                Lb_Start.Text = media.Ctlcontrols.currentPositionString;
                Lb_End.Text = media.Ctlcontrols.currentItem.durationString;
            }
        }
        private void Timer_CheckFullScreen_Tick(object sender, EventArgs e)
        {
            if (media != null && !media.fullScreen)
                media.uiMode = "none";
        }
        private void Timer_CheckPlaying_Tick(object sender, EventArgs e)
        {
            if (media != null)
            {
                if (isPLaying != true && media.playState == WMPPlayState.wmppsPlaying)
                {
                    Btn_PlayPause.BackgroundImage = Properties.Resources.pause;
                    isPLaying = true;
                }
                if (isPLaying != false && media.playState == WMPPlayState.wmppsPaused)
                {
                    Btn_PlayPause.BackgroundImage = Properties.Resources.play_button;
                    isPLaying = false;
                }
            }
        }
        private void Timer_Loop_Tick(object sender, EventArgs e)
        {
            if (media.playState == WMPPlayState.wmppsStopped)
            {
                if (loopMode == 1)
                {
                    Btn_Next.PerformClick();
                    media.Ctlcontrols.play();
                }
                else
                {
                    string URL = media.URL;
                    media.URL = null;
                    media.URL = URL;
                }
            }
        }
        #endregion


    }
}
