using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdEjecutar_Click(object sender, EventArgs e)
        {
            label1.Text = "Proceso Iniciado";
            //HornearPizza();
            HornearPizzaAsync();
            label1.Text = "Proceso Terminado";

        }

        private void HornearPizza()//Procedimiento sincrona
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()//Funcion asincrona
        {
            return Task.Delay(10000);
        }

        private async void cmdSumar_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(txtNumero1.Text);
            decimal numero2 = Convert.ToDecimal(txtNumero2.Text);
            
            
            decimal resultado = await SumarAsync(numero1, numero2);

            MessageBox.Show("La suma es: " + resultado.ToString());
        }

        private async Task<decimal> SumarAsync(decimal num1, decimal num2)
        {
            decimal suma = await Task.Run(() =>
            {
                return num1 + num2;
            });

            return suma;
        }






    }

}
