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
    public partial class RowInfoPlaylist : UserControl
    {
        public RowInfoPlaylist()
        {
            InitializeComponent();
            MainForm.RoundedControl(Lb_Name, 3);
            MainForm.RoundedControl(Lb_Time, 3);
            MainForm.RoundedControl(Btn_Del);
        }

        public void SetData(Dictionary<string,string> item)
        {
            Lb_Name.Text = item["type"] + ": " + item["name"];
            Lb_Time.Text = item["duration"];
            Btn_Del.Tag = item;
            Tag = item;
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            MyResources.Main.SetCursorLoading();
            var tag = Tag as Dictionary<string, string>;
            MyResources.Resources.DeleteItemInPlaylistID(
                Convert.ToInt32(tag["id"]), 
                Convert.ToInt32(tag["id_playlist"]), 
                tag["type"]);
            Name = "del";
            MyResources.Main.PlaylistTab.RemoveItemInfo();
            Lb_Name.Focus();
            MyResources.Main.SetCursorDefault();
        }
    }
}
