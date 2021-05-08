
namespace MusicApp.Forms.UserControls.TableSong
{
    partial class EditSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSong));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lb_Header = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.PanelWarp_NumYear = new System.Windows.Forms.Panel();
            this.Num_Year = new System.Windows.Forms.NumericUpDown();
            this.Lb_Year = new System.Windows.Forms.Label();
            this.PanelWarp_TboxComposers = new System.Windows.Forms.Panel();
            this.Tbox_Composers = new System.Windows.Forms.TextBox();
            this.Lb_Composers = new System.Windows.Forms.Label();
            this.PanelWarp_TboxGenres = new System.Windows.Forms.Panel();
            this.Tbox_Genre = new System.Windows.Forms.TextBox();
            this.Lb_Genres = new System.Windows.Forms.Label();
            this.PanelWarp_TboxAlbum = new System.Windows.Forms.Panel();
            this.Tbox_Album = new System.Windows.Forms.TextBox();
            this.Lb_Album = new System.Windows.Forms.Label();
            this.PanelWarp_TboxArtist = new System.Windows.Forms.Panel();
            this.Tbox_Artist = new System.Windows.Forms.TextBox();
            this.Lb_Artist = new System.Windows.Forms.Label();
            this.PanelWarp_TboxSubTitle = new System.Windows.Forms.Panel();
            this.Tbox_SubTitle = new System.Windows.Forms.TextBox();
            this.Lb_SubTitle = new System.Windows.Forms.Label();
            this.PanelWarp_TboxTitle = new System.Windows.Forms.Panel();
            this.Tbox_Title = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.PanelWarp_NumYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Year)).BeginInit();
            this.PanelWarp_TboxComposers.SuspendLayout();
            this.PanelWarp_TboxGenres.SuspendLayout();
            this.PanelWarp_TboxAlbum.SuspendLayout();
            this.PanelWarp_TboxArtist.SuspendLayout();
            this.PanelWarp_TboxSubTitle.SuspendLayout();
            this.PanelWarp_TboxTitle.SuspendLayout();
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
            this.Panel_Header.Size = new System.Drawing.Size(545, 41);
            this.Panel_Header.TabIndex = 4;
            this.Panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Panel_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // Lb_Header
            // 
            this.Lb_Header.AutoSize = true;
            this.Lb_Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Header.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lb_Header.Location = new System.Drawing.Point(12, 13);
            this.Lb_Header.Name = "Lb_Header";
            this.Lb_Header.Size = new System.Drawing.Size(72, 17);
            this.Lb_Header.TabIndex = 1;
            this.Lb_Header.Text = "Edit song -";
            this.Lb_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Lb_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Lb_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(502, 4);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 32);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Lb_Close_Click);
            this.Btn_Close.MouseEnter += new System.EventHandler(this.Lb_Close_MouseEnter);
            this.Btn_Close.MouseLeave += new System.EventHandler(this.Lb_Close_MouseLeave);
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackColor = System.Drawing.Color.White;
            this.Panel_Main.Controls.Add(this.PanelWarp_NumYear);
            this.Panel_Main.Controls.Add(this.Lb_Year);
            this.Panel_Main.Controls.Add(this.PanelWarp_TboxComposers);
            this.Panel_Main.Controls.Add(this.Lb_Composers);
            this.Panel_Main.Controls.Add(this.PanelWarp_TboxGenres);
            this.Panel_Main.Controls.Add(this.Lb_Genres);
            this.Panel_Main.Controls.Add(this.PanelWarp_TboxAlbum);
            this.Panel_Main.Controls.Add(this.Lb_Album);
            this.Panel_Main.Controls.Add(this.PanelWarp_TboxArtist);
            this.Panel_Main.Controls.Add(this.Lb_Artist);
            this.Panel_Main.Controls.Add(this.PanelWarp_TboxSubTitle);
            this.Panel_Main.Controls.Add(this.Lb_SubTitle);
            this.Panel_Main.Controls.Add(this.PanelWarp_TboxTitle);
            this.Panel_Main.Controls.Add(this.Btn_OK);
            this.Panel_Main.Controls.Add(this.Lb_Title);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(545, 244);
            this.Panel_Main.TabIndex = 5;
            // 
            // PanelWarp_NumYear
            // 
            this.PanelWarp_NumYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_NumYear.Controls.Add(this.Num_Year);
            this.PanelWarp_NumYear.Location = new System.Drawing.Point(361, 159);
            this.PanelWarp_NumYear.Name = "PanelWarp_NumYear";
            this.PanelWarp_NumYear.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_NumYear.TabIndex = 14;
            // 
            // Num_Year
            // 
            this.Num_Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Num_Year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Num_Year.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Year.Location = new System.Drawing.Point(4, 1);
            this.Num_Year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Num_Year.Name = "Num_Year";
            this.Num_Year.Size = new System.Drawing.Size(162, 19);
            this.Num_Year.TabIndex = 15;
            this.Num_Year.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Lb_Year
            // 
            this.Lb_Year.AutoSize = true;
            this.Lb_Year.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Year.Location = new System.Drawing.Point(284, 159);
            this.Lb_Year.Name = "Lb_Year";
            this.Lb_Year.Size = new System.Drawing.Size(29, 15);
            this.Lb_Year.TabIndex = 13;
            this.Lb_Year.Text = "Year";
            // 
            // PanelWarp_TboxComposers
            // 
            this.PanelWarp_TboxComposers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxComposers.Controls.Add(this.Tbox_Composers);
            this.PanelWarp_TboxComposers.Location = new System.Drawing.Point(361, 111);
            this.PanelWarp_TboxComposers.Name = "PanelWarp_TboxComposers";
            this.PanelWarp_TboxComposers.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_TboxComposers.TabIndex = 12;
            // 
            // Tbox_Composers
            // 
            this.Tbox_Composers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_Composers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_Composers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_Composers.Location = new System.Drawing.Point(4, 2);
            this.Tbox_Composers.Name = "Tbox_Composers";
            this.Tbox_Composers.Size = new System.Drawing.Size(162, 16);
            this.Tbox_Composers.TabIndex = 0;
            // 
            // Lb_Composers
            // 
            this.Lb_Composers.AutoSize = true;
            this.Lb_Composers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Composers.Location = new System.Drawing.Point(284, 111);
            this.Lb_Composers.Name = "Lb_Composers";
            this.Lb_Composers.Size = new System.Drawing.Size(67, 15);
            this.Lb_Composers.TabIndex = 11;
            this.Lb_Composers.Text = "Composers";
            // 
            // PanelWarp_TboxGenres
            // 
            this.PanelWarp_TboxGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxGenres.Controls.Add(this.Tbox_Genre);
            this.PanelWarp_TboxGenres.Location = new System.Drawing.Point(361, 61);
            this.PanelWarp_TboxGenres.Name = "PanelWarp_TboxGenres";
            this.PanelWarp_TboxGenres.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_TboxGenres.TabIndex = 10;
            // 
            // Tbox_Genre
            // 
            this.Tbox_Genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_Genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_Genre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_Genre.Location = new System.Drawing.Point(4, 2);
            this.Tbox_Genre.Name = "Tbox_Genre";
            this.Tbox_Genre.Size = new System.Drawing.Size(162, 16);
            this.Tbox_Genre.TabIndex = 0;
            // 
            // Lb_Genres
            // 
            this.Lb_Genres.AutoSize = true;
            this.Lb_Genres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Genres.Location = new System.Drawing.Point(284, 61);
            this.Lb_Genres.Name = "Lb_Genres";
            this.Lb_Genres.Size = new System.Drawing.Size(43, 15);
            this.Lb_Genres.TabIndex = 9;
            this.Lb_Genres.Text = "Genres";
            // 
            // PanelWarp_TboxAlbum
            // 
            this.PanelWarp_TboxAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxAlbum.Controls.Add(this.Tbox_Album);
            this.PanelWarp_TboxAlbum.Location = new System.Drawing.Point(89, 204);
            this.PanelWarp_TboxAlbum.Name = "PanelWarp_TboxAlbum";
            this.PanelWarp_TboxAlbum.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_TboxAlbum.TabIndex = 8;
            // 
            // Tbox_Album
            // 
            this.Tbox_Album.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_Album.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_Album.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_Album.Location = new System.Drawing.Point(4, 2);
            this.Tbox_Album.Name = "Tbox_Album";
            this.Tbox_Album.Size = new System.Drawing.Size(162, 16);
            this.Tbox_Album.TabIndex = 0;
            // 
            // Lb_Album
            // 
            this.Lb_Album.AutoSize = true;
            this.Lb_Album.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Album.Location = new System.Drawing.Point(12, 204);
            this.Lb_Album.Name = "Lb_Album";
            this.Lb_Album.Size = new System.Drawing.Size(43, 15);
            this.Lb_Album.TabIndex = 7;
            this.Lb_Album.Text = "Album";
            // 
            // PanelWarp_TboxArtist
            // 
            this.PanelWarp_TboxArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxArtist.Controls.Add(this.Tbox_Artist);
            this.PanelWarp_TboxArtist.Location = new System.Drawing.Point(89, 159);
            this.PanelWarp_TboxArtist.Name = "PanelWarp_TboxArtist";
            this.PanelWarp_TboxArtist.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_TboxArtist.TabIndex = 6;
            // 
            // Tbox_Artist
            // 
            this.Tbox_Artist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_Artist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_Artist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_Artist.Location = new System.Drawing.Point(4, 2);
            this.Tbox_Artist.Name = "Tbox_Artist";
            this.Tbox_Artist.Size = new System.Drawing.Size(162, 16);
            this.Tbox_Artist.TabIndex = 0;
            // 
            // Lb_Artist
            // 
            this.Lb_Artist.AutoSize = true;
            this.Lb_Artist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Artist.Location = new System.Drawing.Point(12, 159);
            this.Lb_Artist.Name = "Lb_Artist";
            this.Lb_Artist.Size = new System.Drawing.Size(35, 15);
            this.Lb_Artist.TabIndex = 5;
            this.Lb_Artist.Text = "Artist";
            // 
            // PanelWarp_TboxSubTitle
            // 
            this.PanelWarp_TboxSubTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxSubTitle.Controls.Add(this.Tbox_SubTitle);
            this.PanelWarp_TboxSubTitle.Location = new System.Drawing.Point(89, 111);
            this.PanelWarp_TboxSubTitle.Name = "PanelWarp_TboxSubTitle";
            this.PanelWarp_TboxSubTitle.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_TboxSubTitle.TabIndex = 4;
            // 
            // Tbox_SubTitle
            // 
            this.Tbox_SubTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_SubTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_SubTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_SubTitle.Location = new System.Drawing.Point(4, 2);
            this.Tbox_SubTitle.Name = "Tbox_SubTitle";
            this.Tbox_SubTitle.Size = new System.Drawing.Size(162, 16);
            this.Tbox_SubTitle.TabIndex = 0;
            // 
            // Lb_SubTitle
            // 
            this.Lb_SubTitle.AutoSize = true;
            this.Lb_SubTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_SubTitle.Location = new System.Drawing.Point(12, 111);
            this.Lb_SubTitle.Name = "Lb_SubTitle";
            this.Lb_SubTitle.Size = new System.Drawing.Size(50, 15);
            this.Lb_SubTitle.TabIndex = 3;
            this.Lb_SubTitle.Text = "Sub title";
            // 
            // PanelWarp_TboxTitle
            // 
            this.PanelWarp_TboxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxTitle.Controls.Add(this.Tbox_Title);
            this.PanelWarp_TboxTitle.Location = new System.Drawing.Point(89, 61);
            this.PanelWarp_TboxTitle.Name = "PanelWarp_TboxTitle";
            this.PanelWarp_TboxTitle.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_TboxTitle.TabIndex = 2;
            // 
            // Tbox_Title
            // 
            this.Tbox_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_Title.Location = new System.Drawing.Point(4, 2);
            this.Tbox_Title.Name = "Tbox_Title";
            this.Tbox_Title.Size = new System.Drawing.Size(162, 16);
            this.Tbox_Title.TabIndex = 0;
            // 
            // Btn_OK
            // 
            this.Btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_OK.FlatAppearance.BorderSize = 0;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.ForeColor = System.Drawing.Color.White;
            this.Btn_OK.Location = new System.Drawing.Point(426, 196);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(101, 29);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = false;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(12, 61);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(57, 15);
            this.Lb_Title.TabIndex = 1;
            this.Lb_Title.Text = "Song title";
            // 
            // EditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 244);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSong";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            this.PanelWarp_NumYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Year)).EndInit();
            this.PanelWarp_TboxComposers.ResumeLayout(false);
            this.PanelWarp_TboxComposers.PerformLayout();
            this.PanelWarp_TboxGenres.ResumeLayout(false);
            this.PanelWarp_TboxGenres.PerformLayout();
            this.PanelWarp_TboxAlbum.ResumeLayout(false);
            this.PanelWarp_TboxAlbum.PerformLayout();
            this.PanelWarp_TboxArtist.ResumeLayout(false);
            this.PanelWarp_TboxArtist.PerformLayout();
            this.PanelWarp_TboxSubTitle.ResumeLayout(false);
            this.PanelWarp_TboxSubTitle.PerformLayout();
            this.PanelWarp_TboxTitle.ResumeLayout(false);
            this.PanelWarp_TboxTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label Lb_Header;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Panel PanelWarp_TboxArtist;
        private System.Windows.Forms.TextBox Tbox_Artist;
        private System.Windows.Forms.Label Lb_Artist;
        private System.Windows.Forms.Panel PanelWarp_TboxSubTitle;
        private System.Windows.Forms.TextBox Tbox_SubTitle;
        private System.Windows.Forms.Label Lb_SubTitle;
        private System.Windows.Forms.Panel PanelWarp_TboxTitle;
        private System.Windows.Forms.TextBox Tbox_Title;
        private System.Windows.Forms.Panel PanelWarp_TboxAlbum;
        private System.Windows.Forms.TextBox Tbox_Album;
        private System.Windows.Forms.Label Lb_Album;
        private System.Windows.Forms.Panel PanelWarp_TboxComposers;
        private System.Windows.Forms.TextBox Tbox_Composers;
        private System.Windows.Forms.Label Lb_Composers;
        private System.Windows.Forms.Panel PanelWarp_TboxGenres;
        private System.Windows.Forms.TextBox Tbox_Genre;
        private System.Windows.Forms.Label Lb_Genres;
        private System.Windows.Forms.Panel PanelWarp_NumYear;
        private System.Windows.Forms.Label Lb_Year;
        private System.Windows.Forms.NumericUpDown Num_Year;
    }
}