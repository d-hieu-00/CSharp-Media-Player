
namespace MusicApp.Forms.UserControls
{
    partial class VidExplore
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
            this.Lb_ColGenre = new System.Windows.Forms.Label();
            this.Lb_ColDirectors = new System.Windows.Forms.Label();
            this.Lb_ColName = new System.Windows.Forms.Label();
            this.Btn_Reload = new System.Windows.Forms.Button();
            this.Lb_ColYear = new System.Windows.Forms.Label();
            this.TablePanel_Column = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_ColTime = new System.Windows.Forms.Label();
            this.FlowPanel_WarpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowPanel_TableVideos = new System.Windows.Forms.FlowLayoutPanel();
            this.Lb_Header = new System.Windows.Forms.Label();
            this.Tbox_NameSearch = new System.Windows.Forms.TextBox();
            this.Btn_Sreach = new System.Windows.Forms.Button();
            this.Cbox_Genre = new System.Windows.Forms.ComboBox();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.PanelWarp_TboxNameSreach = new System.Windows.Forms.Panel();
            this.Btn_PlayAllVideos = new System.Windows.Forms.Button();
            this.Lb_OrderBy = new System.Windows.Forms.Label();
            this.Cbox_Order = new System.Windows.Forms.ComboBox();
            this.Lb_Director = new System.Windows.Forms.Label();
            this.Lb_Genre = new System.Windows.Forms.Label();
            this.Cbox_Director = new System.Windows.Forms.ComboBox();
            this.Grbox_GroupBy = new System.Windows.Forms.GroupBox();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Grbox_Sreach = new System.Windows.Forms.GroupBox();
            this.TablePanel_Column.SuspendLayout();
            this.FlowPanel_WarpTable.SuspendLayout();
            this.PanelWarp_TboxNameSreach.SuspendLayout();
            this.Grbox_GroupBy.SuspendLayout();
            this.Panel_Top.SuspendLayout();
            this.Grbox_Sreach.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_ColGenre
            // 
            this.Lb_ColGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColGenre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColGenre.Location = new System.Drawing.Point(252, 0);
            this.Lb_ColGenre.Name = "Lb_ColGenre";
            this.Lb_ColGenre.Size = new System.Drawing.Size(114, 36);
            this.Lb_ColGenre.TabIndex = 5;
            this.Lb_ColGenre.Text = "Genre";
            this.Lb_ColGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_ColDirectors
            // 
            this.Lb_ColDirectors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColDirectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColDirectors.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColDirectors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColDirectors.Location = new System.Drawing.Point(372, 0);
            this.Lb_ColDirectors.Name = "Lb_ColDirectors";
            this.Lb_ColDirectors.Size = new System.Drawing.Size(187, 36);
            this.Lb_ColDirectors.TabIndex = 1;
            this.Lb_ColDirectors.Text = "Directors";
            this.Lb_ColDirectors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_ColName
            // 
            this.Lb_ColName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColName.Location = new System.Drawing.Point(3, 0);
            this.Lb_ColName.Name = "Lb_ColName";
            this.Lb_ColName.Size = new System.Drawing.Size(243, 36);
            this.Lb_ColName.TabIndex = 0;
            this.Lb_ColName.Text = "Name";
            this.Lb_ColName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Reload
            // 
            this.Btn_Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Reload.BackgroundImage = global::MusicApp.Properties.Resources.reload;
            this.Btn_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Reload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Reload.FlatAppearance.BorderSize = 0;
            this.Btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reload.Location = new System.Drawing.Point(733, 3);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(70, 30);
            this.Btn_Reload.TabIndex = 6;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.Btn_Reload_Click);
            // 
            // Lb_ColYear
            // 
            this.Lb_ColYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColYear.Location = new System.Drawing.Point(661, 0);
            this.Lb_ColYear.Name = "Lb_ColYear";
            this.Lb_ColYear.Size = new System.Drawing.Size(66, 36);
            this.Lb_ColYear.TabIndex = 8;
            this.Lb_ColYear.Text = "Year";
            this.Lb_ColYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablePanel_Column
            // 
            this.TablePanel_Column.BackColor = System.Drawing.Color.White;
            this.TablePanel_Column.ColumnCount = 6;
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_Column.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_Column.Controls.Add(this.Lb_ColGenre, 0, 0);
            this.TablePanel_Column.Controls.Add(this.Lb_ColDirectors, 1, 0);
            this.TablePanel_Column.Controls.Add(this.Lb_ColName, 0, 0);
            this.TablePanel_Column.Controls.Add(this.Btn_Reload, 5, 0);
            this.TablePanel_Column.Controls.Add(this.Lb_ColTime, 3, 0);
            this.TablePanel_Column.Controls.Add(this.Lb_ColYear, 4, 0);
            this.TablePanel_Column.Location = new System.Drawing.Point(3, 3);
            this.TablePanel_Column.Name = "TablePanel_Column";
            this.TablePanel_Column.RowCount = 1;
            this.TablePanel_Column.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_Column.Size = new System.Drawing.Size(806, 36);
            this.TablePanel_Column.TabIndex = 0;
            // 
            // Lb_ColTime
            // 
            this.Lb_ColTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColTime.Location = new System.Drawing.Point(565, 0);
            this.Lb_ColTime.Name = "Lb_ColTime";
            this.Lb_ColTime.Size = new System.Drawing.Size(90, 36);
            this.Lb_ColTime.TabIndex = 4;
            this.Lb_ColTime.Text = "Time";
            this.Lb_ColTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPanel_WarpTable
            // 
            this.FlowPanel_WarpTable.BackColor = System.Drawing.Color.White;
            this.FlowPanel_WarpTable.Controls.Add(this.TablePanel_Column);
            this.FlowPanel_WarpTable.Controls.Add(this.FlowPanel_TableVideos);
            this.FlowPanel_WarpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_WarpTable.Location = new System.Drawing.Point(0, 117);
            this.FlowPanel_WarpTable.Name = "FlowPanel_WarpTable";
            this.FlowPanel_WarpTable.Size = new System.Drawing.Size(836, 338);
            this.FlowPanel_WarpTable.TabIndex = 9;
            // 
            // FlowPanel_TableVideos
            // 
            this.FlowPanel_TableVideos.AutoScroll = true;
            this.FlowPanel_TableVideos.Location = new System.Drawing.Point(3, 45);
            this.FlowPanel_TableVideos.Name = "FlowPanel_TableVideos";
            this.FlowPanel_TableVideos.Size = new System.Drawing.Size(830, 285);
            this.FlowPanel_TableVideos.TabIndex = 1;
            // 
            // Lb_Header
            // 
            this.Lb_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_Header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lb_Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Header.ForeColor = System.Drawing.Color.White;
            this.Lb_Header.Location = new System.Drawing.Point(0, 89);
            this.Lb_Header.Name = "Lb_Header";
            this.Lb_Header.Size = new System.Drawing.Size(836, 28);
            this.Lb_Header.TabIndex = 4;
            this.Lb_Header.Text = "List of all videos";
            this.Lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbox_NameSearch
            // 
            this.Tbox_NameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_NameSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_NameSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_NameSearch.Location = new System.Drawing.Point(4, 2);
            this.Tbox_NameSearch.Name = "Tbox_NameSearch";
            this.Tbox_NameSearch.Size = new System.Drawing.Size(162, 18);
            this.Tbox_NameSearch.TabIndex = 0;
            // 
            // Btn_Sreach
            // 
            this.Btn_Sreach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Sreach.FlatAppearance.BorderSize = 0;
            this.Btn_Sreach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sreach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sreach.ForeColor = System.Drawing.Color.White;
            this.Btn_Sreach.Location = new System.Drawing.Point(140, 46);
            this.Btn_Sreach.Name = "Btn_Sreach";
            this.Btn_Sreach.Size = new System.Drawing.Size(88, 25);
            this.Btn_Sreach.TabIndex = 7;
            this.Btn_Sreach.Text = "Sreach";
            this.Btn_Sreach.UseVisualStyleBackColor = false;
            this.Btn_Sreach.Click += new System.EventHandler(this.Btn_Sreach_Click);
            // 
            // Cbox_Genre
            // 
            this.Cbox_Genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Cbox_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbox_Genre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Genre.ForeColor = System.Drawing.Color.White;
            this.Cbox_Genre.FormattingEnabled = true;
            this.Cbox_Genre.Location = new System.Drawing.Point(15, 47);
            this.Cbox_Genre.Name = "Cbox_Genre";
            this.Cbox_Genre.Size = new System.Drawing.Size(121, 25);
            this.Cbox_Genre.TabIndex = 0;
            this.Cbox_Genre.SelectedIndexChanged += new System.EventHandler(this.Cbox_Genre_SelectedIndexChanged);
            this.Cbox_Genre.DropDownClosed += new System.EventHandler(this.Cbox_DropDownClosed);
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.Location = new System.Drawing.Point(7, 20);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(43, 17);
            this.Lb_Name.TabIndex = 2;
            this.Lb_Name.Text = "Name";
            // 
            // PanelWarp_TboxNameSreach
            // 
            this.PanelWarp_TboxNameSreach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxNameSreach.Controls.Add(this.Tbox_NameSearch);
            this.PanelWarp_TboxNameSreach.Location = new System.Drawing.Point(57, 19);
            this.PanelWarp_TboxNameSreach.Name = "PanelWarp_TboxNameSreach";
            this.PanelWarp_TboxNameSreach.Size = new System.Drawing.Size(171, 20);
            this.PanelWarp_TboxNameSreach.TabIndex = 1;
            // 
            // Btn_PlayAllVideos
            // 
            this.Btn_PlayAllVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_PlayAllVideos.FlatAppearance.BorderSize = 0;
            this.Btn_PlayAllVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PlayAllVideos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PlayAllVideos.ForeColor = System.Drawing.Color.White;
            this.Btn_PlayAllVideos.Location = new System.Drawing.Point(424, 45);
            this.Btn_PlayAllVideos.Name = "Btn_PlayAllVideos";
            this.Btn_PlayAllVideos.Size = new System.Drawing.Size(140, 25);
            this.Btn_PlayAllVideos.TabIndex = 8;
            this.Btn_PlayAllVideos.Text = "Play all videos";
            this.Btn_PlayAllVideos.UseVisualStyleBackColor = false;
            this.Btn_PlayAllVideos.Click += new System.EventHandler(this.Btn_PlayAllVideos_Click);
            // 
            // Lb_OrderBy
            // 
            this.Lb_OrderBy.AutoSize = true;
            this.Lb_OrderBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_OrderBy.Location = new System.Drawing.Point(296, 22);
            this.Lb_OrderBy.Name = "Lb_OrderBy";
            this.Lb_OrderBy.Size = new System.Drawing.Size(61, 17);
            this.Lb_OrderBy.TabIndex = 7;
            this.Lb_OrderBy.Text = "Order by";
            // 
            // Cbox_Order
            // 
            this.Cbox_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Cbox_Order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbox_Order.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Order.ForeColor = System.Drawing.Color.White;
            this.Cbox_Order.FormattingEnabled = true;
            this.Cbox_Order.Items.AddRange(new object[] {
            "Name",
            "Time",
            "Year"});
            this.Cbox_Order.Location = new System.Drawing.Point(299, 46);
            this.Cbox_Order.Name = "Cbox_Order";
            this.Cbox_Order.Size = new System.Drawing.Size(106, 25);
            this.Cbox_Order.TabIndex = 6;
            this.Cbox_Order.SelectedIndexChanged += new System.EventHandler(this.Cbox_Order_SelectedIndexChanged);
            this.Cbox_Order.DropDownClosed += new System.EventHandler(this.Cbox_DropDownClosed);
            // 
            // Lb_Director
            // 
            this.Lb_Director.AutoSize = true;
            this.Lb_Director.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Director.Location = new System.Drawing.Point(153, 22);
            this.Lb_Director.Name = "Lb_Director";
            this.Lb_Director.Size = new System.Drawing.Size(55, 17);
            this.Lb_Director.TabIndex = 4;
            this.Lb_Director.Text = "Director";
            // 
            // Lb_Genre
            // 
            this.Lb_Genre.AutoSize = true;
            this.Lb_Genre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Genre.Location = new System.Drawing.Point(12, 22);
            this.Lb_Genre.Name = "Lb_Genre";
            this.Lb_Genre.Size = new System.Drawing.Size(43, 17);
            this.Lb_Genre.TabIndex = 3;
            this.Lb_Genre.Text = "Genre";
            // 
            // Cbox_Director
            // 
            this.Cbox_Director.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Cbox_Director.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Director.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbox_Director.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Director.ForeColor = System.Drawing.Color.White;
            this.Cbox_Director.FormattingEnabled = true;
            this.Cbox_Director.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Cbox_Director.Location = new System.Drawing.Point(156, 47);
            this.Cbox_Director.Name = "Cbox_Director";
            this.Cbox_Director.Size = new System.Drawing.Size(121, 25);
            this.Cbox_Director.TabIndex = 1;
            this.Cbox_Director.SelectedIndexChanged += new System.EventHandler(this.Cbox_Director_SelectedIndexChanged);
            this.Cbox_Director.DropDownClosed += new System.EventHandler(this.Cbox_DropDownClosed);
            // 
            // Grbox_GroupBy
            // 
            this.Grbox_GroupBy.Controls.Add(this.Btn_PlayAllVideos);
            this.Grbox_GroupBy.Controls.Add(this.Lb_OrderBy);
            this.Grbox_GroupBy.Controls.Add(this.Cbox_Order);
            this.Grbox_GroupBy.Controls.Add(this.Lb_Director);
            this.Grbox_GroupBy.Controls.Add(this.Lb_Genre);
            this.Grbox_GroupBy.Controls.Add(this.Cbox_Director);
            this.Grbox_GroupBy.Controls.Add(this.Cbox_Genre);
            this.Grbox_GroupBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_GroupBy.Location = new System.Drawing.Point(255, 3);
            this.Grbox_GroupBy.Name = "Grbox_GroupBy";
            this.Grbox_GroupBy.Size = new System.Drawing.Size(570, 79);
            this.Grbox_GroupBy.TabIndex = 6;
            this.Grbox_GroupBy.TabStop = false;
            this.Grbox_GroupBy.Text = "Group by";
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.White;
            this.Panel_Top.Controls.Add(this.Grbox_GroupBy);
            this.Panel_Top.Controls.Add(this.Grbox_Sreach);
            this.Panel_Top.Controls.Add(this.Lb_Header);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(836, 117);
            this.Panel_Top.TabIndex = 8;
            // 
            // Grbox_Sreach
            // 
            this.Grbox_Sreach.Controls.Add(this.Btn_Sreach);
            this.Grbox_Sreach.Controls.Add(this.Lb_Name);
            this.Grbox_Sreach.Controls.Add(this.PanelWarp_TboxNameSreach);
            this.Grbox_Sreach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_Sreach.Location = new System.Drawing.Point(9, 3);
            this.Grbox_Sreach.Name = "Grbox_Sreach";
            this.Grbox_Sreach.Size = new System.Drawing.Size(240, 79);
            this.Grbox_Sreach.TabIndex = 5;
            this.Grbox_Sreach.TabStop = false;
            this.Grbox_Sreach.Text = "Sreach";
            // 
            // VidExplore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FlowPanel_WarpTable);
            this.Controls.Add(this.Panel_Top);
            this.Name = "VidExplore";
            this.Size = new System.Drawing.Size(836, 455);
            this.TablePanel_Column.ResumeLayout(false);
            this.FlowPanel_WarpTable.ResumeLayout(false);
            this.PanelWarp_TboxNameSreach.ResumeLayout(false);
            this.PanelWarp_TboxNameSreach.PerformLayout();
            this.Grbox_GroupBy.ResumeLayout(false);
            this.Grbox_GroupBy.PerformLayout();
            this.Panel_Top.ResumeLayout(false);
            this.Grbox_Sreach.ResumeLayout(false);
            this.Grbox_Sreach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_ColGenre;
        private System.Windows.Forms.Label Lb_ColDirectors;
        private System.Windows.Forms.Label Lb_ColName;
        private System.Windows.Forms.Button Btn_Reload;
        private System.Windows.Forms.Label Lb_ColYear;
        private System.Windows.Forms.TableLayoutPanel TablePanel_Column;
        private System.Windows.Forms.Label Lb_ColTime;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_WarpTable;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_TableVideos;
        private System.Windows.Forms.Label Lb_Header;
        private System.Windows.Forms.TextBox Tbox_NameSearch;
        private System.Windows.Forms.Button Btn_Sreach;
        private System.Windows.Forms.ComboBox Cbox_Genre;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Panel PanelWarp_TboxNameSreach;
        private System.Windows.Forms.Button Btn_PlayAllVideos;
        private System.Windows.Forms.Label Lb_OrderBy;
        private System.Windows.Forms.ComboBox Cbox_Order;
        private System.Windows.Forms.Label Lb_Director;
        private System.Windows.Forms.Label Lb_Genre;
        private System.Windows.Forms.ComboBox Cbox_Director;
        private System.Windows.Forms.GroupBox Grbox_GroupBy;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.GroupBox Grbox_Sreach;
    }
}
