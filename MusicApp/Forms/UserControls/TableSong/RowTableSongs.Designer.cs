
namespace MusicApp.Forms.UserControls.TableSong
{
    partial class RowTableSongs
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
            this.TablePanel_Row = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_Genre = new System.Windows.Forms.Label();
            this.Lb_Artist = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Btn_AddPlaylist = new System.Windows.Forms.Button();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Lb_Year = new System.Windows.Forms.Label();
            this.TablePanel_Row.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel_Row
            // 
            this.TablePanel_Row.BackColor = System.Drawing.Color.White;
            this.TablePanel_Row.ColumnCount = 7;
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.TablePanel_Row.Controls.Add(this.Lb_Genre, 0, 0);
            this.TablePanel_Row.Controls.Add(this.Lb_Artist, 1, 0);
            this.TablePanel_Row.Controls.Add(this.Lb_Name, 0, 0);
            this.TablePanel_Row.Controls.Add(this.Btn_AddPlaylist, 5, 0);
            this.TablePanel_Row.Controls.Add(this.Lb_Time, 3, 0);
            this.TablePanel_Row.Controls.Add(this.Btn_Edit, 6, 0);
            this.TablePanel_Row.Controls.Add(this.Lb_Year, 4, 0);
            this.TablePanel_Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel_Row.Location = new System.Drawing.Point(0, 0);
            this.TablePanel_Row.Name = "TablePanel_Row";
            this.TablePanel_Row.RowCount = 1;
            this.TablePanel_Row.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_Row.Size = new System.Drawing.Size(806, 36);
            this.TablePanel_Row.TabIndex = 1;
            // 
            // Lb_Genre
            // 
            this.Lb_Genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Genre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Genre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Genre.ForeColor = System.Drawing.Color.White;
            this.Lb_Genre.Location = new System.Drawing.Point(252, 0);
            this.Lb_Genre.Name = "Lb_Genre";
            this.Lb_Genre.Size = new System.Drawing.Size(114, 36);
            this.Lb_Genre.TabIndex = 5;
            this.Lb_Genre.Text = "Genre";
            this.Lb_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Artist
            // 
            this.Lb_Artist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Artist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Artist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Artist.ForeColor = System.Drawing.Color.White;
            this.Lb_Artist.Location = new System.Drawing.Point(372, 0);
            this.Lb_Artist.Name = "Lb_Artist";
            this.Lb_Artist.Size = new System.Drawing.Size(187, 36);
            this.Lb_Artist.TabIndex = 1;
            this.Lb_Artist.Text = "Artis";
            this.Lb_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Name
            // 
            this.Lb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ForeColor = System.Drawing.Color.White;
            this.Lb_Name.Location = new System.Drawing.Point(3, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(243, 36);
            this.Lb_Name.TabIndex = 0;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_AddPlaylist
            // 
            this.Btn_AddPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_AddPlaylist.BackgroundImage = global::MusicApp.Properties.Resources.plus;
            this.Btn_AddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_AddPlaylist.FlatAppearance.BorderSize = 0;
            this.Btn_AddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddPlaylist.Location = new System.Drawing.Point(733, 3);
            this.Btn_AddPlaylist.Name = "Btn_AddPlaylist";
            this.Btn_AddPlaylist.Size = new System.Drawing.Size(30, 30);
            this.Btn_AddPlaylist.TabIndex = 6;
            this.Btn_AddPlaylist.UseVisualStyleBackColor = false;
            this.Btn_AddPlaylist.Click += new System.EventHandler(this.Btn_AddPlaylist_Click);
            // 
            // Lb_Time
            // 
            this.Lb_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Time.ForeColor = System.Drawing.Color.White;
            this.Lb_Time.Location = new System.Drawing.Point(565, 0);
            this.Lb_Time.Name = "Lb_Time";
            this.Lb_Time.Size = new System.Drawing.Size(90, 36);
            this.Lb_Time.TabIndex = 4;
            this.Lb_Time.Text = "Time";
            this.Lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Edit.BackgroundImage = global::MusicApp.Properties.Resources.pencil;
            this.Btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Edit.FlatAppearance.BorderSize = 0;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Location = new System.Drawing.Point(773, 3);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(30, 30);
            this.Btn_Edit.TabIndex = 7;
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Lb_Year
            // 
            this.Lb_Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Year.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Year.ForeColor = System.Drawing.Color.White;
            this.Lb_Year.Location = new System.Drawing.Point(661, 0);
            this.Lb_Year.Name = "Lb_Year";
            this.Lb_Year.Size = new System.Drawing.Size(66, 36);
            this.Lb_Year.TabIndex = 8;
            this.Lb_Year.Text = "Year";
            this.Lb_Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RowTableSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel_Row);
            this.Name = "RowTableSongs";
            this.Size = new System.Drawing.Size(806, 36);
            this.TablePanel_Row.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanel_Row;
        private System.Windows.Forms.Label Lb_Genre;
        private System.Windows.Forms.Label Lb_Artist;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Button Btn_AddPlaylist;
        private System.Windows.Forms.Label Lb_Time;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Label Lb_Year;
    }
}
