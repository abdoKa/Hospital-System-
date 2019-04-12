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
    public partial class DossierDesPatiant : Form
    {
        public DossierDesPatiant()
        {
            InitializeComponent();
        }

        private void DossierDesPatiant_Load(object sender, EventArgs e)
        {

            using (DbEntities dbdocumentlist = new DbEntities())
            {
                var Query = from s in dbdocumentlist.Clients
                            join r in dbdocumentlist.RendezVous

                            on s.id equals r.id 
                           
                            select new
                            {
                                Dossier = r.id,
                                Patiant = s.CIN,
                                Nom = s.nomCli,
                                prénom = s.prenom,
                                Tél = s.Tel,
                                Adress = s.addressCli,
                                Date_du_RV = r.RVdate
                            };
                DGVDossierClient.DataSource = Query.ToList();
            }
        }

        public void Refresh()
        {
            using (DbEntities dbrefresh = new DbEntities())
            {
                var Query = from s in dbrefresh.Clients
                            join r in dbrefresh.RendezVous
                            on s.id equals r.id
                            select new
                            {
                                Dossier = r.id,
                                Patiant = s.CIN,
                                Nom = s.nomCli,
                                prénom = s.prenom,
                                Tél = s.Tel,
                                Adress = s.addressCli,
                                Date_du_RV = r.RVdate
                            };
                DGVDossierClient.DataSource = Query.ToList();
            }
        }
        private void DGVDossierClient_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtSearcClient_OnValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnSearchDocs_Click(object sender, EventArgs e)
        {
            using (DbEntities searchdoc = new DbEntities())
            {

                var Query = from s in searchdoc.Clients
                            join r in searchdoc.RendezVous
                            on s.id equals r.id
                            where s.nomCli.Contains(txtSearcClient.Text)
                                  || s.CIN.Contains(txtSearcClient.Text) 
                                  || s.prenom.Contains(txtSearcClient.Text)
                                    
                            select   new
                            {
                                Dossier = r.id,
                                Patiant = s.CIN,
                                Nom = s.nomCli,
                                prénom = s.prenom,
                                Tél=s.Tel,
                                Adress=s.addressCli,
                                Date_du_RV = r.RVdate
                            };

                DGVDossierClient.DataSource = Query.ToList();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDocumentPat fdocs = new FDocumentPat();
            fdocs.Show();
        }
    }
}
