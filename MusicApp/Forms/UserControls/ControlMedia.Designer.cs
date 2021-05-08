
namespace MusicApp.Forms.UserControls
{
    partial class ControlMedia
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMedia));
            this.ProgressBar_Duration = new MaterialSkin.Controls.MaterialProgressBar();
            this.ProgressBar_Volume = new MaterialSkin.Controls.MaterialProgressBar();
            this.Lb_Start = new System.Windows.Forms.Label();
            this.Lb_End = new System.Windows.Forms.Label();
            this.Timer_RaseTime = new System.Windows.Forms.Timer(this.components);
            this.Timer_CheckFullScreen = new System.Windows.Forms.Timer(this.components);
            this.Timer_CheckPlaying = new System.Windows.Forms.Timer(this.components);
            this.Btn_Loop = new System.Windows.Forms.Button();
            this.Btn_Shuffle = new System.Windows.Forms.Button();
            this.Btn_FullScreen = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.Btn_Volume = new System.Windows.Forms.Button();
            this.Btn_Playlist = new System.Windows.Forms.Button();
            this.Btn_PlayPause = new System.Windows.Forms.Button();
            this.Timer_Loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgressBar_Duration
            // 
            this.ProgressBar_Duration.BackColor = System.Drawing.Color.White;
            this.ProgressBar_Duration.Depth = 0;
            this.ProgressBar_Duration.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBar_Duration.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProgressBar_Duration.Location = new System.Drawing.Point(0, 0);
            this.ProgressBar_Duration.Maximum = 0;
            this.ProgressBar_Duration.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBar_Duration.Name = "ProgressBar_Duration";
            this.ProgressBar_Duration.Size = new System.Drawing.Size(836, 5);
            this.ProgressBar_Duration.TabIndex = 5;
            this.ProgressBar_Duration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RewindProgressBar_MouseDown);
            this.ProgressBar_Duration.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RewindProgressBar_MouseMove);
            this.ProgressBar_Duration.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RewindProgressBar_MouseUp);
            // 
            // ProgressBar_Volume
            // 
            this.ProgressBar_Volume.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressBar_Volume.Depth = 0;
            this.ProgressBar_Volume.Location = new System.Drawing.Point(653, 40);
            this.ProgressBar_Volume.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBar_Volume.Name = "ProgressBar_Volume";
            this.ProgressBar_Volume.Size = new System.Drawing.Size(171, 5);
            this.ProgressBar_Volume.TabIndex = 6;
            this.ProgressBar_Volume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeVolumeProgressBar_MouseDown);
            this.ProgressBar_Volume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeVolumeProgressBar_MouseMove);
            this.ProgressBar_Volume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeVolumeProgressBar_MouseUp);
            // 
            // Lb_Start
            // 
            this.Lb_Start.AutoSize = true;
            this.Lb_Start.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Start.ForeColor = System.Drawing.Color.White;
            this.Lb_Start.Location = new System.Drawing.Point(3, 8);
            this.Lb_Start.Name = "Lb_Start";
            this.Lb_Start.Size = new System.Drawing.Size(38, 15);
            this.Lb_Start.TabIndex = 9;
            this.Lb_Start.Text = "00:00";
            // 
            // Lb_End
            // 
            this.Lb_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_End.AutoSize = true;
            this.Lb_End.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_End.ForeColor = System.Drawing.Color.White;
            this.Lb_End.Location = new System.Drawing.Point(795, 8);
            this.Lb_End.Name = "Lb_End";
            this.Lb_End.Size = new System.Drawing.Size(38, 15);
            this.Lb_End.TabIndex = 10;
            this.Lb_End.Text = "00:00";
            // 
            // Timer_RaseTime
            // 
            this.Timer_RaseTime.Interval = 250;
            this.Timer_RaseTime.Tick += new System.EventHandler(this.Timer_RaseTime_Tick);
            // 
            // Timer_CheckFullScreen
            // 
            this.Timer_CheckFullScreen.Enabled = true;
            this.Timer_CheckFullScreen.Tick += new System.EventHandler(this.Timer_CheckFullScreen_Tick);
            // 
            // Timer_CheckPlaying
            // 
            this.Timer_CheckPlaying.Enabled = true;
            this.Timer_CheckPlaying.Tick += new System.EventHandler(this.Timer_CheckPlaying_Tick);
            // 
            // Btn_Loop
            // 
            this.Btn_Loop.BackgroundImage = global::MusicApp.Properties.Resources.reload;
            this.Btn_Loop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Loop.FlatAppearance.BorderSize = 0;
            this.Btn_Loop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Loop.Location = new System.Drawing.Point(464, 26);
            this.Btn_Loop.Name = "Btn_Loop";
            this.Btn_Loop.Size = new System.Drawing.Size(32, 32);
            this.Btn_Loop.TabIndex = 18;
            this.Btn_Loop.UseVisualStyleBackColor = true;
            this.Btn_Loop.Click += new System.EventHandler(this.Btn_Loop_Click);
            // 
            // Btn_Shuffle
            // 
            this.Btn_Shuffle.BackgroundImage = global::MusicApp.Properties.Resources.shuffle;
            this.Btn_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Shuffle.FlatAppearance.BorderSize = 0;
            this.Btn_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Shuffle.Location = new System.Drawing.Point(272, 26);
            this.Btn_Shuffle.Name = "Btn_Shuffle";
            this.Btn_Shuffle.Size = new System.Drawing.Size(32, 32);
            this.Btn_Shuffle.TabIndex = 17;
            this.Btn_Shuffle.UseVisualStyleBackColor = true;
            this.Btn_Shuffle.Click += new System.EventHandler(this.Btn_Shuffle_Click);
            // 
            // Btn_FullScreen
            // 
            this.Btn_FullScreen.BackgroundImage = global::MusicApp.Properties.Resources.expad_arrows;
            this.Btn_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_FullScreen.FlatAppearance.BorderSize = 0;
            this.Btn_FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FullScreen.Location = new System.Drawing.Point(573, 26);
            this.Btn_FullScreen.Name = "Btn_FullScreen";
            this.Btn_FullScreen.Size = new System.Drawing.Size(34, 34);
            this.Btn_FullScreen.TabIndex = 16;
            this.Btn_FullScreen.UseVisualStyleBackColor = true;
            this.Btn_FullScreen.Click += new System.EventHandler(this.Btn_FullScreen_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.BackgroundImage = global::MusicApp.Properties.Resources.next;
            this.Btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Next.FlatAppearance.BorderSize = 0;
            this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Next.Location = new System.Drawing.Point(422, 24);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(36, 36);
            this.Btn_Next.TabIndex = 15;
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.BackgroundImage = global::MusicApp.Properties.Resources.previuos;
            this.Btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Previous.FlatAppearance.BorderSize = 0;
            this.Btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Previous.Location = new System.Drawing.Point(310, 24);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(36, 36);
            this.Btn_Previous.TabIndex = 13;
            this.Btn_Previous.UseVisualStyleBackColor = true;
            this.Btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // Btn_Volume
            // 
            this.Btn_Volume.BackgroundImage = global::MusicApp.Properties.Resources.volume;
            this.Btn_Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Volume.FlatAppearance.BorderSize = 0;
            this.Btn_Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volume.Location = new System.Drawing.Point(613, 25);
            this.Btn_Volume.Name = "Btn_Volume";
            this.Btn_Volume.Size = new System.Drawing.Size(34, 34);
            this.Btn_Volume.TabIndex = 11;
            this.Btn_Volume.UseVisualStyleBackColor = true;
            this.Btn_Volume.Click += new System.EventHandler(this.Btn_Volume_Click);
            // 
            // Btn_Playlist
            // 
            this.Btn_Playlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Playlist.BackgroundImage")));
            this.Btn_Playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Playlist.FlatAppearance.BorderSize = 0;
            this.Btn_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Playlist.Location = new System.Drawing.Point(22, 24);
            this.Btn_Playlist.Name = "Btn_Playlist";
            this.Btn_Playlist.Size = new System.Drawing.Size(34, 34);
            this.Btn_Playlist.TabIndex = 8;
            this.Btn_Playlist.UseVisualStyleBackColor = true;
            this.Btn_Playlist.Click += new System.EventHandler(this.Btn_Playlist_Click);
            // 
            // Btn_PlayPause
            // 
            this.Btn_PlayPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_PlayPause.BackgroundImage")));
            this.Btn_PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_PlayPause.FlatAppearance.BorderSize = 0;
            this.Btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PlayPause.Location = new System.Drawing.Point(352, 10);
            this.Btn_PlayPause.Name = "Btn_PlayPause";
            this.Btn_PlayPause.Size = new System.Drawing.Size(64, 64);
            this.Btn_PlayPause.TabIndex = 7;
            this.Btn_PlayPause.UseVisualStyleBackColor = true;
            this.Btn_PlayPause.Click += new System.EventHandler(this.Btn_PlayPause_Click);
            // 
            // Timer_Loop
            // 
            this.Timer_Loop.Interval = 500;
            this.Timer_Loop.Tick += new System.EventHandler(this.Timer_Loop_Tick);
            // 
            // ControlMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Controls.Add(this.Btn_Loop);
            this.Controls.Add(this.Btn_Shuffle);
            this.Controls.Add(this.Btn_FullScreen);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_Volume);
            this.Controls.Add(this.Lb_End);
            this.Controls.Add(this.Lb_Start);
            this.Controls.Add(this.Btn_Playlist);
            this.Controls.Add(this.Btn_PlayPause);
            this.Controls.Add(this.ProgressBar_Volume);
            this.Controls.Add(this.ProgressBar_Duration);
            this.Name = "ControlMedia";
            this.Size = new System.Drawing.Size(836, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar ProgressBar_Duration;
        private MaterialSkin.Controls.MaterialProgressBar ProgressBar_Volume;
        private System.Windows.Forms.Button Btn_PlayPause;
        private System.Windows.Forms.Button Btn_Playlist;
        private System.Windows.Forms.Label Lb_Start;
        private System.Windows.Forms.Label Lb_End;
        private System.Windows.Forms.Timer Timer_RaseTime;
        private System.Windows.Forms.Button Btn_Volume;
        private System.Windows.Forms.Button Btn_Previous;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_FullScreen;
        private System.Windows.Forms.Timer Timer_CheckFullScreen;
        private System.Windows.Forms.Timer Timer_CheckPlaying;
        private System.Windows.Forms.Button Btn_Shuffle;
        private System.Windows.Forms.Button Btn_Loop;
        private System.Windows.Forms.Timer Timer_Loop;
    }
}
