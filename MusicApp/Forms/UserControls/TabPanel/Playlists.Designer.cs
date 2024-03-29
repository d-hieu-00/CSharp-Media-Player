﻿
namespace MusicApp.Forms.UserControls.TabPanel
{
    partial class Playlists
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
            this.Panel_Right = new System.Windows.Forms.Panel();
            this.FlowPanel_TablePLaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowPanel_HeaderTBPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.Lb_HeaderListPlaylist = new System.Windows.Forms.Label();
            this.TablePanel_HeaderColListPlaylist = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_ColNameListPlaylist = new System.Windows.Forms.Label();
            this.Btn_Reload = new System.Windows.Forms.Button();
            this.FlowPanel_ListPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_HeaderGroupFunction = new System.Windows.Forms.Panel();
            this.Grbox_Search = new System.Windows.Forms.GroupBox();
            this.PanelWarp_TboxNameSreach = new System.Windows.Forms.Panel();
            this.Tbox_NameSearch = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Lb_NameSearch = new System.Windows.Forms.Label();
            this.Grbox_Create = new System.Windows.Forms.GroupBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.PanelWarp_TboxNameCreate = new System.Windows.Forms.Panel();
            this.Tbox_NameCreate = new System.Windows.Forms.TextBox();
            this.Lb_NameCreate = new System.Windows.Forms.Label();
            this.FlowPanel_Left = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowPanel_HeaderInfoPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.Lb_HeaderPlaylistInfo = new System.Windows.Forms.Label();
            this.TablePanel_HeaderColInfoPlaylist = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_NameInfoPlaylist = new System.Windows.Forms.Label();
            this.Lb_TimeInfoPlaylist = new System.Windows.Forms.Label();
            this.FlowPanel_ListInfoPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.Timer_CheckPlayingPlaylist = new System.Windows.Forms.Timer(this.components);
            this.Panel_Right.SuspendLayout();
            this.FlowPanel_TablePLaylist.SuspendLayout();
            this.FlowPanel_HeaderTBPlaylist.SuspendLayout();
            this.TablePanel_HeaderColListPlaylist.SuspendLayout();
            this.Panel_HeaderGroupFunction.SuspendLayout();
            this.Grbox_Search.SuspendLayout();
            this.PanelWarp_TboxNameSreach.SuspendLayout();
            this.Grbox_Create.SuspendLayout();
            this.PanelWarp_TboxNameCreate.SuspendLayout();
            this.FlowPanel_Left.SuspendLayout();
            this.FlowPanel_HeaderInfoPlaylist.SuspendLayout();
            this.TablePanel_HeaderColInfoPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Right
            // 
            this.Panel_Right.Controls.Add(this.FlowPanel_TablePLaylist);
            this.Panel_Right.Controls.Add(this.Panel_HeaderGroupFunction);
            this.Panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Right.Location = new System.Drawing.Point(388, 0);
            this.Panel_Right.Name = "Panel_Right";
            this.Panel_Right.Size = new System.Drawing.Size(448, 455);
            this.Panel_Right.TabIndex = 0;
            // 
            // FlowPanel_TablePLaylist
            // 
            this.FlowPanel_TablePLaylist.Controls.Add(this.FlowPanel_HeaderTBPlaylist);
            this.FlowPanel_TablePLaylist.Controls.Add(this.FlowPanel_ListPlaylist);
            this.FlowPanel_TablePLaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_TablePLaylist.Location = new System.Drawing.Point(0, 89);
            this.FlowPanel_TablePLaylist.Name = "FlowPanel_TablePLaylist";
            this.FlowPanel_TablePLaylist.Size = new System.Drawing.Size(448, 366);
            this.FlowPanel_TablePLaylist.TabIndex = 2;
            // 
            // FlowPanel_HeaderTBPlaylist
            // 
            this.FlowPanel_HeaderTBPlaylist.Controls.Add(this.Lb_HeaderListPlaylist);
            this.FlowPanel_HeaderTBPlaylist.Controls.Add(this.TablePanel_HeaderColListPlaylist);
            this.FlowPanel_HeaderTBPlaylist.Location = new System.Drawing.Point(3, 3);
            this.FlowPanel_HeaderTBPlaylist.Name = "FlowPanel_HeaderTBPlaylist";
            this.FlowPanel_HeaderTBPlaylist.Size = new System.Drawing.Size(442, 68);
            this.FlowPanel_HeaderTBPlaylist.TabIndex = 4;
            // 
            // Lb_HeaderListPlaylist
            // 
            this.Lb_HeaderListPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_HeaderListPlaylist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_HeaderListPlaylist.ForeColor = System.Drawing.Color.White;
            this.Lb_HeaderListPlaylist.Location = new System.Drawing.Point(3, 0);
            this.Lb_HeaderListPlaylist.Name = "Lb_HeaderListPlaylist";
            this.Lb_HeaderListPlaylist.Size = new System.Drawing.Size(433, 26);
            this.Lb_HeaderListPlaylist.TabIndex = 4;
            this.Lb_HeaderListPlaylist.Text = "Playlists list ";
            this.Lb_HeaderListPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablePanel_HeaderColListPlaylist
            // 
            this.TablePanel_HeaderColListPlaylist.ColumnCount = 2;
            this.TablePanel_HeaderColListPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.TablePanel_HeaderColListPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.TablePanel_HeaderColListPlaylist.Controls.Add(this.Lb_ColNameListPlaylist, 0, 0);
            this.TablePanel_HeaderColListPlaylist.Controls.Add(this.Btn_Reload, 1, 0);
            this.TablePanel_HeaderColListPlaylist.Location = new System.Drawing.Point(3, 29);
            this.TablePanel_HeaderColListPlaylist.Name = "TablePanel_HeaderColListPlaylist";
            this.TablePanel_HeaderColListPlaylist.RowCount = 1;
            this.TablePanel_HeaderColListPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_HeaderColListPlaylist.Size = new System.Drawing.Size(414, 36);
            this.TablePanel_HeaderColListPlaylist.TabIndex = 6;
            // 
            // Lb_ColNameListPlaylist
            // 
            this.Lb_ColNameListPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Lb_ColNameListPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ColNameListPlaylist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ColNameListPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_ColNameListPlaylist.Location = new System.Drawing.Point(3, 0);
            this.Lb_ColNameListPlaylist.Name = "Lb_ColNameListPlaylist";
            this.Lb_ColNameListPlaylist.Size = new System.Drawing.Size(296, 36);
            this.Lb_ColNameListPlaylist.TabIndex = 5;
            this.Lb_ColNameListPlaylist.Text = "Name";
            this.Lb_ColNameListPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Btn_Reload.Location = new System.Drawing.Point(305, 3);
            this.Btn_Reload.Name = "Btn_Reload";
            this.Btn_Reload.Size = new System.Drawing.Size(106, 30);
            this.Btn_Reload.TabIndex = 5;
            this.Btn_Reload.UseVisualStyleBackColor = false;
            this.Btn_Reload.Click += new System.EventHandler(this.Btn_Reload_Click);
            // 
            // FlowPanel_ListPlaylist
            // 
            this.FlowPanel_ListPlaylist.Location = new System.Drawing.Point(3, 77);
            this.FlowPanel_ListPlaylist.Name = "FlowPanel_ListPlaylist";
            this.FlowPanel_ListPlaylist.Size = new System.Drawing.Size(442, 286);
            this.FlowPanel_ListPlaylist.TabIndex = 3;
            // 
            // Panel_HeaderGroupFunction
            // 
            this.Panel_HeaderGroupFunction.Controls.Add(this.Grbox_Search);
            this.Panel_HeaderGroupFunction.Controls.Add(this.Grbox_Create);
            this.Panel_HeaderGroupFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_HeaderGroupFunction.Location = new System.Drawing.Point(0, 0);
            this.Panel_HeaderGroupFunction.Name = "Panel_HeaderGroupFunction";
            this.Panel_HeaderGroupFunction.Size = new System.Drawing.Size(448, 89);
            this.Panel_HeaderGroupFunction.TabIndex = 4;
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
            this.Lb_NameSearch.Location = new System.Drawing.Point(6, 22);
            this.Lb_NameSearch.Name = "Lb_NameSearch";
            this.Lb_NameSearch.Size = new System.Drawing.Size(39, 15);
            this.Lb_NameSearch.TabIndex = 4;
            this.Lb_NameSearch.Text = "Name";
            // 
            // Grbox_Create
            // 
            this.Grbox_Create.Controls.Add(this.Btn_Create);
            this.Grbox_Create.Controls.Add(this.PanelWarp_TboxNameCreate);
            this.Grbox_Create.Controls.Add(this.Lb_NameCreate);
            this.Grbox_Create.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grbox_Create.Location = new System.Drawing.Point(230, 3);
            this.Grbox_Create.Name = "Grbox_Create";
            this.Grbox_Create.Size = new System.Drawing.Size(209, 83);
            this.Grbox_Create.TabIndex = 1;
            this.Grbox_Create.TabStop = false;
            this.Grbox_Create.Text = "Create new playlist";
            // 
            // Btn_Create
            // 
            this.Btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Btn_Create.FlatAppearance.BorderSize = 0;
            this.Btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create.ForeColor = System.Drawing.Color.White;
            this.Btn_Create.Location = new System.Drawing.Point(127, 54);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(75, 23);
            this.Btn_Create.TabIndex = 6;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = false;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // PanelWarp_TboxNameCreate
            // 
            this.PanelWarp_TboxNameCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelWarp_TboxNameCreate.Controls.Add(this.Tbox_NameCreate);
            this.PanelWarp_TboxNameCreate.Location = new System.Drawing.Point(51, 22);
            this.PanelWarp_TboxNameCreate.Name = "PanelWarp_TboxNameCreate";
            this.PanelWarp_TboxNameCreate.Size = new System.Drawing.Size(151, 20);
            this.PanelWarp_TboxNameCreate.TabIndex = 2;
            // 
            // Tbox_NameCreate
            // 
            this.Tbox_NameCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Tbox_NameCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbox_NameCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbox_NameCreate.Location = new System.Drawing.Point(4, 2);
            this.Tbox_NameCreate.Name = "Tbox_NameCreate";
            this.Tbox_NameCreate.Size = new System.Drawing.Size(143, 18);
            this.Tbox_NameCreate.TabIndex = 0;
            // 
            // Lb_NameCreate
            // 
            this.Lb_NameCreate.AutoSize = true;
            this.Lb_NameCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NameCreate.Location = new System.Drawing.Point(6, 22);
            this.Lb_NameCreate.Name = "Lb_NameCreate";
            this.Lb_NameCreate.Size = new System.Drawing.Size(39, 15);
            this.Lb_NameCreate.TabIndex = 3;
            this.Lb_NameCreate.Text = "Name";
            // 
            // FlowPanel_Left
            // 
            this.FlowPanel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.FlowPanel_Left.Controls.Add(this.FlowPanel_HeaderInfoPlaylist);
            this.FlowPanel_Left.Controls.Add(this.FlowPanel_ListInfoPlaylist);
            this.FlowPanel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_Left.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel_Left.Name = "FlowPanel_Left";
            this.FlowPanel_Left.Size = new System.Drawing.Size(388, 455);
            this.FlowPanel_Left.TabIndex = 1;
            // 
            // FlowPanel_HeaderInfoPlaylist
            // 
            this.FlowPanel_HeaderInfoPlaylist.Controls.Add(this.Lb_HeaderPlaylistInfo);
            this.FlowPanel_HeaderInfoPlaylist.Controls.Add(this.TablePanel_HeaderColInfoPlaylist);
            this.FlowPanel_HeaderInfoPlaylist.Location = new System.Drawing.Point(3, 3);
            this.FlowPanel_HeaderInfoPlaylist.Name = "FlowPanel_HeaderInfoPlaylist";
            this.FlowPanel_HeaderInfoPlaylist.Size = new System.Drawing.Size(382, 68);
            this.FlowPanel_HeaderInfoPlaylist.TabIndex = 2;
            // 
            // Lb_HeaderPlaylistInfo
            // 
            this.Lb_HeaderPlaylistInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_HeaderPlaylistInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_HeaderPlaylistInfo.ForeColor = System.Drawing.Color.White;
            this.Lb_HeaderPlaylistInfo.Location = new System.Drawing.Point(3, 0);
            this.Lb_HeaderPlaylistInfo.Name = "Lb_HeaderPlaylistInfo";
            this.Lb_HeaderPlaylistInfo.Size = new System.Drawing.Size(379, 26);
            this.Lb_HeaderPlaylistInfo.TabIndex = 0;
            this.Lb_HeaderPlaylistInfo.Text = "Playlist info";
            this.Lb_HeaderPlaylistInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablePanel_HeaderColInfoPlaylist
            // 
            this.TablePanel_HeaderColInfoPlaylist.ColumnCount = 3;
            this.TablePanel_HeaderColInfoPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TablePanel_HeaderColInfoPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TablePanel_HeaderColInfoPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TablePanel_HeaderColInfoPlaylist.Controls.Add(this.Lb_NameInfoPlaylist, 0, 0);
            this.TablePanel_HeaderColInfoPlaylist.Controls.Add(this.Lb_TimeInfoPlaylist, 1, 0);
            this.TablePanel_HeaderColInfoPlaylist.Location = new System.Drawing.Point(3, 29);
            this.TablePanel_HeaderColInfoPlaylist.Name = "TablePanel_HeaderColInfoPlaylist";
            this.TablePanel_HeaderColInfoPlaylist.RowCount = 1;
            this.TablePanel_HeaderColInfoPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanel_HeaderColInfoPlaylist.Size = new System.Drawing.Size(352, 36);
            this.TablePanel_HeaderColInfoPlaylist.TabIndex = 1;
            // 
            // Lb_NameInfoPlaylist
            // 
            this.Lb_NameInfoPlaylist.BackColor = System.Drawing.Color.White;
            this.Lb_NameInfoPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_NameInfoPlaylist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NameInfoPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_NameInfoPlaylist.Location = new System.Drawing.Point(3, 0);
            this.Lb_NameInfoPlaylist.Name = "Lb_NameInfoPlaylist";
            this.Lb_NameInfoPlaylist.Size = new System.Drawing.Size(205, 36);
            this.Lb_NameInfoPlaylist.TabIndex = 1;
            this.Lb_NameInfoPlaylist.Text = "Name";
            this.Lb_NameInfoPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_TimeInfoPlaylist
            // 
            this.Lb_TimeInfoPlaylist.BackColor = System.Drawing.Color.White;
            this.Lb_TimeInfoPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_TimeInfoPlaylist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TimeInfoPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.Lb_TimeInfoPlaylist.Location = new System.Drawing.Point(214, 0);
            this.Lb_TimeInfoPlaylist.Name = "Lb_TimeInfoPlaylist";
            this.Lb_TimeInfoPlaylist.Size = new System.Drawing.Size(99, 36);
            this.Lb_TimeInfoPlaylist.TabIndex = 2;
            this.Lb_TimeInfoPlaylist.Text = "Time";
            this.Lb_TimeInfoPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowPanel_ListInfoPlaylist
            // 
            this.FlowPanel_ListInfoPlaylist.AutoScroll = true;
            this.FlowPanel_ListInfoPlaylist.Location = new System.Drawing.Point(3, 77);
            this.FlowPanel_ListInfoPlaylist.Name = "FlowPanel_ListInfoPlaylist";
            this.FlowPanel_ListInfoPlaylist.Size = new System.Drawing.Size(382, 377);
            this.FlowPanel_ListInfoPlaylist.TabIndex = 3;
            // 
            // Timer_CheckPlayingPlaylist
            // 
            this.Timer_CheckPlayingPlaylist.Enabled = true;
            this.Timer_CheckPlayingPlaylist.Interval = 1000;
            this.Timer_CheckPlayingPlaylist.Tick += new System.EventHandler(this.Timer_CheckPlayingPlaylist_Tick);
            // 
            // Playlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FlowPanel_Left);
            this.Controls.Add(this.Panel_Right);
            this.Name = "Playlists";
            this.Size = new System.Drawing.Size(836, 455);
            this.Panel_Right.ResumeLayout(false);
            this.FlowPanel_TablePLaylist.ResumeLayout(false);
            this.FlowPanel_HeaderTBPlaylist.ResumeLayout(false);
            this.TablePanel_HeaderColListPlaylist.ResumeLayout(false);
            this.Panel_HeaderGroupFunction.ResumeLayout(false);
            this.Grbox_Search.ResumeLayout(false);
            this.Grbox_Search.PerformLayout();
            this.PanelWarp_TboxNameSreach.ResumeLayout(false);
            this.PanelWarp_TboxNameSreach.PerformLayout();
            this.Grbox_Create.ResumeLayout(false);
            this.Grbox_Create.PerformLayout();
            this.PanelWarp_TboxNameCreate.ResumeLayout(false);
            this.PanelWarp_TboxNameCreate.PerformLayout();
            this.FlowPanel_Left.ResumeLayout(false);
            this.FlowPanel_HeaderInfoPlaylist.ResumeLayout(false);
            this.TablePanel_HeaderColInfoPlaylist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Right;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_TablePLaylist;
        private System.Windows.Forms.Label Lb_HeaderListPlaylist;
        private System.Windows.Forms.TableLayoutPanel TablePanel_HeaderColListPlaylist;
        private System.Windows.Forms.Label Lb_ColNameListPlaylist;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_ListPlaylist;
        private System.Windows.Forms.Panel Panel_HeaderGroupFunction;
        private System.Windows.Forms.GroupBox Grbox_Search;
        private System.Windows.Forms.Label Lb_NameSearch;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Tbox_NameSearch;
        private System.Windows.Forms.GroupBox Grbox_Create;
        private System.Windows.Forms.Label Lb_NameCreate;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Left;
        private System.Windows.Forms.Label Lb_HeaderPlaylistInfo;
        private System.Windows.Forms.TableLayoutPanel TablePanel_HeaderColInfoPlaylist;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_HeaderTBPlaylist;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_HeaderInfoPlaylist;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_ListInfoPlaylist;
        private System.Windows.Forms.Label Lb_NameInfoPlaylist;
        private System.Windows.Forms.Label Lb_TimeInfoPlaylist;
        private System.Windows.Forms.Button Btn_Reload;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Panel PanelWarp_TboxNameSreach;
        private System.Windows.Forms.Panel PanelWarp_TboxNameCreate;
        private System.Windows.Forms.TextBox Tbox_NameCreate;
        private System.Windows.Forms.Timer Timer_CheckPlayingPlaylist;
    }
}
