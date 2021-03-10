using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxFilhos.SelectedIndex = 0;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            double salarioBruto = 0;


            if ((txtNome.Text == "") || (txtNome.Text.Length<5))
            {
                MessageBox.Show("Nome Inválido");
            }
            else if (!double.TryParse(mskdxSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Salário Inválido");
            }
            else
            {
                double descontoInss = 0;
                double descontoIr = 0;
                double salarioFamilia = 0;
                double salarioLiquido = 0;



                if (salarioBruto <= 800.47)
                {
                    txtAliquotaINSS.Text = "7.65%";
                    descontoInss = 7.65 / 100 * salarioBruto;
                    txtDescontoINSS.Text = descontoInss.ToString("N2");
                }
                else if (salarioBruto <= 1050)
                {
                    txtAliquotaINSS.Text = "8.65%";
                    descontoInss = 8.65 / 100 * salarioBruto;
                    txtDescontoINSS.Text = descontoInss.ToString("N2");
                }
                else if (salarioBruto <= 1400.77)
                {
                    txtAliquotaINSS.Text = "9.00%";
                    descontoInss =  9.00 / 100 * salarioBruto;
                    txtDescontoINSS.Text = descontoInss.ToString("N2");
                }
                else if (salarioBruto <= 2801.56)
                {
                    txtAliquotaINSS.Text = "11.00%";
                    descontoInss = 11.00 / 100  * salarioBruto;
                    txtDescontoINSS.Text = descontoInss.ToString("N2");
                }
                else if (salarioBruto > 2801.56)
                {
                    descontoInss = 308.17;
                    txtDescontoINSS.Text = descontoInss.ToString("N2");
                }


                if (salarioBruto <= 1257.12)
                {
                    txtAliquotaIR.Text = "Isento";
                    descontoIr = 0;
                    txtDescontoIR.Text = descontoIr.ToString("N2");
                }
                else if (salarioBruto <= 2512.08)
                {
                    txtAliquotaIR.Text = "15.00%";
                    descontoIr = 15.00 / 100 * salarioBruto;
                    txtDescontoIR.Text = descontoIr.ToString("N2");
                }
                else if (salarioBruto > 2512.08)
                {
                    txtAliquotaIR.Text = "27.5%";
                    descontoIr = 27.5 / 100 * salarioBruto;
                    txtDescontoIR.Text = descontoIr.ToString("N2");
                }




                if (salarioBruto <= 435.52)
                {
                    salarioFamilia = Convert.ToDouble(cbxFilhos.SelectedItem) * 22.33;
                    txtSalarioFamilia.Text = salarioFamilia.ToString();
                }
                else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = Convert.ToDouble(cbxFilhos.SelectedItem) * 15.74;
                    txtSalarioFamilia.Text = salarioFamilia.ToString();
                }
                else
                {
                    salarioFamilia = 0;
                    txtSalarioFamilia.Text = salarioFamilia.ToString();
                }

                salarioLiquido = salarioBruto - descontoInss - descontoIr + salarioFamilia;

                txtSalarioLiquido.Text = salarioLiquido.ToString();

                // preencher o label
                string texto = "Os descontos do Salário são";

                if (rdbnFeminino.Checked)
                {
                    texto = texto + " da Sra. " + txtNome.Text + "\n";
                }
                else
                {
                    texto = texto + " do Sr. " + txtNome.Text + "\n";
                }

                if (ckbxCasado.Checked)
                {
                    texto = texto + " que é casado(a) ";
                }
                else
                {
                    texto = texto + " que é solteiro(a)";
                }

                texto = texto + " e que tem " + cbxFilhos.SelectedItem.ToString() + " filhos são: ";
                lblMensagem.Text = texto;

            }
        }
    }
}
