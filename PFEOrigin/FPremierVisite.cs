using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PFEOrigin
{
    public partial class FPremierVisite : Form
    {
        public FPremierVisite()
        {
            InitializeComponent();
        }

        private void DateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            dtpRVtime.CustomFormat = "HH:mm";
        }

        private void BtnCommancer_Click(object sender, EventArgs e)
        {
           

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FInfermierSpace sp = new FInfermierSpace();
        }

        private void DtpRVtime_MouseDown(object sender, MouseEventArgs e)
        {
            dtpRVtime.CustomFormat = "HH:mm";
        }
      
        
        private void BtnCommancer_Click_1(object sender, EventArgs e)
        {
            try
            {

                using (DbEntities db = new DbEntities())
                {
                        var TimeRv = TimeSpan.Parse(dtpRVtime.Value.ToString("HH:mm"));
                        var DateRv = Convert.ToDateTime(dtpRVdate.Value.ToString("MM-dd-yyyy"));
                        Client cl = new Client();
                        RendezVou rv = new RendezVou();
                        DocumentsClient docs = new DocumentsClient();

                   if ( txtCIN.Text=="" || txtNom.Text == "" || txtPrenom.Text == "" || dtpRVdate.Value == null || dtpRVtime.Text == null 
                        || txtTel.Text=="" )
                    {
                    MessageBox.Show("Assurez-vous d'insérer des champs obligatoires","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                   }
                   else

                    if (db.RendezVous.Any(w => w.RVdate == DateRv && w.RVTime == TimeRv))

                    {
                    MessageBox.Show("ce rendez-vous est déjà pris","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                    else
                    if (db.Clients.Any(a => a.CIN == txtCIN.Text))
                    {
                        MessageBox.Show("Ce Patiany est Deja existe");
                    }

                     


                  else
                  { 

                        cl.CIN    = txtCIN.Text;
                        cl.nomCli = txtNom.Text;
                        cl.prenom = txtPrenom.Text;
                        cl.DateNaissance = Convert.ToDateTime(mskDDN.Text);
                        cl.addressCli = richAdress.Text;
                        cl.Tel = int.Parse(txtTel.Text);
                        if (rdbF.Checked == true)
                        {
                            cl.sex = "Femme";
                        }
                        else
                        {
                            cl.sex = "Homme";
                        }
                        if (checkassure.Checked==true)
                        {
                            cl.Assurer = "Oui";
                        }
                        else
                            
                        {

                            cl.Assurer = "Non";
                        }

                        


                        //------tabel RV

                        rv.RVdate = dtpRVdate.Value;
                        rv.RVTime = TimeSpan.Parse(dtpRVtime.Text);

                        //Document Cl
                        docs.id = cl.id;
                        rv.id = cl.id;

                        db.Clients.Add(cl);
                        db.RendezVous.Add(rv);
                        db.DocumentsClients.Add(docs);
                        db.SaveChanges();
                        Clear();
                        AvecSuccee av = new AvecSuccee();
                        av.Show();
                        this.Hide();
                        //MessageBox.Show("Ajouté Avec succès", "Message ℹ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  }
                }
            }
            catch
            {

            }
        }
        public void Clear()
        {
            txtCIN.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            mskDDN.Text = "";
            richAdress.Text = "";
            txtTel.Text = "";
            rdbF.Checked = false;
            rdbH.Checked = false;
            checkassure.Checked = false;
        }
        private void BunifuButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("voulez vous vraiment annuler l'opération?", 
                                                   "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               
            this.Hide();
            FInfermierSpace fr = new FInfermierSpace();
            fr.Show();
                //...
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void FPremierVisite_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtTel_OnValueChanged(object sender, EventArgs e)
        {
            txtTel.MaxLength = 10;

        }

       

        private void TxtPrenom_OnValueChanged(object sender, EventArgs e)
        {
            txtPrenom.MaxLength = 64;
        }

        private void TxtNom_OnValueChanged(object sender, EventArgs e)
        {
            txtNom.MaxLength = 100;

        }

        private void RichAdress_TextChanged(object sender, EventArgs e)
        {
            richAdress.MaxLength = 100;
        }

        private void dtpTimeControleP_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void dtpTimeC_MouseDown(object sender, MouseEventArgs e)
        {
        }
    }
}
