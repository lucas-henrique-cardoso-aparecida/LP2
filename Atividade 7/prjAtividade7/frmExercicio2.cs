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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double H = 1;

            if(int.TryParse(txtN.Text, out int N))
            {
                if (N <= 0)
                {
                    MessageBox.Show("Número deve ser mair do que zero!");
                    return;
                }

                for(int i = 2; i < N; i++);
                {
                    H += 1.0 / N;
                }

                MessageBox.Show(H.ToString());
            }
            else
            {
                MessageBox.Show("Coloque apenas números!");
            }
        }
    }
}
