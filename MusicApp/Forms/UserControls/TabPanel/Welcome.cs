using MusicApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls.TabPanel
{
    public partial class Welcome : UserControl
    {

        private readonly FolderBrowserDialog openFolder = new FolderBrowserDialog();
        public Welcome()
        {
            InitializeComponent();

            MainForm.RoundedControl(Btn_AddFolder);
            MyResources.ConfigFolderBrowserDialog(openFolder);
        }
/*
        private Control CloneControl(Control srcCtl)
        {
            var cloned = Activator.CreateInstance(srcCtl.GetType()) as Control;
            var binding = BindingFlags.Public | BindingFlags.Instance;
            foreach (PropertyInfo prop in srcCtl.GetType().GetProperties(binding))
            {
                if (IsClonable(prop))
                {
                    object val = prop.GetValue(srcCtl);
                    prop.SetValue(cloned, val, null);
                }
            }

            foreach (Control ctl in srcCtl.Controls)
            {
                cloned.Controls.Add(CloneControl(ctl));
            }

            return cloned;
        }

        private bool IsClonable(PropertyInfo prop)
        {
            var browsableAttr = prop.GetCustomAttribute(typeof(BrowsableAttribute), true) as BrowsableAttribute;
            var editorBrowsableAttr = prop.GetCustomAttribute(typeof(EditorBrowsableAttribute), true) as EditorBrowsableAttribute;

            return prop.CanWrite
                && (browsableAttr == null || browsableAttr.Browsable == true)
                && (editorBrowsableAttr == null || editorBrowsableAttr.State != EditorBrowsableState.Advanced);
        }*/

        public void SetLocationAfterSartView()
        {
            Card_Left.Location = new Point(Card_Left.Location.X, Card_Left.Location.Y - 78);
            Card_Right.Location = new Point(Card_Right.Location.X, Card_Right.Location.Y - 78);
            Picbox_GifCat.Location = new Point(Picbox_GifCat.Location.X, Picbox_GifCat.Location.Y - 70);
            Picbox_LogoApp.Location = new Point(Picbox_LogoApp.Location.X, Picbox_LogoApp.Location.Y - 70);
            Lb_InfoActor.Location = new Point(Lb_InfoActor.Location.X, Lb_InfoActor.Location.Y - 70);


            Lb_AddFolder.Text = "SOURCE CODE";
            Btn_AddFolder.Text = "Open link";
            Btn_AddFolder.Click += Btn_OpenLink_Click;
            Btn_AddFolder.Click -= Btn_AddFolder_Click;
            Lb_Welcome.Hide();
            Lb_Welcome.Dispose();
        }

        #region Handle Add folders
        private void Btn_AddFolder_Click(object sender, EventArgs e)
        {
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                MyResources.Main.SetCursorLoading();
                MyResources.Resources.AddFolderFromPath(openFolder.SelectedPath);
                MyResources.Main.SetCursorDefault();
                MyResources.Main.SettingTab.LoadDataTable();
            }
        }
        private void Btn_OpenLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(MyResources.linkSource);
        }
        #endregion
    }
}
