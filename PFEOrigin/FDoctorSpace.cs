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
    public partial class FDoctorSpace : Form
    {
        public FDoctorSpace()
        {
            InitializeComponent();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDocumentPat doc = new FDocumentPat();
            doc.Show();
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            RVAujourd rv = new RVAujourd();
            rv.Show();
            
            //pnlDocPatiant.Enabled = false;
            //pnlGcom.Enabled = false;
            //pnlRV.Enabled = false;
            //pnlImprimer.Enabled = false;
            //pnlquiter.Enabled = false;



        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPrint impro = new FPrint();
            impro.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void FDoctorSpace_Load(object sender, EventArgs e)
        {

        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("voulez vous déconnectez", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GcompteDoct G= new GcompteDoct();
            G.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDocPatiant_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlquiter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
