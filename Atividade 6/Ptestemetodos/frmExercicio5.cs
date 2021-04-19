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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random sorteio = new Random();

            int a, b;

            if (int.TryParse(txtNum1.Text, out a) && int.TryParse(txtNum2.Text, out b))
            {
                if (a > b)
                {
                    MessageBox.Show("O primeiro número deve ser menor que o segundo!");
                }
                else
                {
                    int sorteado = sorteio.Next(a, b);

                    MessageBox.Show(sorteado.ToString());
                }
            }
        }
    }
}
