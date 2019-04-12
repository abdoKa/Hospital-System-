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
    public partial class FStart : Form
    {
        public FStart()
        {
            InitializeComponent();
        }

        private void FStart_Load(object sender, EventArgs e)
        {
            string[] items = { "", "Docteur", "Infirmier" };
            foreach (var item in items)
            {
                bunifuDropdown1.Items.Add(item);
            }

        }


        private void BtnCommancer_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtusername.Text == "" && txtpassword.Text == "")
                {
                    MessageBox.Show("assurez-vous d'entrer votre nom d'utilisateur et votre mot de passe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    using (DbEntities dbLogin = new DbEntities())
                    {
                    
                        switch (bunifuDropdown1.selectedValue)
                        {

                            case "":
                                lblChoix.Text = "vous devez choisir pour commencer";
                                break;

                                //Docteur
                            case "Docteur":
                                if (dbLogin.Doctors.Any(a => a.idDoc == txtusername.Text && a.PasswordDoc == txtpassword.Text))
                                {
                                   
                                    FDoctorSpace doc = new FDoctorSpace();
                                    doc.Show();
                                    this.Hide();
                                }
                                if (dbLogin.Doctors.Any(w => w.idDoc != txtusername.Text))
                                {
                                    lblUsernam.Text = "nom d'utilisateur incorrect";
                                }
                                else
                                if (dbLogin.Doctors.Any(w => w.PasswordDoc != txtpassword.Text))
                                {
                                    lblpassword.Text = "Mot de passe incorrect";
                                }
                                break;
                                //Infermier
                            case "Infirmier":
                                if (dbLogin.Admines.Any(a => a.userName == txtusername.Text && a.Adminpassword == txtpassword.Text))
                                {
                                    FInfermierSpace fr = new FInfermierSpace();
                                    fr.Show();
                                    this.Hide();
                                }
                                if (dbLogin.Admines.Any(w => w.userName != txtusername.Text))
                                {
                                    lblUsernam.Text = "nom d'utilisateur incorrect";
                                }
                                else
                                if (dbLogin.Admines.Any(w => w.Adminpassword != txtpassword.Text))
                                {
                                    lblpassword.Text = "Mot de passe incorrect";
                                }
                                break;

                                
                           
                        }





                    }
                }
            }
            catch 
            {
            }
           
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            lblpassword.Text = "";
        }

        private void BunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
           

            switch (bunifuDropdown1.selectedValue)
            {
                case "Docteur":
                    PicDoc.Visible = true;
                    PicInfermier.Visible = false;
                    break;
                case "Infirmier":
                    PicInfermier.Visible = true;
                    PicDoc.Visible = false;

                    break;
                    
            }
        }

        private void Txtusername_OnValueChanged(object sender, EventArgs e)
        {
            lblUsernam.Text = "";
        }
    }
}
