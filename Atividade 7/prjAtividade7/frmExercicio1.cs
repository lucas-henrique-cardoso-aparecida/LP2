using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int qtdbrancos = 0;

            if (rtxtTexto.TextLength > 0)
            {
                for (int i = 0; i < rtxtTexto.TextLength; i++)
                {
                    if (char.IsWhiteSpace(rtxtTexto.Text[i]))
                    {
                        qtdbrancos++;
                    }
                }

                MessageBox.Show("Quantidade de espaços em branco: " + qtdbrancos);
            }
            else
            {
                MessageBox.Show("Não há texto!");
            }
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int qdtR = 0;
            
            if (rtxtTexto.TextLength > 0)
            {
                foreach (char R in rtxtTexto.Text)
                {
                    if (R == 'r' || R == 'R')
                    {
                        qdtR++;
                    }
                }

                MessageBox.Show("Quantidade de R's: " + qdtR);
            }
            else
            {
                MessageBox.Show("Não há texto!");
            }
        }

        private void brnPar_Click(object sender, EventArgs e)
        {
            int qtdPar = 0;

            for (int i = 0; i < rtxtTexto.TextLength - 1; i++)
            {
                if (rtxtTexto.TextLength > 0)
                {
                    if (rtxtTexto.Text[i] == rtxtTexto.Text[i + 1])
                    {
                        qtdPar++;
                    }
                }
                else
                {
                    MessageBox.Show("Não há texto!");
                }
            }
            MessageBox.Show("Quantia de caracteres pares: " + qtdPar);
        }
    }
}
