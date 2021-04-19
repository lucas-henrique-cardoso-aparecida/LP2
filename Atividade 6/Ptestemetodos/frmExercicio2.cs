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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
                MessageBox.Show("Os Textos são iguais");
            else
                MessageBox.Show("Os Textos não são iguais");
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra2.Text.Length / 2;

            //txtpalavra1.Text a                 a              a
            //txtpalavra2.Text casa            Fatec        assessoria
            //metade             2               2              5
            //                  ca              fa              assess


            txtPalavra2.Text = txtPalavra2.Text.Substring(0, metade) +
                               txtPalavra1.Text + 
                               txtPalavra2.Text.Substring(metade, txtPalavra2.Text.Length - metade);
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra1.Text.Length / 2;

            txtPalavra1.Text = txtPalavra1.Text.Substring(0, metade) + "**" +
                               txtPalavra1.Text.Substring(metade, txtPalavra1.Text.Length - metade);
        }
    }
}
