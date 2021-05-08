
namespace MusicApp.Forms.UserControls.TableNowPLaylist
{
    partial class RowTableNowPLaylist
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Status = new System.Windows.Forms.Button();
            this.Lb_Duration = new System.Windows.Forms.Label();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lb_Duration, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Del, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lb_Name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 36);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Btn_Status
            // 
            this.Btn_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Status.BackgroundImage = global::MusicApp.Properties.Resources.play_button;
            this.Btn_Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Status.FlatAppearance.BorderSize = 0;
            this.Btn_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Status.ForeColor = System.Drawing.Color.White;
            this.Btn_Status.Location = new System.Drawing.Point(293, 3);
            this.Btn_Status.Name = "Btn_Status";
            this.Btn_Status.Size = new System.Drawing.Size(30, 30);
            this.Btn_Status.TabIndex = 0;
            this.Btn_Status.UseVisualStyleBackColor = false;
            this.Btn_Status.Click += new System.EventHandler(this.Btn_Status_Click);
            // 
            // Lb_Duration
            // 
            this.Lb_Duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Duration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Duration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Duration.ForeColor = System.Drawing.Color.White;
            this.Lb_Duration.Location = new System.Drawing.Point(221, 0);
            this.Lb_Duration.Name = "Lb_Duration";
            this.Lb_Duration.Size = new System.Drawing.Size(66, 36);
            this.Lb_Duration.TabIndex = 5;
            this.Lb_Duration.Text = "Time";
            this.Lb_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Del
            // 
            this.Btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.Btn_Del.FlatAppearance.BorderSize = 0;
            this.Btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Del.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del.ForeColor = System.Drawing.Color.White;
            this.Btn_Del.Location = new System.Drawing.Point(329, 3);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(30, 30);
            this.Btn_Del.TabIndex = 1;
            this.Btn_Del.Text = "X";
            this.Btn_Del.UseVisualStyleBackColor = false;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Lb_Name
            // 
            this.Lb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ForeColor = System.Drawing.Color.White;
            this.Lb_Name.Location = new System.Drawing.Point(3, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(212, 36);
            this.Lb_Name.TabIndex = 2;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RowTableNowPLaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RowTableNowPLaylist";
            this.Size = new System.Drawing.Size(364, 36);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Status;
        private System.Windows.Forms.Label Lb_Duration;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.Label Lb_Name;
    }
}
