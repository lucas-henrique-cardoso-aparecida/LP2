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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar o vetor
            List<string> nomeVetor3 = new List<string>()
            {
                "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"
            };

            nomeVetor3.Remove("Otávio");

            string aux = "";

            foreach (string nome in nomeVetor3)
            {
                aux += nome + "\n";
            }

            MessageBox.Show(aux);
        }
    }
}
