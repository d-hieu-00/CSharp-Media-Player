
namespace MusicApp.Forms.UserControls
{
    partial class SongAlbum
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
            this.components = new System.ComponentModel.Container();
            this.FlowPanel_ListInfoAlbum = new System.Windows.Forms.FlowLayoutPanel();
            this.Lb_NameInfoAlbum = new System.Windows.Forms.Label();
            this.Lb_HeaderAlbumInfo = new System.Windows.Forms.Label();
            this.TablePanel_HeaderColInfoAlbum = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_TimeInfoAlbum = new System.Windows.Forms.Label();
            this.FlowPanel_HeaderInfoAlbum = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowPanel_Left = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelWarp_TboxNameSreach = new System.Windows.Forms.Panel();
            this.Tbox_NameSearch = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lb_NameSearch = new System.Windows.Forms.Label();
            this.Grbox_Search = new System.Windows.Forms.GroupBox();
            this.Panel_HeaderGroupFunction = new System.Windows.Forms.Panel();
            this.Grbox_GroupBy = new System.Windows.Forms.GroupBox();
            this.Lb_OrderBy = new System.Windows.Forms.Label();
            this.Cbox_Order = new System.Windows.Forms.ComboBox();
            this.Lb_Artist = new System.Windows.Forms.Label();
            this.Cbox_Artist = new System.Windows.Forms.ComboBox();
            this.Lb_ColNameListAlbum = new System.Windows.Forms.Label();
            this.Lb_HeaderListAlbum = new System.Windows.Forms.Label();
            this.TablePanel_HeaderColListAlbum = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_ColArtist = new System.Windows.Forms.Label();
            this.Btn_Reload = new System.Windows.Forms.Button();
            this.FlowPanel_HeaderTBAlbum = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowPanel_TableAlbum = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowPanel_ListAlbum = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Right = new System.Windows.Forms.Panel();
            this.Timer_CheckPlayingAlbum = new System.Windows.Forms.Timer(this.components);
            this.TablePanel_HeaderColInfoAlbum.SuspendLayout();
            this.FlowPanel_HeaderInfoAlbum.SuspendLayout();
            this.FlowPanel_Left.SuspendLayout();
            this.PanelWarp_TboxNameSreach.SuspendLayout();
            this.Grbox_Search.SuspendLayout();
            this.Panel_HeaderGroupFunction.SuspendLayout();
            this.Grbox_GroupBy.SuspendLayout();
            this.TablePanel_HeaderColListAlbum.SuspendLayout();
            this.FlowPanel_HeaderTBAlbum.SuspendLayout();
            this.FlowPanel_TableAlbum.SuspendLayout();
            this.Panel_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPanel_ListInfoAlbum
            // 
            this.FlowPanel_ListInfoAlbum.AutoScroll = true;
            this.FlowPanel_ListInfoAlbum.Location = new System.Drawing.Point(3, 77);
            this.FlowPanel_ListInfoAlbum.Name = "FlowPanel_ListInfoAlbum";
            this.FlowPanel_ListInfoAlbum.Size = new System.Drawing.Size(382, 377);
            this.FlowPanel_ListInfoAlbum.TabIndex = 3;
            // 
            // Lb_NameInfoAlbum
            // 
            this.Lb_NameInfoAlbum.BackColor = System.Drawing.Color.White;
            this.Lb_NameInfoAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_NameInfoAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NameInfoAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_NameInfoAlbum.Location = new System.Drawing.Point(3, 0);
            this.Lb_NameInfoAlbum.Name = "Lb_NameInfoAlbum";
            this.Lb_NameInfoAlbum.Size = new System.Drawing.Size(205, 36);
            this.Lb_NameInfoAlbum.TabIndex = 1;
            this.Lb_NameInfoAlbum.Text = "Name";
            this.Lb_NameInfoAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_HeaderAlbumInfo
            // 
            this.Lb_HeaderAlbumInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_HeaderAlbumInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_HeaderAlbumInfo.ForeColor = System.Drawing.Color.White;
            this.Lb_HeaderAlbumInfo.Location = new System.Drawing.Point(3, 0);
            this.Lb_HeaderAlbumInfo.Name = "Lb_HeaderAlbumInfo";
            this.Lb_HeaderAlbumInfo.Size = new System.Drawing.Size(379, 26);
            this.Lb_HeaderAlbumInfo.TabIndex = 0;
            this.Lb_HeaderAlbumInfo.Text = "Album info";
            this.Lb_HeaderAlbumInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablePanel_HeaderColInfoAlbum
            // 
            this.TablePanel_HeaderColInfoAlbum.ColumnCount = 3;
            this.TablePanel_HeaderColInfoAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TablePanel_HeaderColInfoAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TablePanel_HeaderColInfoAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanel_HeaderColInfoAlbum.Controls.Add(this.Lb_NameInfoAlbum, 0, 0);
            this.TablePanel_HeaderColInfoAlbum.Controls.Add(this.Lb_TimeInfoAlbum, 1, 0);
            this.TablePanel_HeaderColInfoAlbum.Location = new System.Drawing.Point(3, 29);
            this.TablePanel_HeaderColInfoAlbum.Name = "TablePanel_HeaderColInfoAlbum";
            this.TablePanel_HeaderColInfoAlbum.RowCount = 1;
            this.TablePanel_HeaderColInfoAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_HeaderColInfoAlbum.Size = new System.Drawing.Size(352, 36);
            this.TablePanel_HeaderColInfoAlbum.TabIndex = 1;
            // 
            // Lb_TimeInfoAlbum
            // 
            this.Lb_TimeInfoAlbum.BackColor = System.Drawing.Color.White;
            this.Lb_TimeInfoAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_TimeInfoAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TimeInfoAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_TimeInfoAlbum.Location = new System.Drawing.Point(214, 0);
            this.Lb_TimeInfoAlbum.Name = "Lb_TimeInfoAlbum";
            this.Lb_TimeInfoAlbum.Size = new System.Drawing.Size(99, 36);
            this.Lb_TimeInfoAlbum.TabIndex = 2;
            this.Lb_TimeInfoAlbum.Text = "Time";
            this.Lb_TimeInfoAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPanel_HeaderInfoAlbum
            // 
            this.FlowPanel_HeaderInfoAlbum.Controls.Add(this.Lb_HeaderAlbumInfo);
            this.FlowPanel_HeaderInfoAlbum.Controls.Add(this.TablePanel_HeaderColInfoAlbum);
            this.FlowPanel_HeaderInfoAlbum.Location = new System.Drawing.Point(3, 3);
            this.FlowPanel_HeaderInfoAlbum.Name = "FlowPanel_HeaderInfoAlbum";
            this.FlowPanel_HeaderInfoAlbum.Size = new System.Drawing.Size(382, 68);
            this.FlowPanel_HeaderInfoAlbum.TabIndex = 2;
            // 
            // FlowPanel_Left
            // 
            this.FlowPanel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.FlowPanel_Left.Controls.Add(this.FlowPanel_HeaderInfoAlbum);
            this.FlowPanel_Left.Controls.Add(this.FlowPanel_ListInfoAlbum);
            this.FlowPanel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_Left.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel_Left.Name = "FlowPanel_Left";
            this.FlowPanel_Left.Size = new System.Drawing.Size(388, 455);
            this.FlowPanel_Left.TabIndex = 3;
            // 
            // PanelWarp_TboxNameSreach
            // 
            this.PanelWarp_TboxNameSreach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxNameSreach.Controls.Add(this.Tbox_NameSearch);
            this.PanelWarp_TboxNameSreach.Location = new System.Drawing.Point(51, 22);
            this.PanelWarp_TboxNameSreach.Name = "PanelWarp_TboxNameSreach";
            this.PanelWarp_TboxNameSreach.Size = new System.Drawing.Size(151, 20);
            this.PanelWarp_TboxNameSreach.TabIndex = 0;
            // 
            // Tbox_NameSearch
            // 
            this.Tbox_NameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_NameSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_NameSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_NameSearch.Location = new System.Drawing.Point(4, 2);
            this.Tbox_NameSearch.Name = "Tbox_NameSearch";
            this.Tbox_NameSearch.Size = new System.Drawing.Size(143, 18);
            this.Tbox_NameSearch.TabIndex = 0;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(127, 54);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Lb_NameSearch
            // 
            this.Lb_NameSearch.AutoSize = true;
            this.Lb_NameSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NameSearch.Location = new System.Drawing.Point(6, 24);
            this.Lb_NameSearch.Name = "Lb_NameSearch";
            this.Lb_NameSearch.Size = new System.Drawing.Size(39, 15);
            this.Lb_NameSearch.TabIndex = 4;
            this.Lb_NameSearch.Text = "Name";
            // 
            // Grbox_Search
            // 
            this.Grbox_Search.Controls.Add(this.PanelWarp_TboxNameSreach);
            this.Grbox_Search.Controls.Add(this.Btn_Search);
            this.Grbox_Search.Controls.Add(this.Lb_NameSearch);
            this.Grbox_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_Search.Location = new System.Drawing.Point(6, 3);
            this.Grbox_Search.Name = "Grbox_Search";
            this.Grbox_Search.Size = new System.Drawing.Size(208, 83);
            this.Grbox_Search.TabIndex = 0;
            this.Grbox_Search.TabStop = false;
            this.Grbox_Search.Text = "Search playlist";
            // 
            // Panel_HeaderGroupFunction
            // 
            this.Panel_HeaderGroupFunction.Controls.Add(this.Grbox_Search);
            this.Panel_HeaderGroupFunction.Controls.Add(this.Grbox_GroupBy);
            this.Panel_HeaderGroupFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_HeaderGroupFunction.Location = new System.Drawing.Point(0, 0);
            this.Panel_HeaderGroupFunction.Name = "Panel_HeaderGroupFunction";
            this.Panel_HeaderGroupFunction.Size = new System.Drawing.Size(448, 89);
            this.Panel_HeaderGroupFunction.TabIndex = 4;
            // 
            // Grbox_GroupBy
            // 
            this.Grbox_GroupBy.Controls.Add(this.Lb_OrderBy);
            this.Grbox_GroupBy.Controls.Add(this.Cbox_Order);
            this.Grbox_GroupBy.Controls.Add(this.Lb_Artist);
            this.Grbox_GroupBy.Controls.Add(this.Cbox_Artist);
            this.Grbox_GroupBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_GroupBy.Location = new System.Drawing.Point(230, 3);
            this.Grbox_GroupBy.Name = "Grbox_GroupBy";
            this.Grbox_GroupBy.Size = new System.Drawing.Size(209, 83);
            this.Grbox_GroupBy.TabIndex = 1;
            this.Grbox_GroupBy.TabStop = false;
            this.Grbox_GroupBy.Text = "Group by";
            // 
            // Lb_OrderBy
            // 
            this.Lb_OrderBy.AutoSize = true;
            this.Lb_OrderBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_OrderBy.Location = new System.Drawing.Point(6, 55);
            this.Lb_OrderBy.Name = "Lb_OrderBy";
            this.Lb_OrderBy.Size = new System.Drawing.Size(61, 17);
            this.Lb_OrderBy.TabIndex = 9;
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
            "Artist"});
            this.Cbox_Order.Location = new System.Drawing.Point(81, 51);
            this.Cbox_Order.Name = "Cbox_Order";
            this.Cbox_Order.Size = new System.Drawing.Size(121, 25);
            this.Cbox_Order.TabIndex = 8;
            this.Cbox_Order.SelectedIndexChanged += new System.EventHandler(this.Cbox_Order_SelectedIndexChanged);
            this.Cbox_Order.DropDownClosed += new System.EventHandler(this.Cbox_DropDownClosed);
            // 
            // Lb_Artist
            // 
            this.Lb_Artist.AutoSize = true;
            this.Lb_Artist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Artist.Location = new System.Drawing.Point(6, 23);
            this.Lb_Artist.Name = "Lb_Artist";
            this.Lb_Artist.Size = new System.Drawing.Size(38, 17);
            this.Lb_Artist.TabIndex = 6;
            this.Lb_Artist.Text = "Artist";
            // 
            // Cbox_Artist
            // 
            this.Cbox_Artist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Cbox_Artist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Artist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbox_Artist.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Artist.ForeColor = System.Drawing.Color.White;
            this.Cbox_Artist.FormattingEnabled = true;
            this.Cbox_Artist.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Cbox_Artist.Location = new System.Drawing.Point(81, 20);
            this.Cbox_Artist.Name = "Cbox_Artist";
            this.Cbox_Artist.Size = new System.Drawing.Size(121, 25);
            this.Cbox_Artist.TabIndex = 5;
            this.Cbox_Artist.SelectedIndexChanged += new System.EventHandler(this.Cbox_Artist_SelectedIndexChanged);
            this.Cbox_Artist.DropDownClosed += new System.EventHandler(this.Cbox_DropDownClosed);
            // 
            // Lb_ColNameListAlbum
            // 
            this.Lb_ColNameListAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColNameListAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColNameListAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColNameListAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColNameListAlbum.Location = new System.Drawing.Point(3, 0);
            this.Lb_ColNameListAlbum.Name = "Lb_ColNameListAlbum";
            this.Lb_ColNameListAlbum.Size = new System.Drawing.Size(221, 36);
            this.Lb_ColNameListAlbum.TabIndex = 5;
            this.Lb_ColNameListAlbum.Text = "Name";
            this.Lb_ColNameListAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_HeaderListAlbum
            // 
            this.Lb_HeaderListAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_HeaderListAlbum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_HeaderListAlbum.ForeColor = System.Drawing.Color.White;
            this.Lb_HeaderListAlbum.Location = new System.Drawing.Point(3, 0);
            this.Lb_HeaderListAlbum.Name = "Lb_HeaderListAlbum";
            this.Lb_HeaderListAlbum.Size = new System.Drawing.Size(433, 26);
            this.Lb_HeaderListAlbum.TabIndex = 4;
            this.Lb_HeaderListAlbum.Text = "Albums list ";
            this.Lb_HeaderListAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablePanel_HeaderColListAlbum
            // 
            this.TablePanel_HeaderColListAlbum.ColumnCount = 3;
            this.TablePanel_HeaderColListAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.TablePanel_HeaderColListAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.TablePanel_HeaderColListAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TablePanel_HeaderColListAlbum.Controls.Add(this.Lb_ColArtist, 0, 0);
            this.TablePanel_HeaderColListAlbum.Controls.Add(this.Lb_ColNameListAlbum, 0, 0);
            this.TablePanel_HeaderColListAlbum.Controls.Add(this.Btn_Reload, 2, 0);
            this.TablePanel_HeaderColListAlbum.Location = new System.Drawing.Point(3, 29);
            this.TablePanel_HeaderColListAlbum.Name = "TablePanel_HeaderColListAlbum";
            this.TablePanel_HeaderColListAlbum.RowCount = 1;
            this.TablePanel_HeaderColListAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_HeaderColListAlbum.Size = new System.Drawing.Size(414, 36);
            this.TablePanel_HeaderColListAlbum.TabIndex = 6;
            // 
            // Lb_ColArtist
            // 
            this.Lb_ColArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColArtist.Location = new System.Drawing.Point(230, 0);
            this.Lb_ColArtist.Name = "Lb_ColArtist";
            this.Lb_ColArtist.Size = new System.Drawing.Size(143, 36);
            this.Lb_ColArtist.TabIndex = 6;
            this.Lb_ColArtist.Text = "Artist";
            this.Lb_ColArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Reload
            // 
            this.Btn_Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Reload.BackgroundImage = global::MusicApp.Properties.Resources.reload;
            this.Btn_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Reload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Reload.FlatAppearance.BorderSize = 0;
            this.Btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reload.ForeColor = System.Drawing.Color.White;
            this.Btn_Reload.Location = new System.Drawing.Point(379, 3);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(32, 30);
            this.Btn_Reload.TabIndex = 5;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.Btn_Reload_Click);
            // 
            // FlowPanel_HeaderTBAlbum
            // 
            this.FlowPanel_HeaderTBAlbum.Controls.Add(this.Lb_HeaderListAlbum);
            this.FlowPanel_HeaderTBAlbum.Controls.Add(this.TablePanel_HeaderColListAlbum);
            this.FlowPanel_HeaderTBAlbum.Location = new System.Drawing.Point(3, 3);
            this.FlowPanel_HeaderTBAlbum.Name = "FlowPanel_HeaderTBAlbum";
            this.FlowPanel_HeaderTBAlbum.Size = new System.Drawing.Size(442, 68);
            this.FlowPanel_HeaderTBAlbum.TabIndex = 4;
            // 
            // FlowPanel_TableAlbum
            // 
            this.FlowPanel_TableAlbum.Controls.Add(this.FlowPanel_HeaderTBAlbum);
            this.FlowPanel_TableAlbum.Controls.Add(this.FlowPanel_ListAlbum);
            this.FlowPanel_TableAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_TableAlbum.Location = new System.Drawing.Point(0, 89);
            this.FlowPanel_TableAlbum.Name = "FlowPanel_TableAlbum";
            this.FlowPanel_TableAlbum.Size = new System.Drawing.Size(448, 366);
            this.FlowPanel_TableAlbum.TabIndex = 2;
            // 
            // FlowPanel_ListAlbum
            // 
            this.FlowPanel_ListAlbum.Location = new System.Drawing.Point(3, 77);
            this.FlowPanel_ListAlbum.Name = "FlowPanel_ListAlbum";
            this.FlowPanel_ListAlbum.Size = new System.Drawing.Size(442, 286);
            this.FlowPanel_ListAlbum.TabIndex = 3;
            // 
            // Panel_Right
            // 
            this.Panel_Right.Controls.Add(this.FlowPanel_TableAlbum);
            this.Panel_Right.Controls.Add(this.Panel_HeaderGroupFunction);
            this.Panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Right.Location = new System.Drawing.Point(388, 0);
            this.Panel_Right.Name = "Panel_Right";
            this.Panel_Right.Size = new System.Drawing.Size(448, 455);
            this.Panel_Right.TabIndex = 2;
            // 
            // Timer_CheckPlayingAlbum
            // 
            this.Timer_CheckPlayingAlbum.Enabled = true;
            this.Timer_CheckPlayingAlbum.Interval = 1000;
            this.Timer_CheckPlayingAlbum.Tick += new System.EventHandler(this.Timer_CheckPlayingAlbum_Tick);
            // 
            // SongAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FlowPanel_Left);
            this.Controls.Add(this.Panel_Right);
            this.Name = "SongAlbum";
            this.Size = new System.Drawing.Size(836, 455);
            this.TablePanel_HeaderColInfoAlbum.ResumeLayout(false);
            this.FlowPanel_HeaderInfoAlbum.ResumeLayout(false);
            this.FlowPanel_Left.ResumeLayout(false);
            this.PanelWarp_TboxNameSreach.ResumeLayout(false);
            this.PanelWarp_TboxNameSreach.PerformLayout();
            this.Grbox_Search.ResumeLayout(false);
            this.Grbox_Search.PerformLayout();
            this.Panel_HeaderGroupFunction.ResumeLayout(false);
            this.Grbox_GroupBy.ResumeLayout(false);
            this.Grbox_GroupBy.PerformLayout();
            this.TablePanel_HeaderColListAlbum.ResumeLayout(false);
            this.FlowPanel_HeaderTBAlbum.ResumeLayout(false);
            this.FlowPanel_TableAlbum.ResumeLayout(false);
            this.Panel_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanel_ListInfoAlbum;
        private System.Windows.Forms.Label Lb_NameInfoAlbum;
        private System.Windows.Forms.Label Lb_HeaderAlbumInfo;
        private System.Windows.Forms.TableLayoutPanel TablePanel_HeaderColInfoAlbum;
        private System.Windows.Forms.Label Lb_TimeInfoAlbum;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_HeaderInfoAlbum;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Left;
        private System.Windows.Forms.Panel PanelWarp_TboxNameSreach;
        private System.Windows.Forms.TextBox Tbox_NameSearch;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lb_NameSearch;
        private System.Windows.Forms.GroupBox Grbox_Search;
        private System.Windows.Forms.Panel Panel_HeaderGroupFunction;
        private System.Windows.Forms.GroupBox Grbox_GroupBy;
        private System.Windows.Forms.Label Lb_ColNameListAlbum;
        private System.Windows.Forms.Button Btn_Reload;
        private System.Windows.Forms.Label Lb_HeaderListAlbum;
        private System.Windows.Forms.TableLayoutPanel TablePanel_HeaderColListAlbum;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_HeaderTBAlbum;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_TableAlbum;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_ListAlbum;
        private System.Windows.Forms.Panel Panel_Right;
        private System.Windows.Forms.Label Lb_Artist;
        private System.Windows.Forms.ComboBox Cbox_Artist;
        private System.Windows.Forms.Label Lb_OrderBy;
        private System.Windows.Forms.ComboBox Cbox_Order;
        private System.Windows.Forms.Label Lb_ColArtist;
        private System.Windows.Forms.Timer Timer_CheckPlayingAlbum;
    }
}
