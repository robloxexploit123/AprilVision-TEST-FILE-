﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilVision_ALPHA
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/DqmMZxy4UK");
        }

        private void Luanch_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaderUI LoaderUI = new LoaderUI();
            LoaderUI.Show();
        }
    }
}
