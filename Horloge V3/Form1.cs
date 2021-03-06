﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horloge_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDateHeure.Text = DateTime.Now.ToString();
            timer1.Enabled = true;
        }

        private void AfficherDateHeure()
        {
            if (rdbtDate.Checked)
               lblDateHeure.Text = DateTime.Now.ToShortDateString();
            else if (rdbtHeure.Checked)
                lblDateHeure.Text = DateTime.Now.ToLongTimeString();
            else
                lblDateHeure.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }
    }
}
