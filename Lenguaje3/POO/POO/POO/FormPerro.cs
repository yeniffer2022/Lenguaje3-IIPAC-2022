using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class FormPerro : Form
    {
        public FormPerro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar un objeto de la clase Perro
            Perro Miperro = new Perro();

            //Perro Miperro2 = new Perro("Tobi");

            //Perro Miperro3 = new Perro("Benyi", "Pastor", 55);

            Miperro.Nombre= "Benyi";
            Miperro.Raza = "Pastor aleman";
            Miperro.Altura = 55;

            MessageBox.Show(Miperro.Nombre+" es de raza " + Miperro.Raza + " y mide " 
                + Miperro.DevuelveAltura());




        } 
    }
}
