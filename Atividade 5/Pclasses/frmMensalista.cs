﻿using System;
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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            //criar ou instanciar o objeto da classe mensalista
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text); // dd/mm/yy
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);


            //get
            MessageBox.Show("Matrícula       : " + objMensalista.Matricula + "\n" +
                            "Nome            : " + objMensalista.NomeEmpregado + "\n" + 
                            "Data Entrada    : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" + 
                            "Salário bruto   : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias) : " + objMensalista.TempoTrabalho());
        }

        private void btnInstanciarParametros_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text),
                txtNome.Text, Convert.ToDateTime(txtData.Text),
                Convert.ToDouble(txtSalario.Text));

            //get
            MessageBox.Show("Matrícula       : " + objMensalista.Matricula + "\n" +
                            "Nome            : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada    : " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário bruto   : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias) : " + objMensalista.TempoTrabalho());
        }
    }
}
