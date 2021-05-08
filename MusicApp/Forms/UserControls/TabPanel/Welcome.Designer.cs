
namespace MusicApp.Forms.UserControls.TabPanel
{
    partial class Welcome
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
            this.Card_Left = new MaterialSkin.Controls.MaterialCard();
            this.Lb_AddFolder = new System.Windows.Forms.Label();
            this.Btn_AddFolder = new System.Windows.Forms.Button();
            this.Lb_Welcome = new System.Windows.Forms.Label();
            this.Lb_List = new System.Windows.Forms.Label();
            this.Lb_Feature = new System.Windows.Forms.Label();
            this.Card_Right = new MaterialSkin.Controls.MaterialCard();
            this.Lb_InfoActor = new System.Windows.Forms.Label();
            this.Picbox_GifCat = new System.Windows.Forms.PictureBox();
            this.Picbox_LogoApp = new System.Windows.Forms.PictureBox();
            this.Card_Left.SuspendLayout();
            this.Card_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_GifCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_LogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // Card_Left
            // 
            this.Card_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card_Left.Controls.Add(this.Lb_AddFolder);
            this.Card_Left.Controls.Add(this.Btn_AddFolder);
            this.Card_Left.Depth = 0;
            this.Card_Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card_Left.Location = new System.Drawing.Point(34, 285);
            this.Card_Left.Margin = new System.Windows.Forms.Padding(14);
            this.Card_Left.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card_Left.Name = "Card_Left";
            this.Card_Left.Padding = new System.Windows.Forms.Padding(14);
            this.Card_Left.Size = new System.Drawing.Size(337, 224);
            this.Card_Left.TabIndex = 7;
            // 
            // Lb_AddFolder
            // 
            this.Lb_AddFolder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AddFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lb_AddFolder.Location = new System.Drawing.Point(17, 30);
            this.Lb_AddFolder.Name = "Lb_AddFolder";
            this.Lb_AddFolder.Size = new System.Drawing.Size(303, 73);
            this.Lb_AddFolder.TabIndex = 3;
            this.Lb_AddFolder.Text = "Add folder have media file\r\nto play";
            this.Lb_AddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_AddFolder
            // 
            this.Btn_AddFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_AddFolder.FlatAppearance.BorderSize = 0;
            this.Btn_AddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddFolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddFolder.ForeColor = System.Drawing.Color.White;
            this.Btn_AddFolder.Location = new System.Drawing.Point(73, 143);
            this.Btn_AddFolder.Name = "Btn_AddFolder";
            this.Btn_AddFolder.Size = new System.Drawing.Size(185, 42);
            this.Btn_AddFolder.TabIndex = 4;
            this.Btn_AddFolder.Text = "Add folder";
            this.Btn_AddFolder.UseVisualStyleBackColor = false;
            this.Btn_AddFolder.Click += new System.EventHandler(this.Btn_AddFolder_Click);
            // 
            // Lb_Welcome
            // 
            this.Lb_Welcome.BackColor = System.Drawing.Color.White;
            this.Lb_Welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lb_Welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Welcome.Location = new System.Drawing.Point(0, 0);
            this.Lb_Welcome.Name = "Lb_Welcome";
            this.Lb_Welcome.Size = new System.Drawing.Size(836, 48);
            this.Lb_Welcome.TabIndex = 6;
            this.Lb_Welcome.Text = "Welcome to Era Media Player";
            this.Lb_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_List
            // 
            this.Lb_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lb_List.Location = new System.Drawing.Point(17, 53);
            this.Lb_List.Name = "Lb_List";
            this.Lb_List.Size = new System.Drawing.Size(306, 157);
            this.Lb_List.TabIndex = 4;
            this.Lb_List.Text = "+ Nghe nhạc\r\n+ Xem video\r\n+ Tạo playlist\r\n+ Sửa thông tin cơ bản của file\r\nHỗ trợ" +
    " các định dạng:\r\n+ Audio: mp3, wma, wav, m4a, ogg\r\n+ Video: mp4, m4v, mkv, mov, " +
    "3gp, wmv";
            this.Lb_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Feature
            // 
            this.Lb_Feature.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Feature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lb_Feature.Location = new System.Drawing.Point(17, 14);
            this.Lb_Feature.Name = "Lb_Feature";
            this.Lb_Feature.Size = new System.Drawing.Size(303, 43);
            this.Lb_Feature.TabIndex = 3;
            this.Lb_Feature.Text = "Tính năng ứng dụng:\r\n";
            this.Lb_Feature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Card_Right
            // 
            this.Card_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card_Right.Controls.Add(this.Lb_List);
            this.Card_Right.Controls.Add(this.Lb_Feature);
            this.Card_Right.Depth = 0;
            this.Card_Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card_Right.Location = new System.Drawing.Point(448, 285);
            this.Card_Right.Margin = new System.Windows.Forms.Padding(14);
            this.Card_Right.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card_Right.Name = "Card_Right";
            this.Card_Right.Padding = new System.Windows.Forms.Padding(14);
            this.Card_Right.Size = new System.Drawing.Size(337, 224);
            this.Card_Right.TabIndex = 8;
            // 
            // Lb_InfoActor
            // 
            this.Lb_InfoActor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_InfoActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.Lb_InfoActor.Location = new System.Drawing.Point(240, 96);
            this.Lb_InfoActor.Name = "Lb_InfoActor";
            this.Lb_InfoActor.Size = new System.Drawing.Size(257, 149);
            this.Lb_InfoActor.TabIndex = 10;
            this.Lb_InfoActor.Text = "Sinh viên thực hiện:\r\n     Nguyễn Duy Hiệu  -- 18520746\r\n\r\n     Khoa: hệ thống th" +
    "ông tin\r\n     Mã lớp: HTTT2018\r\n     Mã môn học: CS511.L21\r\n";
            this.Lb_InfoActor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Picbox_GifCat
            // 
            this.Picbox_GifCat.Image = global::MusicApp.Properties.Resources.Cat_roll;
            this.Picbox_GifCat.Location = new System.Drawing.Point(583, 95);
            this.Picbox_GifCat.Name = "Picbox_GifCat";
            this.Picbox_GifCat.Size = new System.Drawing.Size(185, 150);
            this.Picbox_GifCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_GifCat.TabIndex = 11;
            this.Picbox_GifCat.TabStop = false;
            // 
            // Picbox_LogoApp
            // 
            this.Picbox_LogoApp.Image = global::MusicApp.Properties.Resources.app_logo_transparent;
            this.Picbox_LogoApp.Location = new System.Drawing.Point(34, 68);
            this.Picbox_LogoApp.Name = "Picbox_LogoApp";
            this.Picbox_LogoApp.Size = new System.Drawing.Size(200, 200);
            this.Picbox_LogoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picbox_LogoApp.TabIndex = 9;
            this.Picbox_LogoApp.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Picbox_GifCat);
            this.Controls.Add(this.Lb_InfoActor);
            this.Controls.Add(this.Picbox_LogoApp);
            this.Controls.Add(this.Card_Left);
            this.Controls.Add(this.Lb_Welcome);
            this.Controls.Add(this.Card_Right);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(836, 533);
            this.Card_Left.ResumeLayout(false);
            this.Card_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_GifCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_LogoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard Card_Left;
        private System.Windows.Forms.Label Lb_AddFolder;
        private System.Windows.Forms.Button Btn_AddFolder;
        private System.Windows.Forms.Label Lb_Welcome;
        private System.Windows.Forms.Label Lb_List;
        private System.Windows.Forms.Label Lb_Feature;
        private MaterialSkin.Controls.MaterialCard Card_Right;
        private System.Windows.Forms.PictureBox Picbox_LogoApp;
        private System.Windows.Forms.Label Lb_InfoActor;
        private System.Windows.Forms.PictureBox Picbox_GifCat;
    }
}
