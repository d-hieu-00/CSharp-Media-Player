
namespace MusicApp.Forms.UserControls
{
    partial class Loading
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
            this.Picbox_LoadingGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_LoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // Picbox_LoadingGif
            // 
            this.Picbox_LoadingGif.BackColor = System.Drawing.Color.White;
            this.Picbox_LoadingGif.Image = global::MusicApp.Properties.Resources.Infinity_2_4s_200px;
            this.Picbox_LoadingGif.Location = new System.Drawing.Point(342, 211);
            this.Picbox_LoadingGif.Name = "Picbox_LoadingGif";
            this.Picbox_LoadingGif.Size = new System.Drawing.Size(150, 150);
            this.Picbox_LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_LoadingGif.TabIndex = 0;
            this.Picbox_LoadingGif.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Picbox_LoadingGif);
            this.Name = "Loading";
            this.Size = new System.Drawing.Size(836, 533);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_LoadingGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picbox_LoadingGif;
    }
}
