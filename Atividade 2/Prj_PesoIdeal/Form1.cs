using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_PesoIdeal
{
    public partial class Form1 : Form
    {
        double Altura, Valor, PesoAtual, PesoIdeal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(mskAltura.Text, out Altura) &
                double.TryParse(mskbxPesoAtual.Text, out PesoAtual))
            {
                if (rdbMasculino.Checked)
                {
                    Valor = (72.7 * Altura) - 58;
                    PesoIdeal = Math.Round(Valor, 2);

                    txtPesoIdeal.Text = PesoIdeal.ToString();                    
                }

                if (rdbFeminino.Checked)
                {
                    Valor = ((62.1 * Altura) - 44.7);
                    PesoIdeal = Math.Round(Valor, 2);

                    txtPesoIdeal.Text = PesoIdeal.ToString();
                }

                if (PesoAtual > PesoIdeal)
                {
                    MessageBox.Show("Regime Obrigatório já!");
                }
                if (PesoAtual < PesoIdeal)
                {
                    MessageBox.Show("Coma bastante massas e doces");
                }
                if (PesoAtual == PesoIdeal)
                {
                    MessageBox.Show("Parabéns! Você está com o peso ideal");
                }

            }
            else
            {
                MessageBox.Show("Altura ou Peso Inválidos!");
            }
        }
    }
}
