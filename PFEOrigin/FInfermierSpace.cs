using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFEOrigin
{
    public partial class FInfermierSpace : Form
    {
        public FInfermierSpace()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPremierVisite fr = new FPremierVisite();
            fr.Show();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDejaVisite dj = new FDejaVisite();
            dj.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            RVAujourd rvau = new RVAujourd();
            rvau.Show();
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("voulez vous déconnecter", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FStart f = new FStart();
                f.Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void FInfermierSpace_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            GCompteInfer G = new GCompteInfer();
            G.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
