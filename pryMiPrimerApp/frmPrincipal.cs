using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAlacena frmAlacena = new frmAlacena();
            frmAlacena.ShowDialog();

        }

        private void cmdfinanzas_Click(object sender, EventArgs e)
        {

            frmFinanzas frmFinanzas = new frmFinanzas();
            frmFinanzas.ShowDialog();

        }
    }
}
