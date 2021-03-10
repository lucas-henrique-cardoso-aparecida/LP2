
namespace PrjSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskdxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIR = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIR = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIR = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIR = new System.Windows.Forms.TextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rdbnMasculino = new System.Windows.Forms.RadioButton();
            this.rdbnFeminino = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.cbxFilhos = new System.Windows.Forms.ComboBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(364, 173);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(154, 63);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar Descontos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(118, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(58, 83);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(85, 16);
            this.lblSalarioBruto.TabIndex = 2;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(55, 122);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(114, 16);
            this.lblFilhos.TabIndex = 3;
            this.lblFilhos.Text = "Número de Filhos";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 22);
            this.txtNome.TabIndex = 4;
            // 
            // mskdxSalarioBruto
            // 
            this.mskdxSalarioBruto.Location = new System.Drawing.Point(191, 80);
            this.mskdxSalarioBruto.Mask = "99999.99";
            this.mskdxSalarioBruto.Name = "mskdxSalarioBruto";
            this.mskdxSalarioBruto.Size = new System.Drawing.Size(100, 22);
            this.mskdxSalarioBruto.TabIndex = 5;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(39, 164);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(63, 16);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "lblDados";
            this.lblMensagem.Visible = false;
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(39, 271);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(91, 16);
            this.lblAliquotaINSS.TabIndex = 8;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblAliquotaIR
            // 
            this.lblAliquotaIR.AutoSize = true;
            this.lblAliquotaIR.Location = new System.Drawing.Point(39, 313);
            this.lblAliquotaIR.Name = "lblAliquotaIR";
            this.lblAliquotaIR.Size = new System.Drawing.Size(73, 16);
            this.lblAliquotaIR.TabIndex = 9;
            this.lblAliquotaIR.Text = "Aliquota IR";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(39, 353);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(98, 16);
            this.lblSalarioFamilia.TabIndex = 10;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(39, 397);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(98, 16);
            this.lblSalarioLiquido.TabIndex = 11;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(372, 271);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(100, 16);
            this.lblDescontoINSS.TabIndex = 12;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIR
            // 
            this.lblDescontoIR.AutoSize = true;
            this.lblDescontoIR.Location = new System.Drawing.Point(372, 313);
            this.lblDescontoIR.Name = "lblDescontoIR";
            this.lblDescontoIR.Size = new System.Drawing.Size(82, 16);
            this.lblDescontoIR.TabIndex = 13;
            this.lblDescontoIR.Text = "Desconto IR";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(159, 265);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(145, 22);
            this.txtAliquotaINSS.TabIndex = 14;
            // 
            // txtAliquotaIR
            // 
            this.txtAliquotaIR.Enabled = false;
            this.txtAliquotaIR.Location = new System.Drawing.Point(159, 307);
            this.txtAliquotaIR.Name = "txtAliquotaIR";
            this.txtAliquotaIR.Size = new System.Drawing.Size(145, 22);
            this.txtAliquotaIR.TabIndex = 15;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(158, 347);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(146, 22);
            this.txtSalarioFamilia.TabIndex = 16;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(159, 391);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(145, 22);
            this.txtSalarioLiquido.TabIndex = 17;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(478, 265);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(145, 22);
            this.txtDescontoINSS.TabIndex = 18;
            // 
            // txtDescontoIR
            // 
            this.txtDescontoIR.Enabled = false;
            this.txtDescontoIR.Location = new System.Drawing.Point(478, 310);
            this.txtDescontoIR.Name = "txtDescontoIR";
            this.txtDescontoIR.Size = new System.Drawing.Size(145, 22);
            this.txtDescontoIR.TabIndex = 19;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rdbnMasculino);
            this.gbxSexo.Controls.Add(this.rdbnFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(478, 58);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 20;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rdbnMasculino
            // 
            this.rdbnMasculino.AutoSize = true;
            this.rdbnMasculino.Location = new System.Drawing.Point(38, 58);
            this.rdbnMasculino.Name = "rdbnMasculino";
            this.rdbnMasculino.Size = new System.Drawing.Size(87, 20);
            this.rdbnMasculino.TabIndex = 1;
            this.rdbnMasculino.Text = "Masculino";
            this.rdbnMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbnFeminino
            // 
            this.rdbnFeminino.AutoSize = true;
            this.rdbnFeminino.Checked = true;
            this.rdbnFeminino.Location = new System.Drawing.Point(38, 32);
            this.rdbnFeminino.Name = "rdbnFeminino";
            this.rdbnFeminino.Size = new System.Drawing.Size(81, 20);
            this.rdbnFeminino.TabIndex = 0;
            this.rdbnFeminino.TabStop = true;
            this.rdbnFeminino.Text = "Feminino";
            this.rdbnFeminino.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(560, 173);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(75, 20);
            this.ckbxCasado.TabIndex = 21;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // cbxFilhos
            // 
            this.cbxFilhos.FormattingEnabled = true;
            this.cbxFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cbxFilhos.Location = new System.Drawing.Point(191, 122);
            this.cbxFilhos.Name = "cbxFilhos";
            this.cbxFilhos.Size = new System.Drawing.Size(65, 24);
            this.cbxFilhos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 472);
            this.Controls.Add(this.cbxFilhos);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtDescontoIR);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIR);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblDescontoIR);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIR);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.mskdxSalarioBruto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVerificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskdxSalarioBruto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIR;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIR;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIR;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIR;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rdbnMasculino;
        private System.Windows.Forms.RadioButton rdbnFeminino;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.ComboBox cbxFilhos;
    }
}

