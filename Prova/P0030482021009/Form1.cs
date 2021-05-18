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

namespace P0030482021009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int semanas = 4;
            int meses = 9;
            double total = 0;

            double[,] Valores = new double[meses,semanas];

            double[] valormes = new double[meses];
            double[] valorsemana = new double[semanas];
            

            for (int i = 0; i < meses; i ++)
            {
               for (int j = 0; j < semanas; j++ )
                {
                    var leitura = Interaction.InputBox($"Total Semana #{j + 1}", $"Valores Mês {i + 1}");

                    if (!double.TryParse(leitura, out Valores[i,j]))
                    {
                        MessageBox.Show("Erro", "Atenção");
                        j--;
                        continue;
                    }

                    valorsemana[j] = Valores[i, j];
                    valormes[i] += Valores[i, j];

                    lbxTotal.Items.Add($"Total do Mês:{i + 1} Semana{j + 1}: {valorsemana[j].ToString("C2")}");
                }
                total = total + valormes[i];

                lbxTotal.Items.Add($"-------------------");
                lbxTotal.Items.Add($">> Total Mês: {valormes[i].ToString("C2")}");
                lbxTotal.Items.Add($"-------------------");
            }
            lbxTotal.Items.Add($"Total Geral: {total.ToString("C2")}");
        }
    }
}