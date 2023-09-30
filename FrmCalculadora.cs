using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public enum ESistema
        {
            Decimal,
            Binario
        }
        private ESistema sistema;
        private Numeracion numero1;
        private Numeracion numero2;
        private Numeracion resultado;
        private Operacion calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Borrar los datos de los TextBox
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();

            // Restablecer el Label de resultado
            lblResultado.Text = "Resultado:";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrimerOperador.Text, out double operando1) && double.TryParse(txtSegundoOperador.Text, out double operando2))
            {
                if (sistema == ESistema.Decimal)
                {
                    numero1 = new Numeracion(Numeracion.ESistema.Decimal, operando1);
                    numero2 = new Numeracion(Numeracion.ESistema.Decimal, operando2);
                }
                else if (sistema == ESistema.Binario)
                {
                    numero1 = new Numeracion(Numeracion.ESistema.Binario, txtPrimerOperador.Text);
                    numero2 = new Numeracion(Numeracion.ESistema.Binario, txtSegundoOperador.Text);
                }

                switch (cmbOperacion.SelectedItem.ToString())
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                    default:
                        MessageBox.Show("Seleccione una operación válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (resultado != null)
                {
                    if (sistema == ESistema.Binario)
                    {
                        lblResultado.Text = $"Resultado: {resultado.ConvertirA(Numeracion.ESistema.Binario)}";
                    }
                    else
                    {
                        lblResultado.Text = $"Resultado: {resultado.ValorNumerico}";
                    }
                }
                else
                {
                    lblResultado.Text = "No se pudo realizar la operación. Verifique los valores y el sistema numérico.";
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Binario;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Decimal;
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
