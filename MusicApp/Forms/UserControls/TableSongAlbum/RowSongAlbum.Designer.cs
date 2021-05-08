
namespace MusicApp.Forms.UserControls.TableSongAlbum
{
    partial class RowSongAlbum
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
            this.Lb_Artist = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.TablePanel_Row.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel_Row
            // 
            this.TablePanel_Row.ColumnCount = 3;
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanel_Row.Controls.Add(this.Lb_Artist, 0, 0);
            this.TablePanel_Row.Controls.Add(this.Lb_Name, 0, 0);
            this.TablePanel_Row.Controls.Add(this.Btn_Play, 2, 0);
            this.TablePanel_Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel_Row.Location = new System.Drawing.Point(0, 0);
            this.TablePanel_Row.Name = "TablePanel_Row";
            this.TablePanel_Row.RowCount = 1;
            this.TablePanel_Row.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_Row.Size = new System.Drawing.Size(414, 36);
            this.TablePanel_Row.TabIndex = 8;
            // 
            // Lb_Artist
            // 
            this.Lb_Artist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Artist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Artist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Artist.ForeColor = System.Drawing.Color.White;
            this.Lb_Artist.Location = new System.Drawing.Point(230, 0);
            this.Lb_Artist.Name = "Lb_Artist";
            this.Lb_Artist.Size = new System.Drawing.Size(143, 36);
            this.Lb_Artist.TabIndex = 9;
            this.Lb_Artist.Text = "Artist";
            this.Lb_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Artist.Click += new System.EventHandler(this.Lb_Name_Click);
            // 
            // Lb_Name
            // 
            this.Lb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ForeColor = System.Drawing.Color.White;
            this.Lb_Name.Location = new System.Drawing.Point(3, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(221, 36);
            this.Lb_Name.TabIndex = 5;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Name.Click += new System.EventHandler(this.Lb_Name_Click);
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Play.BackgroundImage = global::MusicApp.Properties.Resources.play_button;
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Play.FlatAppearance.BorderSize = 0;
            this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Play.ForeColor = System.Drawing.Color.White;
            this.Btn_Play.Location = new System.Drawing.Point(379, 3);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(30, 30);
            this.Btn_Play.TabIndex = 8;
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // RowSongAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel_Row);
            this.Name = "RowSongAlbum";
            this.Size = new System.Drawing.Size(414, 36);
            this.TablePanel_Row.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanel_Row;
        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label Lb_Artist;
    }
}
