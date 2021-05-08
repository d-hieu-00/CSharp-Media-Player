
namespace MusicApp.Forms.UserControls
{
    partial class SideBar
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
            this.Btn_Playing = new System.Windows.Forms.Button();
            this.Btn_Setting = new System.Windows.Forms.Button();
            this.Btn_About = new System.Windows.Forms.Button();
            this.Lb_MagVid = new System.Windows.Forms.Label();
            this.Btn_VidExplore = new System.Windows.Forms.Button();
            this.Lb_MagSong = new System.Windows.Forms.Label();
            this.Btn_SongExplore = new System.Windows.Forms.Button();
            this.Btn_SongAlbum = new System.Windows.Forms.Button();
            this.PicboxLogo = new System.Windows.Forms.PictureBox();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Btn_Playlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxLogo)).BeginInit();
            this.Panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Playing
            // 
            this.Btn_Playing.FlatAppearance.BorderSize = 0;
            this.Btn_Playing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Playing.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Playing.ForeColor = System.Drawing.Color.White;
            this.Btn_Playing.Location = new System.Drawing.Point(17, 181);
            this.Btn_Playing.Name = "Btn_Playing";
            this.Btn_Playing.Size = new System.Drawing.Size(140, 30);
            this.Btn_Playing.TabIndex = 26;
            this.Btn_Playing.Text = "Now playing";
            this.Btn_Playing.UseVisualStyleBackColor = true;
            this.Btn_Playing.Click += new System.EventHandler(this.Btn_Playing_Click);
            // 
            // Btn_Setting
            // 
            this.Btn_Setting.FlatAppearance.BorderSize = 0;
            this.Btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Setting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Setting.ForeColor = System.Drawing.Color.White;
            this.Btn_Setting.Location = new System.Drawing.Point(36, 6);
            this.Btn_Setting.Name = "Btn_Setting";
            this.Btn_Setting.Size = new System.Drawing.Size(101, 30);
            this.Btn_Setting.TabIndex = 24;
            this.Btn_Setting.Text = "Settings";
            this.Btn_Setting.UseVisualStyleBackColor = true;
            this.Btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
            // 
            // Btn_About
            // 
            this.Btn_About.FlatAppearance.BorderSize = 0;
            this.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_About.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_About.ForeColor = System.Drawing.Color.White;
            this.Btn_About.Location = new System.Drawing.Point(36, 42);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(101, 30);
            this.Btn_About.TabIndex = 23;
            this.Btn_About.Text = "About";
            this.Btn_About.UseVisualStyleBackColor = true;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // Lb_MagVid
            // 
            this.Lb_MagVid.AutoSize = true;
            this.Lb_MagVid.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_MagVid.ForeColor = System.Drawing.Color.White;
            this.Lb_MagVid.Location = new System.Drawing.Point(33, 339);
            this.Lb_MagVid.Name = "Lb_MagVid";
            this.Lb_MagVid.Size = new System.Drawing.Size(101, 17);
            this.Lb_MagVid.TabIndex = 20;
            this.Lb_MagVid.Text = "Manage videos";
            // 
            // Btn_VidExplore
            // 
            this.Btn_VidExplore.FlatAppearance.BorderSize = 0;
            this.Btn_VidExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VidExplore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VidExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.Btn_VidExplore.Location = new System.Drawing.Point(36, 359);
            this.Btn_VidExplore.Name = "Btn_VidExplore";
            this.Btn_VidExplore.Size = new System.Drawing.Size(101, 30);
            this.Btn_VidExplore.TabIndex = 22;
            this.Btn_VidExplore.Text = "Explore";
            this.Btn_VidExplore.UseVisualStyleBackColor = true;
            this.Btn_VidExplore.Click += new System.EventHandler(this.Btn_VidExplore_Click);
            // 
            // Lb_MagSong
            // 
            this.Lb_MagSong.AutoSize = true;
            this.Lb_MagSong.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_MagSong.ForeColor = System.Drawing.Color.White;
            this.Lb_MagSong.Location = new System.Drawing.Point(33, 250);
            this.Lb_MagSong.Name = "Lb_MagSong";
            this.Lb_MagSong.Size = new System.Drawing.Size(97, 17);
            this.Lb_MagSong.TabIndex = 16;
            this.Lb_MagSong.Text = "Manage songs";
            // 
            // Btn_SongExplore
            // 
            this.Btn_SongExplore.FlatAppearance.BorderSize = 0;
            this.Btn_SongExplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SongExplore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SongExplore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.Btn_SongExplore.Location = new System.Drawing.Point(36, 270);
            this.Btn_SongExplore.Name = "Btn_SongExplore";
            this.Btn_SongExplore.Size = new System.Drawing.Size(101, 30);
            this.Btn_SongExplore.TabIndex = 19;
            this.Btn_SongExplore.Text = "Explore";
            this.Btn_SongExplore.UseVisualStyleBackColor = true;
            this.Btn_SongExplore.Click += new System.EventHandler(this.Btn_SongExplore_Click);
            // 
            // Btn_SongAlbum
            // 
            this.Btn_SongAlbum.FlatAppearance.BorderSize = 0;
            this.Btn_SongAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SongAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SongAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.Btn_SongAlbum.Location = new System.Drawing.Point(36, 306);
            this.Btn_SongAlbum.Name = "Btn_SongAlbum";
            this.Btn_SongAlbum.Size = new System.Drawing.Size(101, 30);
            this.Btn_SongAlbum.TabIndex = 18;
            this.Btn_SongAlbum.Text = "Album";
            this.Btn_SongAlbum.UseVisualStyleBackColor = true;
            this.Btn_SongAlbum.Click += new System.EventHandler(this.Btn_SongAlbum_Click);
            // 
            // PicboxLogo
            // 
            this.PicboxLogo.Cursor = System.Windows.Forms.Cursors.Help;
            this.PicboxLogo.Image = global::MusicApp.Properties.Resources.logo_transparent;
            this.PicboxLogo.Location = new System.Drawing.Point(0, 0);
            this.PicboxLogo.Name = "PicboxLogo";
            this.PicboxLogo.Size = new System.Drawing.Size(170, 170);
            this.PicboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicboxLogo.TabIndex = 27;
            this.PicboxLogo.TabStop = false;
            this.PicboxLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicboxLogo_MouseClick);
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.Panel_Bottom.Controls.Add(this.Btn_Setting);
            this.Panel_Bottom.Controls.Add(this.Btn_About);
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 495);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(170, 78);
            this.Panel_Bottom.TabIndex = 28;
            // 
            // Btn_Playlist
            // 
            this.Btn_Playlist.FlatAppearance.BorderSize = 0;
            this.Btn_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Playlist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Playlist.ForeColor = System.Drawing.Color.White;
            this.Btn_Playlist.Location = new System.Drawing.Point(17, 217);
            this.Btn_Playlist.Name = "Btn_Playlist";
            this.Btn_Playlist.Size = new System.Drawing.Size(140, 30);
            this.Btn_Playlist.TabIndex = 29;
            this.Btn_Playlist.Text = "PLaylist";
            this.Btn_Playlist.UseVisualStyleBackColor = true;
            this.Btn_Playlist.Click += new System.EventHandler(this.Btn_Playlist_Click);
            // 
            // SideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.Btn_Playlist);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.PicboxLogo);
            this.Controls.Add(this.Btn_Playing);
            this.Controls.Add(this.Lb_MagVid);
            this.Controls.Add(this.Btn_VidExplore);
            this.Controls.Add(this.Lb_MagSong);
            this.Controls.Add(this.Btn_SongExplore);
            this.Controls.Add(this.Btn_SongAlbum);
            this.Name = "SideBar";
            this.Size = new System.Drawing.Size(170, 573);
            ((System.ComponentModel.ISupportInitialize)(this.PicboxLogo)).EndInit();
            this.Panel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Playing;
        private System.Windows.Forms.Button Btn_Setting;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.Label Lb_MagVid;
        private System.Windows.Forms.Button Btn_VidExplore;
        private System.Windows.Forms.Label Lb_MagSong;
        private System.Windows.Forms.Button Btn_SongExplore;
        private System.Windows.Forms.Button Btn_SongAlbum;
        private System.Windows.Forms.PictureBox PicboxLogo;
        private System.Windows.Forms.Panel Panel_Bottom;
        private System.Windows.Forms.Button Btn_Playlist;
    }
}
