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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcularSal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProducao.Text, out int producao) &&
               double.TryParse(txtSalario.Text, out double salario) &&
               double.TryParse(txtGratificacao.Text, out double gratificacao))
            {
                int B = 0, C = 0, D = 0;

                if (producao >= 100)
                {
                    B = 1;
                }
                if (producao >= 120)
                {
                    C = 1;
                }
                if (producao >= 150)
                {
                    D = 1;
                }

                double salarioBruto = salario + (salario * (0.05*B + 0.1*C + 0.1*D)) + gratificacao;

                if(salarioBruto > 7000 && (D == 0) || gratificacao == 0)
                {
                    salarioBruto = 7000;
                }

                txtSalBruto.Text = salarioBruto.ToString("N2");
            }
            else
            {
                MessageBox.Show("Por favor preencher os dados corretamente!");
            }


        }
    }
}
