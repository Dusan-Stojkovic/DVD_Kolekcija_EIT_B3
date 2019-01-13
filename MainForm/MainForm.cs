using System;
using System.Windows.Forms;
using MainForm.PoTipuUlogeIProducentuForm;      //(B4)
using MainForm.ProducentiForm;                  //(B4)
using MainForm.GlumciForm;
using MainForm.ZanroviIGlumciForm;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void glumciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glumci f = new Glumci();
            f.Show();
            this.Hide();
        }

        private void poZanrovimaIGlumcimaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Zanrovi_i_glumci f = new Zanrovi_i_glumci();
            f.Show();
            this.Hide();
        }

        private void poTipuUlogeIProducentuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sledeci zadatak (B4)
            /*Vrsta_Uloge_I_Producenti f = new Vrsta_Uloge_I_Producenti();
            f.Show();
            this.Hide();*/
        }

        private void producentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sledeci zadatak (B4)
            /*Producenti f = new Producenti();
            f.Show();
            this.Hide();*/
        }

        private void izlazAltIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
