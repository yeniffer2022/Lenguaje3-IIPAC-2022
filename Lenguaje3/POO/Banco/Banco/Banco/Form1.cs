using LibreriaCoche;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente cliente;
        Cuenta cuenta;
        MovimientoCuenta movimientoCuenta;


        private void cmdCrearCuenta_Click(object sender, EventArgs e)
        {
            cliente = new Cliente(txtIdentidad.Text, txtNombre.Text);
            cuenta = new Cuenta(txtNumeroCuenta.Text, cliente, DateTime.Now, 0);

            txtSaldo.Text = cuenta.Saldo.ToString("N");
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                errorProvider1.SetError(txtMonto, "Digite un monto");
                txtMonto.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TipoMovimientocomboBox.Text))
            {
                errorProvider1.SetError(TipoMovimientocomboBox, "Seleccione un Tipo Movimiento");
                return;
            }

            if(TipoMovimientocomboBox.Text == "Deposito")
            {
                cuenta.Depositar(Convert.ToDecimal(txtMonto.Text));

                movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now,
                    Convert.ToDecimal(txtMonto.Text), 
                    TipoMovimientocomboBox.Text);

                MovimientolistBox.Items.Add(
                                            "Depósito a la cuenta N. " + cuenta.NumeroCuenta +
                                            " por la cantidad de L. " + movimientoCuenta.monto + 
                                            " con fecha: " + movimientoCuenta.Fecha
                    
                    
                    );
                txtSaldo.Text = cuenta.Saldo.ToString("N");

            }
            else if(TipoMovimientocomboBox.Text == "Retiro")
            {
                bool puedeRetirar=cuenta.Retirar(Convert.ToDecimal(txtMonto.Text));

                if (puedeRetirar )
                {
                    movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, 
                        Convert.ToDecimal(txtMonto.Text),
                        TipoMovimientocomboBox.Text);

                    MovimientolistBox.Items.Add(
                                            "Retiro a la cuenta N. " + cuenta.NumeroCuenta +
                                            " por la cantidad de L. " + movimientoCuenta.monto +
                                            " con fecha: " + movimientoCuenta.Fecha);

                    txtSaldo.Text = cuenta.Saldo.ToString();
                }
                else
                {
                    MessageBox.Show("La cuenta N. " + cuenta.NumeroCuenta +" no tiene saldo disponible para transaccionar");
                }


            }

        }
    }
}
