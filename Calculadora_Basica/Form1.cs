using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Basica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool verificar_Contenido()
        {

            bool valido = true;

            ErrorEncontrado.Clear();

            if (string.IsNullOrWhiteSpace(txtnum1.Text))
            {
                ErrorEncontrado.SetError(txtnum1, "Ingrese el primer número.");
                valido = false;
            }
            else if (!double.TryParse(txtnum1.Text, out _))
            {
                ErrorEncontrado.SetError(txtnum1, "Debe ingresar un valor numérico.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtnum2.Text))
            {
                ErrorEncontrado.SetError(txtnum2, "Ingrese el segundo número.");
                valido = false;
            }
            else if (!double.TryParse(txtnum2.Text, out _))
            {
                ErrorEncontrado.SetError(txtnum2, "Debe ingresar un valor numérico.");
                valido = false;
            }

            return valido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 + num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 - num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);
            if (num1 == 0 && num2==0)
            {
                MessageBox.Show("No se puede multiplicar cero por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = num1 * num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = num1 / num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
