using MusicApp.Classes;
using MusicApp.Forms.UserControls.TableDir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls
{
    public partial class Settings : UserControl
    {
        private readonly FolderBrowserDialog openFolder = new FolderBrowserDialog();
        public Settings()
        {
            InitializeComponent();
            MyResources.ConfigFolderBrowserDialog(openFolder);

            MainForm.RoundedControl(Btn_AddFolder);
            MainForm.RoundedControl(Btn_ReloadFolder);
            
            MainForm.RoundedControl(Lb_Num, 3);
            MainForm.RoundedControl(Lb_Dir, 3);
        }

        public void LoadDataTable()
        {
            FlowPanel_Data.Controls.Clear();
            for (int i=0; i<MyResources.Resources.ListFolders.Count; i++)
            {
                RowTableDir r = new RowTableDir();
                r.SetValue(i + 1, MyResources.Resources.ListFolders[i].Dir, MyResources.Resources.ListFolders[i].ID);
                FlowPanel_Data.Controls.Add(r);
            }
        }

        private void Btn_ReloadFolder_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            MyResources.Resources.ReloadFolder();
            MyResources.Main.SetCursorDefault();
            LoadDataTable();
        }

        private void Btn_AddFolder_Click(object sender, EventArgs e)
        {
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                MyResources.Main.SetCursorLoading();
                MyResources.Resources.AddFolderFromPath(openFolder.SelectedPath);
                MyResources.Main.SetCursorDefault();
                LoadDataTable();
            }
        }
    }
}
