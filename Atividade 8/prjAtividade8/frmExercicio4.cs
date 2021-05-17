using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAtividade8
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };

            Int32 I, total = 0;
            Int32 N = Alunos.Length;

            for (I = 0; I<N - 1; I++)
            {
                total += Alunos[I].Length;
            }

            MessageBox.Show("A resposta é: " + total);
        }
    }
}
