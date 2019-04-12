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
    public partial class FDocumentPat : Form
    {
        public FDocumentPat()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pnlAddDocument.Visible = true;
        }

        private void FDocumentPat_Load(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbdocumentlist = new DbEntities())
                {
                    var Query = from s in dbdocumentlist.Clients
                                join r in dbdocumentlist.DocumentsClients
                                on s.id equals r.id


                                //join m in dbdocumentlist.RendezVous
                                //on s.id equals m.id
                                select new
                                {
                                    Docs = r.id,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    P_Maladie = r.Maladie,
                                    maladie_chroniche = r.maladieChronique,
                                    Opération = r.operation,
                                    Pois_Kg = r.Poids,
                                    Longeur_cm = r.Longueur,
                                    //Date_RV=m.RVdate
                                };

                    DGVDocument.DataSource = Query.ToList();

                }
            }
            catch 
            {

            }
        }
        public void Clear()
        {
            txtLongeur.Text = "";
            txtPoid.Text = "";
            txtMaladieCronich.Text = "";
            txtmaladie.Text = "";
            richTextBox1.Text = "";
        }
        public void Refresh()
        {
            try
            {
                using (DbEntities Select = new DbEntities())
                {
                    var Query = from s in Select.Clients
                                join r in Select.DocumentsClients
                                on s.id equals r.id
                                select new
                                {
                                    Docs = r.id,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    P_Maladie = r.Maladie,
                                    maladie_chroniche = r.maladieChronique,
                                    Opération = r.operation,
                                    Pois_Kg = r.Poids,
                                    Longeur_cm = r.Longueur
                                };
                    DGVDocument.DataSource = Query.ToList();
                }
            }
            catch 
            {

            }
        }
        private void BtnRenregister_Click(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbdocument = new DbEntities())
                {
                    if (txtLongeur.Text=="" && txtPoid.Text==""  && txtmaladie.Text=="" && txtMaladieCronich.Text=="")
                    {
                        MessageBox.Show("assurez-vous d'insérer des champs obligatoires");
                    }
                    else
                    {
                            
                    var Id = int.Parse(DGVDocument.CurrentRow.Cells[0].Value.ToString());
                    var old = dbdocument.DocumentsClients.Where(a => a.id == Id).First();

                    DocumentsClient docsnew  = new DocumentsClient();
                    docsnew.id = int.Parse(txtid.Text);
                    docsnew.Maladie = txtmaladie.Text;
                    docsnew.maladieChronique = txtMaladieCronich.Text;
                    docsnew.Poids = Convert.ToDouble(txtPoid.Text);
                    docsnew.Longueur = Convert.ToDouble(txtLongeur.Text);
                    docsnew.operation = richTextBox1.Text;
                    old.id = docsnew.id;
                    old.Maladie = docsnew.Maladie;
                    old.maladieChronique = docsnew.maladieChronique;
                    old.Poids = docsnew.Poids;
                    old.Longueur = docsnew.Longueur;
                    old.operation = docsnew.operation;
                    dbdocument.SaveChanges();
                    pnlAddDocument.Visible = false;

                    SuucedDocs sucdoc = new SuucedDocs();
                    sucdoc.Show();
                    pnlAddDocument.Visible = false;
                    picDelete.Enabled = true;
                    Refresh();
                    Clear();
                    pnlAddDocument.Visible = false;
                    enabletext();
                    btnRenregister.Visible = false;
                        lblannuler.Visible = false;
                    }
                    
                  
                }
            }
            catch 
            {   }
        }

        public void enabletext()
        {
            txtid.Enabled = false;
            txtLongeur.Enabled = false;
            txtPoid.Enabled = false;
            txtMaladieCronich.Enabled = false;
            txtmaladie.Enabled = false;
            richTextBox1.Enabled = false;

        }


        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            pnlAddDocument.Visible = false;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities searchdoc = new DbEntities())
                {

                    var Query = from s in searchdoc.Clients
                                join r in searchdoc.DocumentsClients
                                on s.id equals r.id
                                where s.nomCli.Contains(txtSearchdocument.Text)
                                select new
                                {
                                    Docs = r.id,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    P_Maladie = r.Maladie,
                                    maladie_chroniche = r.maladieChronique,
                                    Opération = r.operation,
                                    Pois_Kg = r.Poids,
                                    Longeur_cm = r.Longueur
                                };
                    DGVDocument.DataSource = Query.ToList();

                }

            }
            catch
            {

            }
            
        }

        private void TxtSearchdocument_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbdocumentlistref = new DbEntities())
                {

                    var Query = from s in dbdocumentlistref.Clients
                                join r in dbdocumentlistref.DocumentsClients
                                on s.id equals r.id
                                select new
                                {
                                    Docs = r.id,
                                    Nom = s.nomCli,
                                    Prenom = s.prenom,
                                    P_Maladie = r.Maladie,
                                    maladie_chroniche = r.maladieChronique,
                                    Opération = r.operation,

                                    Pois_Kg = r.Poids,
                                    Longeur_cm = r.Longueur
                                };
                    DGVDocument.DataSource = Query.ToList();
                }
            }
            catch 
            {

            }
        }

        private void DGVDocument_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void DGVDocument_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                pnlAddDocument.Visible = true;

                txtid.Text = DGVDocument.CurrentRow.Cells["Docs"].Value.ToString();
                txtmaladie.Text = DGVDocument.CurrentRow.Cells["P_Maladie"].Value.ToString();
                txtMaladieCronich.Text = DGVDocument.CurrentRow.Cells["maladie_chroniche"].Value.ToString();
                txtPoid.Text = DGVDocument.CurrentRow.Cells["Pois_Kg"].Value.ToString();
                txtLongeur.Text = DGVDocument.CurrentRow.Cells["Longeur_cm"].Value.ToString();
                richTextBox1.Text = DGVDocument.CurrentRow.Cells["Opération"].Value.ToString();

            }
            catch 
            {

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDoctorSpace docs = new FDoctorSpace();
            docs.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DossierDesPatiant dos = new DossierDesPatiant();
            dos.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupprimer_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnSupprimer_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void DGVDocument_MultiSelectChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSupprimer_DragLeave(object sender, EventArgs e)
        {
           
        }

        private void btnSupprimer_MouseEnter_1(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.Red;
            btnSupprimer.ForeColor = Color.White;
        }

        private void btnSupprimer_MouseLeave_1(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.FromArgb(51, 122, 183);
            btnSupprimer.ForeColor = Color.White;
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (DbEntities dbDelete = new DbEntities())
                {
                    DialogResult myResult;
                    myResult = MessageBox.Show("ce dossier va supprimer completement!!! , Est que vous voulez vraiment supprimer ce document ?",
                                                " confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (myResult == DialogResult.Yes)
                    {
                        var ID = int.Parse(DGVDocument.CurrentRow.Cells["Docs"].Value.ToString());
                        DocumentsClient Docs = dbDelete.DocumentsClients.Where(w => w.id == ID).FirstOrDefault();
                        RendezVou RV = dbDelete.RendezVous.Where(w => w.id == ID).FirstOrDefault();
                        Client Cl = dbDelete.Clients.Where(w => w.id == ID).FirstOrDefault();



                        dbDelete.DocumentsClients.Remove(Docs);
                        dbDelete.RendezVous.Remove(RV);
                        dbDelete.Clients.Remove(Cl);
                        dbDelete.SaveChanges();

                        lblOK.Visible = true;
                        gifDelete.Visible = true;
                        Refresh();
                        enabletext();


                    }


                }
            }
            catch
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            btnRenregister.Visible = true;

            //picAdd.Enabled = false;

            picDelete.Enabled = false;
            txtLongeur.Enabled = true;
            txtPoid.Enabled = true;
            txtmaladie.Enabled = true;
            txtMaladieCronich.Enabled = true;
            richTextBox1.Enabled = true;

            lblannuler.Visible = true;

        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            //btnAjouter.Visible = true;
            //picEdit.Enabled = false;
            //picDelete.Enabled = false;
            
            //txtLongeur.Enabled = true;
            //txtPoid.Enabled = true;
            //txtmaladie.Enabled = true;
            //txtMaladieCronich.Enabled = true;
            //richTextBox1.Enabled = true;

            //lblannuler.Visible = true;
        }

        private void lblannuler_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult myResult;
                myResult = MessageBox.Show("Voulez Vraimant quitter c'est operations",
                                            " confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (myResult == DialogResult.OK)
                {
                    txtLongeur.Enabled = false;
                    txtPoid.Enabled = false;
                    txtmaladie.Enabled = false;
                    txtMaladieCronich.Enabled = false;
                    richTextBox1.Enabled = false;

                    btnRenregister.Visible = false;

                    //btnAjouter.Visible = false;
                    btnSupprimer.Visible = false;

                    //btnAjouter.Visible = false;
                    picEdit.Enabled = true;
                    picDelete.Enabled = true;
                    //picAdd.Enabled = true;
                    lblannuler.Visible = false;

                }
            }
            catch 
            {

            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            //picAdd.Enabled = false;
            picEdit.Enabled = false;


            lblannuler.Visible = true;
            btnSupprimer.Visible = true;
        }

        private void picClosePanele_Click(object sender, EventArgs e)
        {
            pnlAddDocument.Visible = false;
        }

        private void lblOK_Click(object sender, EventArgs e)
        {
            pnlAddDocument.Visible = false;
            gifDelete.Visible = false;
        }

        private void gifDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
