
namespace MusicApp.Forms.UserControls.TablePlaylist
{
    partial class EditPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlaylist));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lb_Header = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.PanelWarp_TboxName = new System.Windows.Forms.Panel();
            this.Tbox_Name = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Panel_Main.SuspendLayout();
            this.PanelWarp_TboxName.SuspendLayout();
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
            this.Panel_Header.Size = new System.Drawing.Size(274, 39);
            this.Panel_Header.TabIndex = 0;
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
            this.Lb_Header.Size = new System.Drawing.Size(87, 17);
            this.Lb_Header.TabIndex = 1;
            this.Lb_Header.Text = "Edit playlist - ";
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
            this.Btn_Close.Location = new System.Drawing.Point(228, 3);
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
            this.Panel_Main.Controls.Add(this.PanelWarp_TboxName);
            this.Panel_Main.Controls.Add(this.Btn_OK);
            this.Panel_Main.Controls.Add(this.Lb_Name);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 39);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(274, 91);
            this.Panel_Main.TabIndex = 1;
            // 
            // PanelWarp_TboxName
            // 
            this.PanelWarp_TboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxName.Controls.Add(this.Tbox_Name);
            this.PanelWarp_TboxName.Location = new System.Drawing.Point(111, 15);
            this.PanelWarp_TboxName.Name = "PanelWarp_TboxName";
            this.PanelWarp_TboxName.Size = new System.Drawing.Size(151, 20);
            this.PanelWarp_TboxName.TabIndex = 3;
            // 
            // Tbox_Name
            // 
            this.Tbox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_Name.Location = new System.Drawing.Point(4, 2);
            this.Tbox_Name.Name = "Tbox_Name";
            this.Tbox_Name.Size = new System.Drawing.Size(143, 16);
            this.Tbox_Name.TabIndex = 0;
            // 
            // Btn_OK
            // 
            this.Btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_OK.FlatAppearance.BorderSize = 0;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.ForeColor = System.Drawing.Color.White;
            this.Btn_OK.Location = new System.Drawing.Point(161, 50);
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
            this.Lb_Name.Location = new System.Drawing.Point(12, 18);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(93, 15);
            this.Lb_Name.TabIndex = 1;
            this.Lb_Name.Text = "Name of playlist";
            // 
            // EditPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 130);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPlaylist";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            this.PanelWarp_TboxName.ResumeLayout(false);
            this.PanelWarp_TboxName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label Lb_Header;
        private System.Windows.Forms.Panel PanelWarp_TboxName;
        private System.Windows.Forms.TextBox Tbox_Name;
    }
}