﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class NewPlaylistDialog : Form
    {
        public string? newPlaylistName { get; set; }
        public NewPlaylistDialog()
        {
            InitializeComponent();
            NewPlaylistTextbox.Select();
        }

        private void OKPlaylistButton_Click(object sender, EventArgs e)
        {
            newPlaylistName = NewPlaylistTextbox.Text;
        }
    }
}
