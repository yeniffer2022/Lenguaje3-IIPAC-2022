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
    public partial class FuncionesDataTime : Form
    {
        public FuncionesDataTime()
        {
            InitializeComponent();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            DateTime fecha=dateTimePicker1.Value;

            //MessageBox.Show("Año: " + fecha.Year, "Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Mes: " + fecha.Month, "Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("El dia: " + fecha.Day, "Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("Dia de semana " + fecha.DayOfWeek,"Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(+ fecha.Year + "-" + fecha.Month + "-"+ fecha.Day, "Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(fecha.AddDays(3).ToShortDateString(), "Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);//Se suma 3 dia a la fecha
            //MessageBox.Show(fecha.AddDays(-10).ToShortDateString(), "Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);//Resta 10 dias a la fecha
            MessageBox.Show(DevuelveLaEdadPersona(fecha).ToString() , "Edad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int DevuelveLaEdadPersona(DateTime fechaNacimiento)
        {
            DateTime _fechaNacimiento = fechaNacimiento;
            DateTime _fechaActual = DateTime.Now;//Fecha del dia de hoy

            int edad;

            if (_fechaNacimiento>= _fechaActual)
            {
                edad =0;
            }
            else
            {
                edad = _fechaActual.Year - _fechaNacimiento.Year;
                if (_fechaNacimiento.Month > _fechaActual.Month) 
                {
                    --edad;  
                }
            }
            return edad;
        }
    }
}
