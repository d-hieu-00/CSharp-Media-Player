
namespace MusicApp.Forms.UserControls.TablePlaylist
{
    partial class RowPlaylist
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
            this.TablePanel_Row = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.TablePanel_Row.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePanel_Row
            // 
            this.TablePanel_Row.ColumnCount = 4;
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_Row.Controls.Add(this.Btn_Play, 0, 0);
            this.TablePanel_Row.Controls.Add(this.Lb_Name, 0, 0);
            this.TablePanel_Row.Controls.Add(this.Btn_Del, 3, 0);
            this.TablePanel_Row.Controls.Add(this.Btn_Edit, 2, 0);
            this.TablePanel_Row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel_Row.Location = new System.Drawing.Point(0, 0);
            this.TablePanel_Row.Name = "TablePanel_Row";
            this.TablePanel_Row.RowCount = 1;
            this.TablePanel_Row.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_Row.Size = new System.Drawing.Size(414, 36);
            this.TablePanel_Row.TabIndex = 7;
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Play.BackgroundImage = global::MusicApp.Properties.Resources.play_button;
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Play.FlatAppearance.BorderSize = 0;
            this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Play.ForeColor = System.Drawing.Color.White;
            this.Btn_Play.Location = new System.Drawing.Point(305, 3);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(30, 30);
            this.Btn_Play.TabIndex = 8;
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // Lb_Name
            // 
            this.Lb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ForeColor = System.Drawing.Color.White;
            this.Lb_Name.Location = new System.Drawing.Point(3, 0);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(296, 36);
            this.Lb_Name.TabIndex = 5;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Name.Click += new System.EventHandler(this.Lb_Name_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.Btn_Del.FlatAppearance.BorderSize = 0;
            this.Btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Del.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del.ForeColor = System.Drawing.Color.White;
            this.Btn_Del.Location = new System.Drawing.Point(379, 3);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(30, 30);
            this.Btn_Del.TabIndex = 7;
            this.Btn_Del.Text = "X";
            this.Btn_Del.UseVisualStyleBackColor = false;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Edit.BackgroundImage = global::MusicApp.Properties.Resources.pencil;
            this.Btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Edit.FlatAppearance.BorderSize = 0;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.Location = new System.Drawing.Point(342, 3);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(30, 30);
            this.Btn_Edit.TabIndex = 6;
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // RowPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel_Row);
            this.Name = "RowPlaylist";
            this.Size = new System.Drawing.Size(414, 36);
            this.TablePanel_Row.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanel_Row;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.Button Btn_Play;
    }
}
