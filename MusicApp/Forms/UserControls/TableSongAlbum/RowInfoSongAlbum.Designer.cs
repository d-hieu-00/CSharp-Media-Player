
namespace MusicApp.Forms.UserControls.TableSongAlbum
{
    partial class RowInfoSongAlbum
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
            this.TabelPanel_Row = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.Btn_AddPlaylist = new System.Windows.Forms.Button();
            this.TabelPanel_Row.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelPanel_Row
            // 
            this.TabelPanel_Row.ColumnCount = 3;
            this.TabelPanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TabelPanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TabelPanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelPanel_Row.Controls.Add(this.Btn_AddPlaylist, 2, 0);
            this.TabelPanel_Row.Controls.Add(this.Lb_Name, 0, 0);
            this.TabelPanel_Row.Controls.Add(this.Lb_Time, 1, 0);
            this.TabelPanel_Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelPanel_Row.Location = new System.Drawing.Point(0, 0);
            this.TabelPanel_Row.Name = "TabelPanel_Row";
            this.TabelPanel_Row.RowCount = 1;
            this.TabelPanel_Row.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabelPanel_Row.Size = new System.Drawing.Size(352, 36);
            this.TabelPanel_Row.TabIndex = 3;
            // 
            // Lb_Name
            // 
            this.Lb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ForeColor = System.Drawing.Color.White;
            this.Lb_Name.Location = new System.Drawing.Point(3, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(205, 36);
            this.Lb_Name.TabIndex = 1;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Time
            // 
            this.Lb_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Time.ForeColor = System.Drawing.Color.White;
            this.Lb_Time.Location = new System.Drawing.Point(214, 0);
            this.Lb_Time.Name = "Lb_Time";
            this.Lb_Time.Size = new System.Drawing.Size(99, 36);
            this.Lb_Time.TabIndex = 2;
            this.Lb_Time.Text = "Time";
            this.Lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_AddPlaylist
            // 
            this.Btn_AddPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_AddPlaylist.BackgroundImage = global::MusicApp.Properties.Resources.plus;
            this.Btn_AddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_AddPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AddPlaylist.FlatAppearance.BorderSize = 0;
            this.Btn_AddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddPlaylist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddPlaylist.ForeColor = System.Drawing.Color.White;
            this.Btn_AddPlaylist.Location = new System.Drawing.Point(319, 3);
            this.Btn_AddPlaylist.Name = "Btn_AddPlaylist";
            this.Btn_AddPlaylist.Size = new System.Drawing.Size(30, 30);
            this.Btn_AddPlaylist.TabIndex = 0;
            this.Btn_AddPlaylist.UseVisualStyleBackColor = false;
            this.Btn_AddPlaylist.Click += new System.EventHandler(this.Btn_AddPlaylist_Click);
            // 
            // RowInfoSongAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabelPanel_Row);
            this.Name = "RowInfoSongAlbum";
            this.Size = new System.Drawing.Size(352, 36);
            this.TabelPanel_Row.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabelPanel_Row;
        private System.Windows.Forms.Button Btn_AddPlaylist;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label Lb_Time;
    }
}
