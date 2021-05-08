
namespace MusicApp.Forms.UserControls.TabPanel
{
    partial class Playing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playing));
            this.FlowPanel_Header = new System.Windows.Forms.FlowLayoutPanel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.FlowPanel_Col = new System.Windows.Forms.FlowLayoutPanel();
            this.TablePanel_Col = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Reload = new System.Windows.Forms.Button();
            this.Lb_Duration = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.FlowPanel_Playlist = new System.Windows.Forms.FlowLayoutPanel();
            this.WMP_Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.FlowPanel_Header.SuspendLayout();
            this.FlowPanel_Col.SuspendLayout();
            this.TablePanel_Col.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_Media)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPanel_Header
            // 
            this.FlowPanel_Header.AutoScroll = true;
            this.FlowPanel_Header.BackColor = System.Drawing.Color.White;
            this.FlowPanel_Header.Controls.Add(this.Lb_Title);
            this.FlowPanel_Header.Controls.Add(this.FlowPanel_Col);
            this.FlowPanel_Header.Controls.Add(this.FlowPanel_Playlist);
            this.FlowPanel_Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowPanel_Header.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel_Header.Name = "FlowPanel_Header";
            this.FlowPanel_Header.Size = new System.Drawing.Size(403, 455);
            this.FlowPanel_Header.TabIndex = 1;
            // 
            // Lb_Title
            // 
            this.Lb_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.White;
            this.Lb_Title.Location = new System.Drawing.Point(3, 0);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(397, 27);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "Now playing playlist";
            this.Lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPanel_Col
            // 
            this.FlowPanel_Col.Controls.Add(this.TablePanel_Col);
            this.FlowPanel_Col.Location = new System.Drawing.Point(3, 30);
            this.FlowPanel_Col.Name = "FlowPanel_Col";
            this.FlowPanel_Col.Size = new System.Drawing.Size(371, 42);
            this.FlowPanel_Col.TabIndex = 4;
            // 
            // TablePanel_Col
            // 
            this.TablePanel_Col.ColumnCount = 3;
            this.TablePanel_Col.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TablePanel_Col.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablePanel_Col.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablePanel_Col.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanel_Col.Controls.Add(this.Btn_Reload, 2, 0);
            this.TablePanel_Col.Controls.Add(this.Lb_Duration, 1, 0);
            this.TablePanel_Col.Controls.Add(this.Lb_Name, 0, 0);
            this.TablePanel_Col.Location = new System.Drawing.Point(3, 3);
            this.TablePanel_Col.Name = "TablePanel_Col";
            this.TablePanel_Col.RowCount = 1;
            this.TablePanel_Col.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_Col.Size = new System.Drawing.Size(364, 36);
            this.TablePanel_Col.TabIndex = 0;
            // 
            // Btn_Reload
            // 
            this.Btn_Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Reload.BackgroundImage = global::MusicApp.Properties.Resources.reload;
            this.Btn_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Reload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Reload.FlatAppearance.BorderSize = 0;
            this.Btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reload.ForeColor = System.Drawing.Color.White;
            this.Btn_Reload.Location = new System.Drawing.Point(293, 3);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(68, 30);
            this.Btn_Reload.TabIndex = 0;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.Btn_Reload_Click);
            // 
            // Lb_Duration
            // 
            this.Lb_Duration.BackColor = System.Drawing.Color.Moccasin;
            this.Lb_Duration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Duration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Duration.Location = new System.Drawing.Point(221, 0);
            this.Lb_Duration.Name = "Lb_Duration";
            this.Lb_Duration.Size = new System.Drawing.Size(66, 36);
            this.Lb_Duration.TabIndex = 5;
            this.Lb_Duration.Text = "Time";
            this.Lb_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Name
            // 
            this.Lb_Name.BackColor = System.Drawing.Color.Moccasin;
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Name.Location = new System.Drawing.Point(3, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(212, 36);
            this.Lb_Name.TabIndex = 2;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPanel_Playlist
            // 
            this.FlowPanel_Playlist.AutoScroll = true;
            this.FlowPanel_Playlist.Location = new System.Drawing.Point(3, 78);
            this.FlowPanel_Playlist.Name = "FlowPanel_Playlist";
            this.FlowPanel_Playlist.Size = new System.Drawing.Size(397, 370);
            this.FlowPanel_Playlist.TabIndex = 2;
            // 
            // WMP_Media
            // 
            this.WMP_Media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP_Media.Enabled = true;
            this.WMP_Media.Location = new System.Drawing.Point(403, 0);
            this.WMP_Media.Name = "WMP_Media";
            this.WMP_Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP_Media.OcxState")));
            this.WMP_Media.Size = new System.Drawing.Size(433, 455);
            this.WMP_Media.TabIndex = 2;
            // 
            // Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WMP_Media);
            this.Controls.Add(this.FlowPanel_Header);
            this.Name = "Playing";
            this.Size = new System.Drawing.Size(836, 455);
            this.FlowPanel_Header.ResumeLayout(false);
            this.FlowPanel_Col.ResumeLayout(false);
            this.TablePanel_Col.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP_Media)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Header;
        private AxWMPLib.AxWindowsMediaPlayer WMP_Media;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Playlist;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Col;
        private System.Windows.Forms.TableLayoutPanel TablePanel_Col;
        private System.Windows.Forms.Button Btn_Reload;
        private System.Windows.Forms.Label Lb_Duration;
        private System.Windows.Forms.Label Lb_Name;
    }
}
