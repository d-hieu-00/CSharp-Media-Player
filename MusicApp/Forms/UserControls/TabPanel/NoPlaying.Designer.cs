
namespace MusicApp.Forms.UserControls.TabPanel
{
    partial class NoPlaying
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
            this.Lb_Content = new System.Windows.Forms.Label();
            this.Picbox_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Content
            // 
            this.Lb_Content.AutoSize = true;
            this.Lb_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Content.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Content.ForeColor = System.Drawing.Color.White;
            this.Lb_Content.Location = new System.Drawing.Point(273, 358);
            this.Lb_Content.Name = "Lb_Content";
            this.Lb_Content.Size = new System.Drawing.Size(290, 30);
            this.Lb_Content.TabIndex = 5;
            this.Lb_Content.Text = "Have no song in now-playlist";
            // 
            // Picbox_Img
            // 
            this.Picbox_Img.Image = global::MusicApp.Properties.Resources.no_music;
            this.Picbox_Img.Location = new System.Drawing.Point(290, 67);
            this.Picbox_Img.Name = "Picbox_Img";
            this.Picbox_Img.Size = new System.Drawing.Size(256, 256);
            this.Picbox_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picbox_Img.TabIndex = 4;
            this.Picbox_Img.TabStop = false;
            // 
            // NoPlaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lb_Content);
            this.Controls.Add(this.Picbox_Img);
            this.Name = "NoPlaying";
            this.Size = new System.Drawing.Size(836, 455);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Content;
        private System.Windows.Forms.PictureBox Picbox_Img;
    }
}
