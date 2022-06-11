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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private static string[] nombres = new string[10];
        private static int cont = 0; 
        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = txtnombre.Text;

            ingresarArreglo(nombre);

            txtnombre.Clear();
        }

        private void ingresarArreglo(string nombre)
        {
            nombres.SetValue(nombre, cont);

            cont++;
        }

        private void agregarListBox()
        {
            for(int i = 0; i < nombres.Length; i++)
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

        private void cmdList_Click(object sender, EventArgs e)
        {
            agregarListBox();
        }
    }
}
