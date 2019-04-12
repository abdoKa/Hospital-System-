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
    public partial class FPrint : Form
    {
        public FPrint()
        {
            InitializeComponent();
        }

        private void PrintDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap mb = new Bitmap(this.bunifuCards1.Width, this.bunifuCards1.Height);
            bunifuCards1.DrawToBitmap(mb, new Rectangle(0, 0, this.bunifuCards1.Width, this.bunifuCards1.Height));
            e.Graphics.DrawImage(mb, 0, 0);

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
            bunifuCards1.Enabled = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
          
            pnlSpecialitaiondoc.Visible = true;
            lblAdressP.Enabled = false;
        }

        private void BtnAnnulerord_Click(object sender, EventArgs e)
        {
            pnlSpecialitaiondoc.Visible = false;

        }

        private void BtnEnregisOrdo_Click(object sender, EventArgs e)
        {

            if (txtNomDoc.Text == "" ||
            txtspecialisation.Text == "" ||
            richtxtDetail.Text == "" ||
            txtVille.Text == "" ||
            richadress.Text == "" ||
            txtPhone.Text == ""
            )

            {
                MessageBox.Show("assurez-vous d'entrer toutes vos informations", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else
            {
                
                lblDoctrorNameP.Text = txtNomDoc.Text;
                lblDoctorSpeialisationP.Text = txtspecialisation.Text;
                lblSpecialisationDetailP.Text = richtxtDetail.Text;
                lblVilleP.Text = txtVille.Text;
                lblAdressP.Text = richadress.Text;
                lblTelP.Text = txtPhone.Text;

                //pnlSpecialitaiondoc.Visible = false;

            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FDoctorSpace fdocs = new FDoctorSpace();
            fdocs.Show();
        }

        private void FPrint_Load(object sender, EventArgs e)
        {

        }

        private void lblSpecialisationDetailP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
