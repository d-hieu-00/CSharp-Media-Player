using MusicApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls.TableDir
{
    public partial class RowTableDir : UserControl
    {
        public RowTableDir()
        {
            InitializeComponent();
            MainForm.RoundedControl(Lb_Num, 3);
            MainForm.RoundedControl(Lb_Dir, 3);
            MainForm.RoundedControl(Btn_DelFolder, 3);
        }

        public void SetValue(int no, string dir, int ID)
        {
            Btn_DelFolder.Name = ID.ToString();
            Lb_Num.Text = no.ToString();
            Lb_Dir.Text = dir;
        }

        private void Btn_DelFolder_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            MyResources.Resources.RemoveFolderByID(Convert.ToInt32((sender as Control).Name));
            MyResources.Main.SetCursorDefault();
        }
    }
}
