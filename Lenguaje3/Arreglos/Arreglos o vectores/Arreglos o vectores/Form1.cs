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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            int[] vector1 = new int[5];//Definir un arreglo
            vector1[0] =1;
            vector1[1] = 2;
            vector1[2] = 3;
            vector1[3] = 4;
            vector1[4] = 5;

            int[] vector = new int[5] { 80, 60, 54, 98, 85 };
            int[] vector3 = new int[] { 3, 6, 4, 5, 7};

            int[] vector4 = { 5, 3, 4, 6, 8, 5 };

            string[] vector5 = {"Juan", "Maria", "Carlos","Sandra" };//Tipo string

            //for (int i = 0; i < vector5.Length; i++)
            //{
            //    listBox1.Items.Add(vector4[i]);
            //}
            
            foreach(int items in vector)
            {
                listBox1.Items.Add(items);
            }
        }
    }
}
