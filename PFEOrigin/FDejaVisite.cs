using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace PFEOrigin
{
    public partial class FDejaVisite : Form
    {
        public FDejaVisite()
        {
            InitializeComponent();
        }

        private void FDejaVisite_Load(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbselect = new DbEntities())
                {
                    var Query = from s in dbselect.Clients
                                join r in dbselect.RendezVous
                                on s.id equals r.id
                                select new
                                {
                                    P_CIN = s.CIN,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    DDN = s.DateNaissance,
                                    Adress = s.addressCli,
                                    Tel = s.Tel,
                                    Sex = s.sex,
                                    assure = s.Assurer,
                                    Date_RV = r.RVdate,
                                    RV_a = r.RVTime,

                                };
                    DGVClientInfo.DataSource = Query.OrderBy(x => x.Date_RV).ToList();
                }
            }
            catch 
            {

            }
        }


        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm";
        }

        private void DGVClientInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVClientInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Client cl = new Client();

        private void DGVClientInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                bunifuCards1.Visible = true;
                panel1.Visible = true;
                txtCINNewRV.Text = DGVClientInfo.CurrentRow.Cells["P_CIN"].Value.ToString();
                txtNomnewRV.Text = DGVClientInfo.CurrentRow.Cells["Nom"].Value.ToString();
                txtPrenomnewRV.Text = DGVClientInfo.CurrentRow.Cells["Prenom"].Value.ToString();
                txtTelnewRV.Text = DGVClientInfo.CurrentRow.Cells["Tel"].Value.ToString();
                mskDDN.Text = Convert.ToDateTime(DGVClientInfo.CurrentRow.Cells["DDN"].Value).ToShortDateString();
                richAdressnewRV.Text = DGVClientInfo.CurrentRow.Cells["Adress"].Value.ToString();
                string S = DGVClientInfo.CurrentRow.Cells["Sex"].Value.ToString();
                if (S == "Femme")
                {
                    rdbFnewRV.Checked = true;
                }
                else
                    if (S == "Homme")
                {
                    rdbHnewRV.Checked = true;

                }
                
                string A = DGVClientInfo.CurrentRow.Cells["assure"].Value.ToString();
                if (A == "Oui")
                {
                    checkassurenewRV.Checked = true;
                }
                else
                     if (A=="Non")
                     {
                    checkassurenewRV.Checked = false;

                     }

              dtpRVdatenewEV.Value = Convert.ToDateTime(DGVClientInfo.CurrentRow.Cells["Date_RV"].Value.ToString());
              dateTimePicker1.Value = Convert.ToDateTime(DGVClientInfo.CurrentRow.Cells["RV_a"].Value.ToString());

                txtCINNewRV.Enabled = false;
                txtNomnewRV.Enabled = false;
                txtPrenomnewRV.Enabled = false;
                txtTelnewRV.Enabled = false;
                txtTelnewRV.Enabled = false;
                richAdressnewRV.Enabled = false;
                rdbFnewRV.Enabled = false;
                rdbHnewRV.Enabled = false;
                checkassurenewRV.Enabled = false;
            }
            catch 
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picSave.Visible = true;
            mskDDN.Enabled = true;
            txtCINNewRV.Enabled = true;
            txtNomnewRV.Enabled = true;
            txtPrenomnewRV.Enabled = true;
            txtTelnewRV.Enabled = true;
            richAdressnewRV.Enabled = true;
            rdbFnewRV.Enabled = true;
            rdbHnewRV.Enabled = true;
            checkassurenewRV.Enabled = true;
            btnConfirmer.Enabled = false;
            picSave.Visible = true;



        }

        private void picSave_Click(object sender, EventArgs e)
        {
           
        }

        public void Refresh()
        {
            try
            {
                using (DbEntities dbselect = new DbEntities())
                {
                    var Query = from s in dbselect.Clients
                                join r in dbselect.RendezVous
                                on s.id equals r.id
                                select new
                                {
                                    P_CIN = s.CIN,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    DDN = s.DateNaissance,
                                    Adress = s.addressCli,
                                    Tel = s.Tel,
                                    Sex = s.sex,
                                    assure = s.Assurer,
                                    Date_RV = r.RVdate,
                                    RV_a = r.RVTime,

                                };
                    DGVClientInfo.DataSource = Query.ToList();
                }
            }
            catch 
            {

            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbDelete = new DbEntities())
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("Voulez vous vraiment supprimer ce patient?", " Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (myResult == DialogResult.OK)
                    {

                        //Client cl = dbDelete.Clients.Where(w => w.CIN == txtCINNewRV.Text).First();
                        //dbDelete.Clients.Remove(cl);
                        //dbDelete.SaveChanges();
                        MessageBox.Show("Vous n'avez pas le droit de supprimer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Refresh();


                    }


                }
            }
            catch
            {
                //MessageBox.Show("you don't have a permession!!");
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            //try
            //{
                using (DbEntities dbnewRV = new DbEntities())
                {
                var TimeRv = TimeSpan.Parse(dateTimePicker1.Value.ToString("HH:mm"));
                var DateRv = Convert.ToDateTime(dtpRVdatenewEV.Value.ToString("MM-dd-yyyy"));

                if (dbnewRV.RendezVous.Any(w => w.RVdate == DateRv && w.RVTime == TimeRv))

                        {
                            MessageBox.Show("ce rendez-vous est déjà pris", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    else
                    {

                    dbnewRV.Clients.Any(a => a.CIN == txtCINNewRV.Text);
                    RendezVou RV = new RendezVou();
                    Client Clnewrv = new Client();
                    DocumentsClient docs = new DocumentsClient();
                    cl.CIN = txtCINNewRV.Text;
                    cl.nomCli = txtNomnewRV.Text;
                    cl.prenom = txtPrenomnewRV.Text;
                    cl.DateNaissance = Convert.ToDateTime(mskDDN.Text);
                    cl.addressCli = richAdressnewRV.Text;
                    cl.Tel = int.Parse(txtTelnewRV.Text);
                    if (rdbFnewRV.Checked == true)
                    {
                        cl.sex = "Femme";
                    }
                    else
                    {
                        cl.sex = "Homme";
                    }
                    if (checkassurenewRV.Checked == true)
                    {
                        cl.Assurer = "Oui";
                    }
                    else

                    {

                        cl.Assurer = "Non";
                    }


                    ////------tabel RV
                    //if (dbnewRV.RendezVous.Any(a => a.RVdate == dtpRVdatenewEV.Value &&
                    //a.RVTime.Value.Hours == dateTimePicker1.Value.Hour &&
                    //a.RVTime.Value.Minute == dateTimePicker1.Value.Minute).ToString().First();
                    //{

                    //}
                    RendezVou rv = new RendezVou();
                    rv.RVdate = dtpRVdatenewEV.Value;
                    rv.RVTime = TimeSpan.Parse(dateTimePicker1.Text);
                    rv.id = cl.id;
                    docs.id = cl.id;


                    dbnewRV.Clients.Add(cl);
                    dbnewRV.RendezVous.Add(rv);
                    dbnewRV.DocumentsClients.Add(docs);

                    SuucedDocs S = new SuucedDocs();
                    S.picSuuceAddDocs.Visible = false;
                    S.pictureBox1.Visible = true;
                    S.Show();

                    dbnewRV.SaveChanges();
                    Refresh();
                    }

                }
            //}
            //catch 
            //{

            //}
           

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
                using (DbEntities dbSearch = new DbEntities())
                {
                    var Query = from s in dbSearch.Clients
                                join r in dbSearch.RendezVous
                                on s.id equals r.id
                                where s.CIN.Contains(txtSearch.Text)
                                || s.nomCli.Contains(txtSearch.Text)
                                || s.prenom.Contains(txtSearch.Text)

                                select new
                                {
                                    P_CIN = s.CIN,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    DDN = s.DateNaissance,
                                    Adress = s.addressCli,
                                    Tel = s.Tel,
                                    Sex = s.sex,
                                    assure = s.Assurer,
                                    Date_RV = r.RVdate,
                                    RV_a = r.RVTime
                                };
                    DGVClientInfo.DataSource = Query.ToList();
                }
            
        }

        private void DGVClientInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbselect = new DbEntities())
                {
                    var Query = from s in dbselect.Clients
                                join r in dbselect.RendezVous
                                on s.id equals r.id
                                select new
                                {
                                    P_CIN = s.CIN,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    DDN = s.DateNaissance,
                                    Adress = s.addressCli,
                                    Tel = s.Tel,
                                    Sex = s.sex,
                                    assure = s.Assurer,
                                    Date_RV = r.RVdate,
                                    RV_a = r.RVTime
                                };
                    DGVClientInfo.DataSource = Query.ToList();
                }
            }
            catch
            {
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FInfermierSpace f = new FInfermierSpace();
            f.Show();
        }

        private void txtTelnewRV_OnValueChanged(object sender, EventArgs e)
        {
            txtTelnewRV.MaxLength = 10;
        }

        private void txtCINNewRv_OnValueChanged(object sender, EventArgs e)
        {
            

        }

        private void TxtNomnewRV_OnValueChanged(object sender, EventArgs e)
        {
            txtNomnewRV.MaxLength = 100;

        }

        private void TxtPrenomnewRV_OnValueChanged(object sender, EventArgs e)
        {
            txtNomnewRV.MaxLength = 64;

        }

        private void RichAdressnewRV_TextChanged(object sender, EventArgs e)
        {
            txtNomnewRV.MaxLength = 100;

        }

        private void PicSave_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            
            //EditBye
            var cin = DGVClientInfo.CurrentRow.Cells["P_CIN"].Value.ToString();

            Client old = db.Clients.Where(c => c.CIN == cin ).First();
           
            Client newCL = new Client();
            newCL.CIN = txtCINNewRV.Text;
            newCL.nomCli = txtNomnewRV.Text;
            newCL.prenom = txtPrenomnewRV.Text;
            if (rdbFnewRV.Checked == true)
            {
                newCL.sex = "Femme";
            }
            else
            {
                newCL.sex = "Homme";
            }
            newCL.addressCli = richAdressnewRV.Text;
            newCL.Tel = int.Parse(txtTelnewRV.Text);
            newCL.DateNaissance = Convert.ToDateTime(mskDDN.Text);
            if (checkassurenewRV.Checked == true)
            {
                newCL.Assurer = "Oui";
            }
            else

            {

                newCL.Assurer = "Non";
            }

            

            old.CIN = newCL.CIN;
            old.nomCli = newCL.nomCli;
            old.prenom = newCL.prenom;
            old.sex = newCL.sex;
            old.addressCli = newCL.addressCli;
            old.Tel = newCL.Tel;
            old.DateNaissance = newCL.DateNaissance;
            old.Assurer = newCL.Assurer;

           
            db.SaveChanges();
            SuucedDocs S = new SuucedDocs();
            S.picSuuceAddDocs.Visible = true;
            S.pictureBox1.Visible = false;
            S.Show();

            
            Refresh();
            //Design-------------------------------
            btnConfirmer.Enabled = true;
            picSave.Visible = false;
            txtCINNewRV.Enabled = false;
            txtNomnewRV.Enabled = false;
            txtPrenomnewRV.Enabled = false;
            txtTelnewRV.Enabled = false;
            txtTelnewRV.Enabled = false;
            richAdressnewRV.Enabled = false;
            rdbFnewRV.Enabled = false;
            rdbHnewRV.Enabled = false;
            checkassurenewRV.Enabled = false;


        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void PicDown_Click(object sender, EventArgs e)
        {
            picDelete.Visible = true;
            picEdit.Visible = true;
            PicDown.Visible = false;
            picUp.Visible = true;

        }

        private void picUp_Click(object sender, EventArgs e)
        {
            picDelete.Visible = false;
            picEdit.Visible = false;
            picSave.Visible = false;
            PicDown.Visible = true;
            picUp.Visible = false ;

            txtCINNewRV.Enabled = false;
            txtNomnewRV.Enabled = false;
            txtPrenomnewRV.Enabled = false;
            txtTelnewRV.Enabled = false;
            dateTimePicker1.Enabled = false;
            richAdressnewRV.Enabled = false;
            rdbFnewRV.Enabled = false;
            rdbHnewRV.Enabled = false;
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
