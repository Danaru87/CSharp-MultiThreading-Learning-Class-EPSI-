using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1___MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form_load(object sender, EventArgs e)
        {
            lblDateHeure.Text = DateTime.Now.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            AfficherDateHeure();
        }

        private void AfficherDateHeure()
        {
            if (rbtnDate.Checked)
                lblDateHeure.Text = DateTime.Now.ToShortDateString();
            else if (rbtnHeure.Checked)
                lblDateHeure.Text = DateTime.Now.ToLongTimeString();
            else
                lblDateHeure.Text = DateTime.Now.ToString();
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            bool cont = true;
            while (cont)
            {
                Thread.Sleep(1000);
                AfficherDateHeure();
                Refresh();
            }
        }
    }
}
