using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_o_vectores
{
    public partial class prueba2 : Form
    {
        public prueba2()
        {
            InitializeComponent();
        }
        private static string[] nombres = new string[10];
        private static int cont=0;
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtNombre.Text;
            agregar(nombre);
            txtNombre.Clear();

        }
        private void agregar(string nom)
        {
            nombres.SetValue(nom, cont);
            cont++;
        }
        private void ag()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] != null)
                {
                    listBox1.Items.Add(nombres[i]);
                }
                else
                {
                    break;
                }
            }
        }

        private void CmdMostrar_Click(object sender, EventArgs e)
        {
            ag();
        }
    }
}


