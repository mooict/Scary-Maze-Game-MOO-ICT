﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scary_Maze_Game_MOO_ICT
{
    public partial class ScareWindow : Form
    {
        public ScareWindow()
        {
            InitializeComponent();
            LoadWindow();
        }

        private void CloseWindowEvent(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }
}
