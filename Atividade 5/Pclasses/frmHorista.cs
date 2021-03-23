using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciarHorista_Click(object sender, EventArgs e)
        {
            // criando o objeto, instanciando o objeto
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);

            //get
            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
                  "\n" + "Matrícula:" + objHorista.Matricula + "\n" + 
                  "Tempo Trabalho" + objHorista.TempoTrabalho().ToString() +
                  "\n" + "Salário:" + objHorista.SalarioBruto().ToString("N2"));

        }
    }
}
