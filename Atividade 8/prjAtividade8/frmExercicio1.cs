using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prjAtividade8
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "";


            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Entrar com o dado da posição:" + (i + 1).ToString(),
                "Entrada de Dados");

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                }
            }
            auxiliar = "";

            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                auxiliar += vetor[i] + "\n";
            }

            MessageBox.Show(auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "";
            string saida = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Entrar com o dado da posição:" +
                    (i + 1).ToString(),
                                 "Entrada dos dados");

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Valor Inválido!");
                    i--;
                }
                else
                {
                    saida = vetor[i] + "\n" + saida;
                }
            }

            MessageBox.Show(saida);
        }
    }
}
