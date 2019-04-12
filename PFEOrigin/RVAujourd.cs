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
    public partial class RVAujourd : Form
    {
        public RVAujourd()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            picUp.Visible = false;
            PicDown.Visible = true;
            DGVRVaujour.Visible = false;

        }

        private void PicDown_Click(object sender, EventArgs e)
        {
            picUp.Visible = true;
            PicDown.Visible = false;
            DGVRVaujour.Visible = true;
        }

        private void RVAujourd_Load(object sender, EventArgs e)
        {
            using (DbEntities dbaujour = new DbEntities())
            {

                var Query = from s in dbaujour.Clients
                            join r in dbaujour.RendezVous
                            on s.id equals r.id
                            where r.RVdate == DateTime.Today
                            select new
                            {
                                Patiant=s.CIN,
                                Nom = s.nomCli,
                                Prenom = s.prenom,
                                Telephone = s.Tel,
                                Sex = s.sex,
                                Date_RV = r.RVdate,
                                RV_a = r.RVTime
                            };
                DGVRVaujour.DataSource = Query.OrderBy(o=>o.RV_a ).ToList();
                //DGVRVaujour.DataSource=dbaujour.RendezVous.Where(w => w.RVdate == DateTime.Today)
                //                                          .Select(s => new { Patiant = s.CIN, rendez_vous_à = s.RVTime }).ToList();
            }
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();

           
            
        }
    }
}
