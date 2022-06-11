using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdMatriz_Click(object sender, EventArgs e)
        {
            int[,] matrizDeEjemplo = new int[2, 3]
                                                {
                                                    { 5,9,4 },
                                                    { 1,6,2 }
                                                };
            //matrizDeEjemplo[0, 0] = 5;
            //matrizDeEjemplo[0, 1] = 9;
            //matrizDeEjemplo[0, 2] = 4;

            //matrizDeEjemplo[1, 0] = 1;
            //matrizDeEjemplo[1, 1] = 6;
            //matrizDeEjemplo[1, 2] = 2;

            //Llenar una matriz
            int[,] matrizDeEjemplo2 = new int[2, 3];
            for (int fila = 0; fila < matrizDeEjemplo2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizDeEjemplo2.GetLength(1); columna++)
                {
                    matrizDeEjemplo2[fila, columna]=1 + (fila+3) * (columna + 1);
                }
            }

            //Mostrar una matriz
            
            for (int fila = 0; fila < matrizDeEjemplo2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizDeEjemplo2.GetLength(1); columna++)
                {
                    listBox1.Items.Add("La posición: [" +fila + "," + columna +"] = "+ matrizDeEjemplo2[fila, columna]);
                }
            }
        }
    }
}
