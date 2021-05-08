﻿using System;
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
    public partial class Loading : UserControl
    {
        public Loading()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(15, 0, 0, 0);
            Picbox_LoadingGif.BackColor = Color.FromArgb(15,0, 0, 0);

            BackColor = Color.Transparent;
            Picbox_LoadingGif.BackColor = Color.Transparent;
        }
    }
}
