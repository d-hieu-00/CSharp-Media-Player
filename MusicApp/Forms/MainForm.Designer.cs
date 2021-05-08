
namespace MusicApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Lb_Close = new System.Windows.Forms.Label();
            this.Panel_SideBar = new System.Windows.Forms.Panel();
            this.Panel_Control = new System.Windows.Forms.Panel();
            this.Lb_Minimize = new System.Windows.Forms.Label();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Lb_Status = new System.Windows.Forms.Label();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Close
            // 
            this.Lb_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.Lb_Close.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Close.ForeColor = System.Drawing.Color.White;
            this.Lb_Close.Location = new System.Drawing.Point(961, 4);
            this.Lb_Close.Name = "Lb_Close";
            this.Lb_Close.Size = new System.Drawing.Size(40, 32);
            this.Lb_Close.TabIndex = 1;
            this.Lb_Close.Text = "X";
            this.Lb_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lb_Close.Click += new System.EventHandler(this.Lb_Close_Click);
            this.Lb_Close.MouseEnter += new System.EventHandler(this.Lb_Close_MouseEnter);
            this.Lb_Close.MouseLeave += new System.EventHandler(this.Lb_Close_MouseLeave);
            // 
            // Panel_SideBar
            // 
            this.Panel_SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(102)))), ((int)(((byte)(120)))));
            this.Panel_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_SideBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_SideBar.Name = "Panel_SideBar";
            this.Panel_SideBar.Size = new System.Drawing.Size(170, 573);
            this.Panel_SideBar.TabIndex = 2;
            this.Panel_SideBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Panel_SideBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Panel_SideBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // Panel_Control
            // 
            this.Panel_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Control.Location = new System.Drawing.Point(170, 573);
            this.Panel_Control.Name = "Panel_Control";
            this.Panel_Control.Size = new System.Drawing.Size(836, 0);
            this.Panel_Control.TabIndex = 3;
            // 
            // Lb_Minimize
            // 
            this.Lb_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.Lb_Minimize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Minimize.ForeColor = System.Drawing.Color.White;
            this.Lb_Minimize.Location = new System.Drawing.Point(915, 4);
            this.Lb_Minimize.Name = "Lb_Minimize";
            this.Lb_Minimize.Size = new System.Drawing.Size(40, 32);
            this.Lb_Minimize.TabIndex = 5;
            this.Lb_Minimize.Text = "-";
            this.Lb_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lb_Minimize.Click += new System.EventHandler(this.Lb_Minimize_Click);
            this.Lb_Minimize.MouseEnter += new System.EventHandler(this.Lb_Minimize_MouseEnter);
            this.Lb_Minimize.MouseLeave += new System.EventHandler(this.Lb_Minimize_MouseLeave);
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(144)))), ((int)(((byte)(142)))));
            this.Panel_Header.Controls.Add(this.Lb_Status);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(170, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(836, 40);
            this.Panel_Header.TabIndex = 6;
            this.Panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.Panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Panel_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // Lb_Status
            // 
            this.Lb_Status.AutoSize = true;
            this.Lb_Status.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Status.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lb_Status.Location = new System.Drawing.Point(6, 11);
            this.Lb_Status.Name = "Lb_Status";
            this.Lb_Status.Size = new System.Drawing.Size(79, 20);
            this.Lb_Status.TabIndex = 0;
            this.Lb_Status.Text = "No playing";
            // 
            // Panel_Main
            // 
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(170, 40);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(836, 533);
            this.Panel_Main.TabIndex = 7;
            this.Panel_Main.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Panel_Main_ControlRemoved);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 573);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Lb_Minimize);
            this.Controls.Add(this.Lb_Close);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Control);
            this.Controls.Add(this.Panel_SideBar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1006, 573);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_Close;
        private System.Windows.Forms.Panel Panel_SideBar;
        private System.Windows.Forms.Panel Panel_Control;
        private System.Windows.Forms.Label Lb_Minimize;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Label Lb_Status;
    }
}