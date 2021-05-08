
namespace MusicApp.Forms.UserControls.TableSong
{
    partial class AddSongToPlaylist
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSongToPlaylist));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lb_Header = new System.Windows.Forms.Label();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Cbox_Playlist = new System.Windows.Forms.ComboBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.Panel_Header.Controls.Add(this.Btn_Close);
            this.Panel_Header.Controls.Add(this.Lb_Header);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(312, 41);
            this.Panel_Header.TabIndex = 2;
            this.Panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Panel_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(269, 4);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 32);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Lb_Close_Click);
            this.Btn_Close.MouseEnter += new System.EventHandler(this.Lb_Close_MouseEnter);
            this.Btn_Close.MouseLeave += new System.EventHandler(this.Lb_Close_MouseLeave);
            // 
            // Lb_Header
            // 
            this.Lb_Header.AutoSize = true;
            this.Lb_Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Header.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lb_Header.Location = new System.Drawing.Point(12, 13);
            this.Lb_Header.Name = "Lb_Header";
            this.Lb_Header.Size = new System.Drawing.Size(134, 17);
            this.Lb_Header.TabIndex = 1;
            this.Lb_Header.Text = "Add song to playlist -";
            this.Lb_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Lb_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Lb_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackColor = System.Drawing.Color.White;
            this.Panel_Main.Controls.Add(this.Cbox_Playlist);
            this.Panel_Main.Controls.Add(this.Btn_OK);
            this.Panel_Main.Controls.Add(this.Lb_Name);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(312, 133);
            this.Panel_Main.TabIndex = 3;
            // 
            // Cbox_Playlist
            // 
            this.Cbox_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Cbox_Playlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbox_Playlist.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Playlist.ForeColor = System.Drawing.Color.White;
            this.Cbox_Playlist.FormattingEnabled = true;
            this.Cbox_Playlist.Location = new System.Drawing.Point(120, 56);
            this.Cbox_Playlist.Name = "Cbox_Playlist";
            this.Cbox_Playlist.Size = new System.Drawing.Size(180, 25);
            this.Cbox_Playlist.TabIndex = 2;
            this.Cbox_Playlist.DropDownClosed += new System.EventHandler(this.Cbox_DropDownClosed);
            // 
            // Btn_OK
            // 
            this.Btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_OK.FlatAppearance.BorderSize = 0;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.ForeColor = System.Drawing.Color.White;
            this.Btn_OK.Location = new System.Drawing.Point(199, 97);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(101, 29);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = false;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.Location = new System.Drawing.Point(12, 61);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(93, 15);
            this.Lb_Name.TabIndex = 1;
            this.Lb_Name.Text = "Name of playlist";
            // 
            // AddSongToPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 133);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSongToPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSongToPlaylist";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label Lb_Header;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.ComboBox Cbox_Playlist;
    }
}