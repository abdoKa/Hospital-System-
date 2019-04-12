using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PFEOrigin
{
    public partial class GCompteInfer : Form
    {
        public GCompteInfer()
        {
            InitializeComponent();
        }

        private void GCompte_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveSetti_Click(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbS = new DbEntities())
                {
                    if (txtNomEtulisateur.Text == "" || txtcurrenpass.Text == "" ||
                       txtConfirmPasswrod.Text == "" || txtNouvPassword.Text == ""
                       || txtNuvnomUtilisateur.Text == "")
                    {
                        MessageBox.Show("veuillez remplire les champs obligatoir","message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {

                        Admine newA = new Admine();
                        Admine oldusernam = (from c in dbS.Admines
                                             where c.userName == txtNomEtulisateur.Text
                                             && c.Adminpassword == txtcurrenpass.Text
                                             select c).FirstOrDefault();
                        if (dbS.Admines.Any(a => a.userName != txtNomEtulisateur.Text))
                        {
                            lblcurrentname.Text = "cet utilisateur n'existe pas!";
                        }
                        else
                            if (dbS.Admines.Any(a => a.userName == txtNuvnomUtilisateur.Text))
                        {
                            lblnewuser.Text = "Cet identifiant existe déjà";
                        }
                        if (dbS.Admines.Any(a => a.Adminpassword != txtcurrenpass.Text))
                        {
                            lblcurentpass.Text = "votre mot de passe incorrect";
                        }
                        else
                            if (dbS.Admines.Any(a => a.Adminpassword == txtNouvPassword.Text))
                            {
                            lblnouvpassword.Text = "vous devez avoir un nouveau mot de passe";
                            }

                        else
                        {

                            newA.userName = txtNuvnomUtilisateur.Text;
                            if (txtNouvPassword.Text == txtConfirmPasswrod.Text)
                            {
                                newA.Adminpassword = txtConfirmPasswrod.Text;

                                oldusernam.userName = newA.userName;
                                oldusernam.Adminpassword = newA.Adminpassword;


                                dbS.SaveChanges();
                                FrGCompte Go = new FrGCompte();
                                Go.Show();
                                this.Hide();
                            }
                            else
                            {
                                lblconfirmpass.Text = "vos mots de passe doivent être égaux";
                            }
                        }
                    }


                }
            }
            catch 
            {

            }
        }

        private void txtNomUtilisateur_OnValueChanged(object sender, EventArgs e)
        {
            lblnewuser.Text = "";
        }

        private void txtNomEtulisateur_OnValueChanged(object sender, EventArgs e)
        {
            lblcurrentname.Text = "";
        }

        private void txtcurrenpass_OnValueChanged(object sender, EventArgs e)
        {
            lblcurentpass.Text = "";
        }

        private void txtNouvPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (txtNouvPassword.Text.Length < 4 )
            {

                lblpasswordchange.ForeColor = Color.Red;
                lblpasswordchange.Text = "faible";
            }else
                if (txtNouvPassword.Text.Length >= 8)
                {
                lblpasswordchange.ForeColor = Color.Orange;
                lblpasswordchange.Text = "bien";
                }
            
                    if (txtNouvPassword.Text.Length >= 12)
                     {

                        lblpasswordchange.ForeColor = Color.Green;
                        lblpasswordchange.Text = "Fort";

                    }
            
            lblnouvpassword.Text = "";
        }

        private void txtConfirmPasswrod_OnValueChanged(object sender, EventArgs e)
        {
            lblconfirmpass.Text = "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("voulez vous vraimant  quiter cette opération", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FInfermierSpace ifermier = new FInfermierSpace();
                ifermier.Show();
            }
            else if (result == DialogResult.No)
            {

            }
           
        }
    }
}
