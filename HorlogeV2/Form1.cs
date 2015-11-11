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

namespace HorlogeV2
{
    public partial class Form1 : Form
    {
        private Thread LeThread;
        public Form1()
        {
            InitializeComponent();
            LeThread = new Thread(Go);
            LeThread.Name = "Thread calcul heure / date";
            
        }

        private void Go()
        {
            
            for(;;)
            {
                AfficherDateHeure();
                Thread.Sleep(1000);
            }
            
        }

        private void form_load(object sender, EventArgs e)
        {
            lblDateHeure.Text = DateTime.Now.ToString();
            LeThread.Start();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //AfficherDateHeure();
        }

        private void AfficherDateHeure()
        {
            if (rdbtDate.Checked)
                lblDateHeure.Invoke(new Action(() => lblDateHeure.Text = DateTime.Now.ToShortDateString()));
            else if (rdbtHeure.Checked)
                lblDateHeure.Invoke(new Action(()=>lblDateHeure.Text = DateTime.Now.ToLongTimeString()));
            else
                lblDateHeure.Invoke(new Action(() => lblDateHeure.Text = DateTime.Now.ToString()));
        }

        private void rdbtDateHeure_CheckedChanged(object sender, EventArgs e)
        {
            AfficherDateHeure();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LeThread.Abort();
            LeThread.Join();
        }
    }
}
