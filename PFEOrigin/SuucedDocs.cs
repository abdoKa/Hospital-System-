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
    public partial class SuucedDocs : Form
    {
        public SuucedDocs()
        {
            InitializeComponent();
        }

        private void btnRenregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDejaVisite dj = new FDejaVisite();
            dj.panel1.Visible = false;

        }
    }
}
