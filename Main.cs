using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rawrawrawr
{
    public partial class frmContenedor : Form
    {
        public frmContenedor()
        {
            InitializeComponent();
        }

        private void btnDepto_Click(object sender, EventArgs e)
        {
            AbrirForm(new Acoplables.frmDepto());
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            AbrirForm(new Acoplables.frmTaller());
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirForm(object form)
        {
            if (this.pnlMapa.Controls.Count > 0)
            {
                this.pnlMapa.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMapa.Controls.Add(f);
            this.pnlMapa.Tag = f;
            f.Show();
        }
    }
}
