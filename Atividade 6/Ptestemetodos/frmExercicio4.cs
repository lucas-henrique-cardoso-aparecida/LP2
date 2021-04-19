using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnQuantiaCar_Click(object sender, EventArgs e)
        {
            int qtdnum = 0;

            for (int i = 0; i < rtxtbx.TextLength; i++)
            {
                if(char.IsNumber(rtxtbx.Text[i]))
                {
                    qtdnum++;
                }
            }

            MessageBox.Show("Quantia de Números: " + qtdnum);
        }

        private void btnQuantiaLetras_Click(object sender, EventArgs e)
        {
            int qtdLetras = 0;

            foreach (char letra in rtxtbx.Text)
            {
                if (char.IsLetter(letra))
                {
                    qtdLetras++;
                }
            }

            MessageBox.Show("Quantia de letras: " + qtdLetras);
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            if (rtxtbx.TextLength > 0)
            {
                while (!char.IsWhiteSpace(rtxtbx.Text[posicao]))
                {
                    if(posicao == rtxtbx.TextLength - 1)
                    {
                        posicao = 0;
                        break;
                    }
                    posicao++;
                }
                MessageBox.Show("Posição do primeiro espaço em branco: " + posicao);
            }
            else
            {
                MessageBox.Show("Não há texto!");
            }

        }
    }
}
