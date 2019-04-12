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
    public partial class GcompteDoct : Form
    {
        public GcompteDoct()
        {
            InitializeComponent();
        }

        private void lblusernameDoc_Click(object sender, EventArgs e)
        {

        }

        private void lblnewusernameDoc_Click(object sender, EventArgs e)
        {

        }

        private void lblcurentpasswordDoc_Click(object sender, EventArgs e)
        {

        }

        private void lblconfirmePasswordDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSetti_Click(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbS = new DbEntities())
                {
                    if (txtNomEtulisateurDoc.Text == "" || txtcurrenpassDoc.Text == "" ||
                       txtConfirmPasswrodDoc.Text == "" || txtNouvPasswordDoc.Text == ""
                       || txtNuvnomUtilisateurDoc.Text == "")
                    {
                        MessageBox.Show("veuillez remplire les champs obligatoir", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        Doctor newA = new Doctor();
                        Doctor oldusernam = (from c in dbS.Doctors
                                             where c.idDoc == txtNomEtulisateurDoc.Text
                                             && c.PasswordDoc == txtcurrenpassDoc.Text
                                             select c).FirstOrDefault();
                        if (dbS.Doctors.Any(a => a.idDoc != txtNomEtulisateurDoc.Text))
                        {
                            lblusernameDoc.Text = "cet utilisateur n'existe pas!";
                        }
                        else
                            if (dbS.Doctors.Any(a => a.PasswordDoc == txtNuvnomUtilisateurDoc.Text))
                        {
                            lblnewusernameDoc.Text = "Cet identifiant existe déjà";
                        }
                        if (dbS.Doctors.Any(a => a.PasswordDoc != txtcurrenpassDoc.Text))
                        {
                            lblcurentpasswordDoc.Text = "votre mot de passe incorrect";
                        }
                        else
                            if (dbS.Doctors.Any(a => a.PasswordDoc == txtNouvPasswordDoc.Text))
                        {
                            lblNewPasswordDoc.Text = "vous devez avoir un nouveau mot de passe";
                        }

                        else
                        {

                            newA.idDoc = txtNuvnomUtilisateurDoc.Text;
                            if (txtNouvPasswordDoc.Text == txtConfirmPasswrodDoc.Text)
                            {
                                newA.PasswordDoc = txtConfirmPasswrodDoc.Text;

                                oldusernam.idDoc = newA.idDoc;
                                oldusernam.PasswordDoc = newA.PasswordDoc;


                                dbS.SaveChanges();
                                FrGCompte Go = new FrGCompte();
                                Go.Show();
                                this.Hide();
                            }
                            else
                            {
                                lblconfirmePasswordDoc.Text = "vos mots de passe doivent être égaux";
                            }
                        }
                    }


                }
            }
            catch
            {

            }
        }

        private void txtNouvPasswordDoc_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNouvPasswordDoc.Text.Length < 4)
            {

                lblpasswordlevel.ForeColor = Color.Red;
                lblpasswordlevel.Text = "faible";
            }
            else
               if (txtNouvPasswordDoc.Text.Length >= 8)
            {
                lblpasswordlevel.ForeColor = Color.Orange;
                lblpasswordlevel.Text = "bien";
            }

            if (txtNouvPasswordDoc.Text.Length >= 12)
            {

                lblpasswordlevel.ForeColor = Color.Green;
                lblpasswordlevel.Text = "Fort";

            }

            lblNewPasswordDoc.Text = "";
        }

        private void txtNomEtulisateurDoc_OnValueChanged(object sender, EventArgs e)
        {
            lblusernameDoc.Text = "";
        }

        private void txtNuvnomUtilisateurDoc_OnValueChanged(object sender, EventArgs e)
        {
            lblnewusernameDoc.Text = "";
        }

        private void txtcurrenpassDoc_OnValueChanged(object sender, EventArgs e)
        {
            lblcurentpasswordDoc.Text = "";
        }

        private void txtConfirmPasswrodDoc_OnValueChanged(object sender, EventArgs e)
        {
            lblconfirmePasswordDoc.Text = "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("voulez vous vraimant  quiter cette opération", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FDoctorSpace f = new FDoctorSpace();
                f.Show();
            }
            else if (result == DialogResult.No)
            {

            }
           
        }
    }
}
