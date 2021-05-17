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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int linhas = 20;
            int colunas = 3;

            double[,] notasAlunos = new double[linhas, colunas];
            double[] media = new double[linhas];

            for (int i = 0; i < linhas; i++)
            {
                media[i] = 0;

                for (int j = 0; j < colunas; j++)
                {
                    var leitura = Interaction.InputBox($"Nota #{j + 1}", $"Notas Aluno {i + 1}");

                    if (!double.TryParse(leitura, out notasAlunos[i, j]))
                    {
                        MessageBox.Show("Erro", "Atenção");
                        j--;
                        continue;
                    }

                    media[i] += notasAlunos[i, j];
                }

                media[i] = media[i] / 3.0;
            }

            string saida = "";

            for (int i = 0; i < linhas; i++)
            {
                saida += $"Aluno {i + 1}: média: {media[i]} \n";
            }

            MessageBox.Show(saida);
        }
    }
}
