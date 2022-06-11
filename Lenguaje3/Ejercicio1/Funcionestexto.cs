using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Funcionestexto : Form
    {
        public Funcionestexto()
        {
            InitializeComponent();
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            string cadena;

            cadena = txtCadena.Text;

            if (cadena.Length == 0)//Validar para ingresar una cadena y no cerrar el programa.
            {
                MessageBox.Show("Debe ingresar una cadena");
                txtCadena.Focus();
                return;
            }

            lblLongitud.Text =Convert.ToString(cadena.Length); //cadena.Length.ToString();
            lblPrimer.Text = cadena.Substring(0,1);
            lblUltimo.Text = cadena.Substring(cadena.Length-1,1);
            lblMayusculas.Text = cadena.ToUpper();
            lblMinusculas.Text = cadena.ToLower();
            lblRemplazar.Text = cadena.Replace("n", "x");
        }

        private void txtCadena_TextChanged(object sender, EventArgs e)
        {
            txtCadena.Text = txtCadena.Text.Replace("Nahum", "******");
        }
    }
}
