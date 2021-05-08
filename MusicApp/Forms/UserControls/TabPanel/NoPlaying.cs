using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Forms.UserControls.TabPanel
{
    public partial class NoPlaying : UserControl
    {
        public NoPlaying()
        {
            InitializeComponent();
            MainForm.RoundedControl(Lb_Content, 3);
        }
    }
}
