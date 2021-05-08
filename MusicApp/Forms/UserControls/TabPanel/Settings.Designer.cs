
namespace MusicApp.Forms.UserControls
{
    partial class Settings
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
            this.Btn_ReloadFolder = new System.Windows.Forms.Button();
            this.Btn_AddFolder = new System.Windows.Forms.Button();
            this.Panel_Info = new System.Windows.Forms.Panel();
            this.Card_Info = new MaterialSkin.Controls.MaterialCard();
            this.Lb_InfoActor = new System.Windows.Forms.Label();
            this.Picbox_Logo = new System.Windows.Forms.PictureBox();
            this.FlowPanel_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.TablePanel_Column = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_Dir = new System.Windows.Forms.Label();
            this.Lb_Num = new System.Windows.Forms.Label();
            this.FlowPanel_Data = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Info.SuspendLayout();
            this.Card_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Logo)).BeginInit();
            this.FlowPanel_Table.SuspendLayout();
            this.Panel_Container.SuspendLayout();
            this.TablePanel_Column.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ReloadFolder
            // 
            this.Btn_ReloadFolder.BackColor = System.Drawing.Color.White;
            this.Btn_ReloadFolder.FlatAppearance.BorderSize = 0;
            this.Btn_ReloadFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ReloadFolder.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReloadFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_ReloadFolder.Location = new System.Drawing.Point(172, 393);
            this.Btn_ReloadFolder.Name = "Btn_ReloadFolder";
            this.Btn_ReloadFolder.Size = new System.Drawing.Size(131, 42);
            this.Btn_ReloadFolder.TabIndex = 5;
            this.Btn_ReloadFolder.Text = "Reload";
            this.Btn_ReloadFolder.UseVisualStyleBackColor = false;
            this.Btn_ReloadFolder.Click += new System.EventHandler(this.Btn_ReloadFolder_Click);
            // 
            // Btn_AddFolder
            // 
            this.Btn_AddFolder.BackColor = System.Drawing.Color.White;
            this.Btn_AddFolder.FlatAppearance.BorderSize = 0;
            this.Btn_AddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddFolder.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_AddFolder.Location = new System.Drawing.Point(18, 393);
            this.Btn_AddFolder.Name = "Btn_AddFolder";
            this.Btn_AddFolder.Size = new System.Drawing.Size(131, 42);
            this.Btn_AddFolder.TabIndex = 6;
            this.Btn_AddFolder.Text = "Add folder";
            this.Btn_AddFolder.UseVisualStyleBackColor = false;
            this.Btn_AddFolder.Click += new System.EventHandler(this.Btn_AddFolder_Click);
            // 
            // Panel_Info
            // 
            this.Panel_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Panel_Info.Controls.Add(this.Card_Info);
            this.Panel_Info.Controls.Add(this.Picbox_Logo);
            this.Panel_Info.Controls.Add(this.Btn_ReloadFolder);
            this.Panel_Info.Controls.Add(this.Btn_AddFolder);
            this.Panel_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Info.Location = new System.Drawing.Point(518, 0);
            this.Panel_Info.Name = "Panel_Info";
            this.Panel_Info.Size = new System.Drawing.Size(318, 455);
            this.Panel_Info.TabIndex = 7;
            // 
            // Card_Info
            // 
            this.Card_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card_Info.Controls.Add(this.Lb_InfoActor);
            this.Card_Info.Depth = 0;
            this.Card_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card_Info.Location = new System.Drawing.Point(18, 199);
            this.Card_Info.Margin = new System.Windows.Forms.Padding(14);
            this.Card_Info.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card_Info.Name = "Card_Info";
            this.Card_Info.Padding = new System.Windows.Forms.Padding(14);
            this.Card_Info.Size = new System.Drawing.Size(285, 177);
            this.Card_Info.TabIndex = 9;
            // 
            // Lb_InfoActor
            // 
            this.Lb_InfoActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_InfoActor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_InfoActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_InfoActor.Location = new System.Drawing.Point(14, 14);
            this.Lb_InfoActor.Name = "Lb_InfoActor";
            this.Lb_InfoActor.Size = new System.Drawing.Size(257, 149);
            this.Lb_InfoActor.TabIndex = 8;
            this.Lb_InfoActor.Text = "Thêm thư mục chứa các file media\r\nCác định dạng được hỗ trợ:\r\n   + mp3, wma, wav," +
    " m4a, ogg\r\n   + mp4, m4v, mkv, mov, 3gp, wmv";
            this.Lb_InfoActor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Picbox_Logo
            // 
            this.Picbox_Logo.Image = global::MusicApp.Properties.Resources.Cat_roll;
            this.Picbox_Logo.Location = new System.Drawing.Point(68, 12);
            this.Picbox_Logo.Name = "Picbox_Logo";
            this.Picbox_Logo.Size = new System.Drawing.Size(185, 170);
            this.Picbox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbox_Logo.TabIndex = 7;
            this.Picbox_Logo.TabStop = false;
            // 
            // FlowPanel_Table
            // 
            this.FlowPanel_Table.Controls.Add(this.Lb_Title);
            this.FlowPanel_Table.Controls.Add(this.Panel_Container);
            this.FlowPanel_Table.Controls.Add(this.FlowPanel_Data);
            this.FlowPanel_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_Table.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel_Table.Name = "FlowPanel_Table";
            this.FlowPanel_Table.Size = new System.Drawing.Size(518, 455);
            this.FlowPanel_Table.TabIndex = 8;
            // 
            // Lb_Title
            // 
            this.Lb_Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Title.Location = new System.Drawing.Point(3, 0);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(468, 39);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "List of imported directories";
            this.Lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_Container
            // 
            this.Panel_Container.Controls.Add(this.TablePanel_Column);
            this.Panel_Container.Location = new System.Drawing.Point(3, 42);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(509, 35);
            this.Panel_Container.TabIndex = 3;
            // 
            // TablePanel_Column
            // 
            this.TablePanel_Column.ColumnCount = 3;
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanel_Column.Controls.Add(this.Lb_Dir, 1, 0);
            this.TablePanel_Column.Controls.Add(this.Lb_Num, 0, 0);
            this.TablePanel_Column.Location = new System.Drawing.Point(3, 0);
            this.TablePanel_Column.Name = "TablePanel_Column";
            this.TablePanel_Column.RowCount = 1;
            this.TablePanel_Column.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TablePanel_Column.Size = new System.Drawing.Size(465, 35);
            this.TablePanel_Column.TabIndex = 1;
            // 
            // Lb_Dir
            // 
            this.Lb_Dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Dir.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lb_Dir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Dir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Dir.ForeColor = System.Drawing.Color.White;
            this.Lb_Dir.Location = new System.Drawing.Point(49, 0);
            this.Lb_Dir.Name = "Lb_Dir";
            this.Lb_Dir.Size = new System.Drawing.Size(366, 35);
            this.Lb_Dir.TabIndex = 1;
            this.Lb_Dir.Text = "Directory";
            this.Lb_Dir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Num
            // 
            this.Lb_Num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Num.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Num.ForeColor = System.Drawing.Color.White;
            this.Lb_Num.Location = new System.Drawing.Point(3, 0);
            this.Lb_Num.Name = "Lb_Num";
            this.Lb_Num.Size = new System.Drawing.Size(40, 35);
            this.Lb_Num.TabIndex = 0;
            this.Lb_Num.Text = "No.";
            this.Lb_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPanel_Data
            // 
            this.FlowPanel_Data.AutoScroll = true;
            this.FlowPanel_Data.Location = new System.Drawing.Point(3, 83);
            this.FlowPanel_Data.Name = "FlowPanel_Data";
            this.FlowPanel_Data.Size = new System.Drawing.Size(509, 369);
            this.FlowPanel_Data.TabIndex = 2;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FlowPanel_Table);
            this.Controls.Add(this.Panel_Info);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(836, 455);
            this.Panel_Info.ResumeLayout(false);
            this.Card_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Logo)).EndInit();
            this.FlowPanel_Table.ResumeLayout(false);
            this.Panel_Container.ResumeLayout(false);
            this.TablePanel_Column.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ReloadFolder;
        private System.Windows.Forms.Button Btn_AddFolder;
        private System.Windows.Forms.Panel Panel_Info;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Table;
        private System.Windows.Forms.PictureBox Picbox_Logo;
        private System.Windows.Forms.Label Lb_InfoActor;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.TableLayoutPanel TablePanel_Column;
        private System.Windows.Forms.Label Lb_Dir;
        private System.Windows.Forms.Label Lb_Num;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Data;
        private System.Windows.Forms.Panel Panel_Container;
        private MaterialSkin.Controls.MaterialCard Card_Info;
    }
}
