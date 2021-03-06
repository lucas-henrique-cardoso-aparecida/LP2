using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double LadoA, LadoB, LadoC;

            if (double.TryParse(mskbxLadoA.Text, out LadoA) & 
                double.TryParse(mskbxLadoB.Text, out LadoB) &
                double.TryParse(mskbxLadoC.Text, out LadoC))
            {
                if ((LadoA > Math.Abs(LadoB - LadoC) && (LadoA < (LadoB + LadoC) &&
                    (LadoB > Math.Abs(LadoA - LadoC) && (LadoB < (LadoA + LadoC) &&
                    (LadoC > Math.Abs(LadoA - LadoB) && (LadoC < (LadoA + LadoB))))))))
                {
                    if (LadoA == LadoB && LadoB == LadoC && LadoC == LadoA)
                    {
                        MessageBox.Show("O triângulo é do tipo Equilátero");
                    }
                    if (LadoA != LadoB && LadoB != LadoC && LadoC != LadoA)
                    {
                        MessageBox.Show("O triângulo é do tipo Escaleno");
                    }
                    if (LadoA == LadoB && LadoC != LadoA || LadoB == LadoC && LadoA != LadoB ||
                        LadoC == LadoA && LadoB != LadoC)
                    {
                        MessageBox.Show("O triângulo é do tipo Isósceles");
                    }
                }
                else
                {
                    MessageBox.Show("Um dos lados é inválido");
                }
                
            }
            else
            {
                MessageBox.Show("Dados inválidos");
            }
        }
    }
}
