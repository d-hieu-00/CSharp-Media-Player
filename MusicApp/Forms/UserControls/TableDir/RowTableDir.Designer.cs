
namespace MusicApp.Forms.UserControls.TableDir
{
    partial class RowTableDir
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
            this.Lb_Dir = new System.Windows.Forms.Label();
            this.Lb_Num = new System.Windows.Forms.Label();
            this.Btn_DelFolder = new System.Windows.Forms.Button();
            this.TablePanel_Row = new System.Windows.Forms.TableLayoutPanel();
            this.TablePanel_Row.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Dir
            // 
            this.Lb_Dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Dir.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lb_Dir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Dir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Dir.ForeColor = System.Drawing.Color.White;
            this.Lb_Dir.Location = new System.Drawing.Point(49, 0);
            this.Lb_Dir.Name = "Lb_Dir";
            this.Lb_Dir.Size = new System.Drawing.Size(366, 35);
            this.Lb_Dir.TabIndex = 1;
            this.Lb_Dir.Text = "Directory";
            this.Lb_Dir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Num
            // 
            this.Lb_Num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.Lb_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_Num.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Num.ForeColor = System.Drawing.Color.White;
            this.Lb_Num.Location = new System.Drawing.Point(3, 0);
            this.Lb_Num.Name = "Lb_Num";
            this.Lb_Num.Size = new System.Drawing.Size(40, 35);
            this.Lb_Num.TabIndex = 0;
            this.Lb_Num.Text = "No.";
            this.Lb_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_DelFolder
            // 
            this.Btn_DelFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.Btn_DelFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_DelFolder.FlatAppearance.BorderSize = 0;
            this.Btn_DelFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DelFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DelFolder.ForeColor = System.Drawing.Color.White;
            this.Btn_DelFolder.Location = new System.Drawing.Point(421, 3);
            this.Btn_DelFolder.Name = "Btn_DelFolder";
            this.Btn_DelFolder.Size = new System.Drawing.Size(41, 29);
            this.Btn_DelFolder.TabIndex = 2;
            this.Btn_DelFolder.Text = "X";
            this.Btn_DelFolder.UseVisualStyleBackColor = false;
            this.Btn_DelFolder.Click += new System.EventHandler(this.Btn_DelFolder_Click);
            // 
            // TablePanel_Row
            // 
            this.TablePanel_Row.ColumnCount = 3;
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TablePanel_Row.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanel_Row.Controls.Add(this.Lb_Num, 0, 0);
            this.TablePanel_Row.Controls.Add(this.Btn_DelFolder, 2, 0);
            this.TablePanel_Row.Controls.Add(this.Lb_Dir, 1, 0);
            this.TablePanel_Row.Location = new System.Drawing.Point(0, 0);
            this.TablePanel_Row.Name = "TablePanel_Row";
            this.TablePanel_Row.RowCount = 1;
            this.TablePanel_Row.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_Row.Size = new System.Drawing.Size(465, 35);
            this.TablePanel_Row.TabIndex = 3;
            // 
            // RowTableDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel_Row);
            this.Name = "RowTableDir";
            this.Size = new System.Drawing.Size(465, 35);
            this.TablePanel_Row.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lb_Dir;
        private System.Windows.Forms.Label Lb_Num;
        private System.Windows.Forms.Button Btn_DelFolder;
        private System.Windows.Forms.TableLayoutPanel TablePanel_Row;
    }
}
