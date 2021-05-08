
namespace MusicApp.Forms.UserControls.TablePlaylist
{
    partial class RowInfoPlaylist
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
            this.Btn_Del = new System.Windows.Forms.Button();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.TabelPanel_Row.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelPanel_Row
            // 
            this.TabelPanel_Row.ColumnCount = 3;
            this.TabelPanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TabelPanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TabelPanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelPanel_Row.Controls.Add(this.Btn_Del, 2, 0);
            this.TabelPanel_Row.Controls.Add(this.Lb_Name, 0, 0);
            this.TabelPanel_Row.Controls.Add(this.Lb_Time, 1, 0);
            this.TabelPanel_Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelPanel_Row.Location = new System.Drawing.Point(0, 0);
            this.TabelPanel_Row.Name = "TabelPanel_Row";
            this.TabelPanel_Row.RowCount = 1;
            this.TabelPanel_Row.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabelPanel_Row.Size = new System.Drawing.Size(352, 36);
            this.TabelPanel_Row.TabIndex = 2;
            // 
            // Btn_Del
            // 
            this.Btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.Btn_Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Del.FlatAppearance.BorderSize = 0;
            this.Btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Del.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del.ForeColor = System.Drawing.Color.White;
            this.Btn_Del.Location = new System.Drawing.Point(319, 3);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(30, 30);
            this.Btn_Del.TabIndex = 0;
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
            // RowInfoPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabelPanel_Row);
            this.Name = "RowInfoPlaylist";
            this.Size = new System.Drawing.Size(352, 36);
            this.TabelPanel_Row.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabelPanel_Row;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Label Lb_Time;
    }
}
