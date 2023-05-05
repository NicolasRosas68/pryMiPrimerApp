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
    public partial class frmFinanzas : Form
    {
        public decimal Varimpuestos;
        public decimal Varsalida;
        public decimal VarDepocito;
        public decimal Varcomida;
        public decimal VArAlquileres; 
        public frmFinanzas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
       
       
        {
            //declaracion de Variables Globales 
            Decimal VarDepocito, VarAlquileres, VarImpuestos, VarComida, varSalida;

            //Inicializar Variables 
            VarAlquileres = 0;
            VarImpuestos = 0;
            VarComida = 0;
            VarDepocito = 0; 
            varSalida = 0;

        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
           
            VarDepocito = Convert.ToDecimal(txtdeposito.Text);
            Varcomida = Convert.ToDecimal(txtComida.Text);
            Varimpuestos = Convert.ToDecimal(txtImpuestos.Text);

            Varsalida = VarDepocito - (Varcomida + Varimpuestos + VArAlquileres);

            txtresultado.Text=Varsalida.ToString();

            //conectar - unir texto 

           
        }
    }
}
