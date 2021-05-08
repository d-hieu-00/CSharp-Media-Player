using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.Classes;

namespace MusicApp.Forms.UserControls.TablePlaylist
{
    public partial class EditPlaylist : Form
    {
        private bool dragging;
        private Point startPoint;
        public EditPlaylist()
        {
            InitializeComponent();
            MainForm.RoundedControl(Btn_Close);
            MainForm.RoundedControl(Btn_OK);
            MainForm.RoundedControl(this);
            Tbox_Name.Focus();
        }
        public void SetData(int ID, string Name)
        {
            Btn_OK.Name = ID.ToString();
            Lb_Header.Text += Name;
            Tbox_Name.Text = Name;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            MyResources.Resources.UpdateNamePlaylist(Convert.ToInt32(Btn_OK.Name), Tbox_Name.Text.Trim());
            MyResources.Main.PlaylistTab.UpdatePlaylistByID(Convert.ToInt32(Btn_OK.Name), Tbox_Name.Text.Trim());
            Close();
        }

        #region handle default form
        private void Lb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_Close_MouseEnter(object sender, EventArgs e)
        {
            Btn_Close.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void Lb_Close_MouseLeave(object sender, EventArgs e)
        {
            Btn_Close.BackColor = Color.FromArgb(5, 144, 142);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }

        #region handle FormDagging
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #endregion
    }
}
