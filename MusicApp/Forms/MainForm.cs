using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.Classes;
using MusicApp.Forms.UserControls;
using MusicApp.Forms.UserControls.TabPanel;

namespace MusicApp.Forms
{
    public partial class MainForm : Form
    {
        #region Properties
        private bool dragging = false;
        private Point startPoint;
        private int nowPlaying = 0; // 0: no playing, 1: playing
        private int indexTabs = 0;
        private readonly Timer timerLoadingStart = new Timer();
        private readonly Timer timerCheckPlaying = new Timer();
        public int NowPlaying { get => nowPlaying; set => nowPlaying = value; }

        //user control
        public readonly Loading LoadingPanel = new Loading();
        public readonly Welcome WelcomeTab = new Welcome();
        public readonly NoPlaying NoPlayingTab = new NoPlaying();
        public readonly Playing PlayingTab = new Playing();
        public readonly Playlists PlaylistTab = new Playlists();
        public readonly Settings SettingTab = new Settings();
        public readonly SongAlbum SongAblumTab = new SongAlbum();
        public readonly SongExplore SongExploreTab = new SongExplore();
        public readonly VidExplore VidExploreTab = new VidExplore();
        public readonly ControlMedia ControlMediaPanel = new ControlMedia();
        public readonly SideBar SideBarPanel = new SideBar();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion

        #region contructor, function loading and function roundControl
        public static void RoundedControl(Control control)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 4, 4));
        }
        public static void RoundedControl(Control control, int r)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, r, r));
        }
        public static void RoundedControl(Control control, int x, int y, int rw, int rh)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(x, y, control.Width, control.Height, rw, rh));
        }
        public MainForm()
        {
            timerLoadingStart.Enabled = true;
            timerLoadingStart.Interval = 750;
            timerLoadingStart.Enabled = true;
            timerLoadingStart.Tick += TimerLoadingStart_Tick;
            LoadingPanel.Location = new Point(170, 40);
            Controls.Add(LoadingPanel);
            timerLoadingStart.Start();

            timerCheckPlaying.Enabled = true;
            timerCheckPlaying.Interval = 550;
            timerCheckPlaying.Enabled = true;
            timerCheckPlaying.Tick += TimerCheckPlaying_Tick;
            timerCheckPlaying.Start();

            InitializeComponent();

            Panel_Control.Hide();
            RoundedControl(this, 7);
            RoundedControl(Lb_Close, 5);
            RoundedControl(Lb_Minimize, 5);
        }
        private void TimerCheckPlaying_Tick(object sender, EventArgs e)
        {
            if (PlayingTab.NowPlaylist != null)
            {
                timerCheckPlaying.Stop();
                nowPlaying = 1;
                if (indexTabs == 1)
                {
                    Panel_Main.Controls.Clear();
                    switch (nowPlaying)
                    {
                        case 1:
                            Panel_Main.Controls.Add(PlayingTab);
                            break;
                        default:
                            Panel_Main.Controls.Add(NoPlayingTab);
                            break;
                    }
                }
            }
        }
        private void TimerLoadingStart_Tick(object sender, EventArgs e)
        {
            if (MyResources.Resources == null)
                return;
            /*MyResources.Resources.AddFolderFromPath(@"D:\tmpp");
            MyResources.Main.SongExploreTab.LoadAll();*/
            timerLoadingStart.Stop();
            ControlMediaPanel.SetMedia();
            Panel_Control.Size = ControlMediaPanel.Size;
            Panel_Control.Controls.Add(ControlMediaPanel);
            Panel_SideBar.Controls.Add(SideBarPanel);
            Panel_Main.Controls.Add(WelcomeTab);
            SetCursorDefault();
            Controls.Remove(LoadingPanel);
        }
        // make form shadow
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }
        #endregion

        #region handle button close, minimize
        private void Lb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Lb_Close_MouseEnter(object sender, EventArgs e)
        {
            Lb_Close.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void Lb_Close_MouseLeave(object sender, EventArgs e)
        {
            Lb_Close.BackColor = Color.FromArgb(5, 144, 142);
            //Lb_Close.ForeColor = Color.DimGray;
        }

        private void Lb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Lb_Minimize_MouseEnter(object sender, EventArgs e)
        {
            Lb_Minimize.BackColor = Color.White;
            Lb_Minimize.ForeColor = Color.DarkGray;
        }

        private void Lb_Minimize_MouseLeave(object sender, EventArgs e)
        {
            Lb_Minimize.BackColor = Color.FromArgb(5, 144, 142);
            Lb_Minimize.ForeColor = Color.White;
        }
        #endregion

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

        #region handle silde bar button click to show PanelMain

        private void Panel_Main_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (indexTabs == 0)
            {
                WelcomeTab.SetLocationAfterSartView();
                Panel_Control.Show();
            }
        }
        
        public void Btn_Playing_Click()
        {
            if (indexTabs == 1)
                return;
            Panel_Main.Controls.Clear();
            indexTabs = 1;
            switch (nowPlaying)
            {
                case 1:
                    Panel_Main.Controls.Add(PlayingTab);
                    break;
                default:
                    Panel_Main.Controls.Add(NoPlayingTab);
                    break;
            }
        }

        public void Btn_Playlist_Click()
        {
            if (indexTabs == 2)
                return;
            Panel_Main.Controls.Clear();
            indexTabs = 2;
            //PlaylistTab.LoadAllPlaylist();
            Panel_Main.Controls.Add(PlaylistTab);
        }

        public void Btn_SongExplore_Click()
        {
            if (indexTabs == 3)
                return;
            Panel_Main.Controls.Clear();
            indexTabs = 3;
            Panel_Main.Controls.Add(SongExploreTab);
        }

        public void Btn_SongAlbum_Click()
        {
            if (indexTabs == 4)
                return;
            Panel_Main.Controls.Clear();
            indexTabs = 4;
            Panel_Main.Controls.Add(SongAblumTab);
        }

        public void Btn_VidExplore_Click()
        {
            if (indexTabs == 5)
                return;
            Panel_Main.Controls.Clear();
            indexTabs = 5;
            Panel_Main.Controls.Add(VidExploreTab);
        }

        public void Btn_Setting_Click()
        {
            if (indexTabs == 6)
                return;
            Panel_Main.Controls.Clear();
            indexTabs = 6;
            Panel_Main.Controls.Add(SettingTab);
        }

        public void Btn_About_Click()
        {
            if (indexTabs == 7)
                return;
            Panel_Main.Controls.Clear();
            indexTabs = 7;
            Panel_Main.Controls.Add(WelcomeTab);
        }
        #endregion

        public void SetStatus(string status)
        {
            Lb_Status.Text = status;
        }

        #region set cursor
        public void SetCursorDefault()
        {
            Cursor = Cursors.Default;
        }

        public void SetCursorLoading()
        {
            Cursor = Cursors.WaitCursor;
        }
        #endregion
    }
}
