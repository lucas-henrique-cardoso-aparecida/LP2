using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtNum1.Text, out num1) && 
                double.TryParse(txtNum2.Text, out num2))
            {
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números Inválidos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                resultado = num1 * num2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números Inválidos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Impossível dividir por 0!");
                }
                else
                {
                    resultado = num1 / num2;
                    txtResultado.Text = resultado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Números Inválidos");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2))
            {
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números Inválidos");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();

            txtNum1.Focus();
        }
    }
}
