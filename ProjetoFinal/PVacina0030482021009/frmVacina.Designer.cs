﻿
namespace PVacina0030482021009
{
    partial class frmVacina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacina));
            this.bnvVacina = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbVacina = new System.Windows.Forms.TabControl();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.dgvVacina = new System.Windows.Forms.DataGridView();
            this.tbDetalhes = new System.Windows.Forms.TabPage();
            this.cbxGrupoPrioritarioVacina = new System.Windows.Forms.ComboBox();
            this.mskbxRGVacina = new System.Windows.Forms.MaskedTextBox();
            this.mskbxCPFVacina = new System.Windows.Forms.MaskedTextBox();
            this.cbxComorbidadeVacina = new System.Windows.Forms.ComboBox();
            this.cbxTipoVacina = new System.Windows.Forms.ComboBox();
            this.txtEndVacina = new System.Windows.Forms.TextBox();
            this.dtVacina = new System.Windows.Forms.DateTimePicker();
            this.dtNascVacina = new System.Windows.Forms.DateTimePicker();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.txtIDVacina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.cbxEnfermeiro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).BeginInit();
            this.bnvVacina.SuspendLayout();
            this.tbVacina.SuspendLayout();
            this.tbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).BeginInit();
            this.tbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvVacina
            // 
            this.bnvVacina.AddNewItem = null;
            this.bnvVacina.BackColor = System.Drawing.Color.LimeGreen;
            this.bnvVacina.CountItem = this.bindingNavigatorCountItem;
            this.bnvVacina.DeleteItem = null;
            this.bnvVacina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnAlterar,
            this.btnSalvar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvVacina.Location = new System.Drawing.Point(0, 0);
            this.bnvVacina.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvVacina.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvVacina.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvVacina.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvVacina.Name = "bnvVacina";
            this.bnvVacina.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvVacina.Size = new System.Drawing.Size(769, 25);
            this.bnvVacina.TabIndex = 0;
            this.bnvVacina.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Incluir Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbVacina
            // 
            this.tbVacina.Controls.Add(this.tbDados);
            this.tbVacina.Controls.Add(this.tbDetalhes);
            this.tbVacina.Location = new System.Drawing.Point(12, 40);
            this.tbVacina.Name = "tbVacina";
            this.tbVacina.SelectedIndex = 0;
            this.tbVacina.Size = new System.Drawing.Size(741, 398);
            this.tbVacina.TabIndex = 1;
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.dgvVacina);
            this.tbDados.Location = new System.Drawing.Point(4, 22);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbDados.Size = new System.Drawing.Size(733, 372);
            this.tbDados.TabIndex = 0;
            this.tbDados.Text = "Dados";
            this.tbDados.UseVisualStyleBackColor = true;
            // 
            // dgvVacina
            // 
            this.dgvVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacina.Location = new System.Drawing.Point(7, 7);
            this.dgvVacina.Name = "dgvVacina";
            this.dgvVacina.Size = new System.Drawing.Size(720, 359);
            this.dgvVacina.TabIndex = 0;
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.BackColor = System.Drawing.Color.PaleGreen;
            this.tbDetalhes.Controls.Add(this.cbxEnfermeiro);
            this.tbDetalhes.Controls.Add(this.cbxCidade);
            this.tbDetalhes.Controls.Add(this.cbxGrupoPrioritarioVacina);
            this.tbDetalhes.Controls.Add(this.mskbxRGVacina);
            this.tbDetalhes.Controls.Add(this.mskbxCPFVacina);
            this.tbDetalhes.Controls.Add(this.cbxComorbidadeVacina);
            this.tbDetalhes.Controls.Add(this.cbxTipoVacina);
            this.tbDetalhes.Controls.Add(this.txtEndVacina);
            this.tbDetalhes.Controls.Add(this.dtVacina);
            this.tbDetalhes.Controls.Add(this.dtNascVacina);
            this.tbDetalhes.Controls.Add(this.txtNomeVacina);
            this.tbDetalhes.Controls.Add(this.txtIDVacina);
            this.tbDetalhes.Controls.Add(this.label10);
            this.tbDetalhes.Controls.Add(this.label9);
            this.tbDetalhes.Controls.Add(this.label8);
            this.tbDetalhes.Controls.Add(this.label7);
            this.tbDetalhes.Controls.Add(this.label6);
            this.tbDetalhes.Controls.Add(this.label5);
            this.tbDetalhes.Controls.Add(this.label4);
            this.tbDetalhes.Controls.Add(this.label3);
            this.tbDetalhes.Controls.Add(this.label2);
            this.tbDetalhes.Controls.Add(this.label1);
            this.tbDetalhes.Controls.Add(this.lblNome);
            this.tbDetalhes.Controls.Add(this.lblID);
            this.tbDetalhes.ImageKey = "imagem pVacina.jpg";
            this.tbDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbDetalhes.Size = new System.Drawing.Size(733, 372);
            this.tbDetalhes.TabIndex = 1;
            this.tbDetalhes.Text = "Detalhes";
            // 
            // cbxGrupoPrioritarioVacina
            // 
            this.cbxGrupoPrioritarioVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupoPrioritarioVacina.Enabled = false;
            this.cbxGrupoPrioritarioVacina.FormattingEnabled = true;
            this.cbxGrupoPrioritarioVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxGrupoPrioritarioVacina.Location = new System.Drawing.Point(498, 102);
            this.cbxGrupoPrioritarioVacina.Name = "cbxGrupoPrioritarioVacina";
            this.cbxGrupoPrioritarioVacina.Size = new System.Drawing.Size(121, 21);
            this.cbxGrupoPrioritarioVacina.TabIndex = 26;
            // 
            // mskbxRGVacina
            // 
            this.mskbxRGVacina.Enabled = false;
            this.mskbxRGVacina.Location = new System.Drawing.Point(200, 207);
            this.mskbxRGVacina.Mask = "999999999";
            this.mskbxRGVacina.Name = "mskbxRGVacina";
            this.mskbxRGVacina.Size = new System.Drawing.Size(100, 20);
            this.mskbxRGVacina.TabIndex = 25;
            // 
            // mskbxCPFVacina
            // 
            this.mskbxCPFVacina.Enabled = false;
            this.mskbxCPFVacina.Location = new System.Drawing.Point(200, 172);
            this.mskbxCPFVacina.Mask = "9999999999";
            this.mskbxCPFVacina.Name = "mskbxCPFVacina";
            this.mskbxCPFVacina.Size = new System.Drawing.Size(100, 20);
            this.mskbxCPFVacina.TabIndex = 24;
            // 
            // cbxComorbidadeVacina
            // 
            this.cbxComorbidadeVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComorbidadeVacina.Enabled = false;
            this.cbxComorbidadeVacina.FormattingEnabled = true;
            this.cbxComorbidadeVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxComorbidadeVacina.Location = new System.Drawing.Point(498, 68);
            this.cbxComorbidadeVacina.Name = "cbxComorbidadeVacina";
            this.cbxComorbidadeVacina.Size = new System.Drawing.Size(121, 21);
            this.cbxComorbidadeVacina.TabIndex = 22;
            // 
            // cbxTipoVacina
            // 
            this.cbxTipoVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVacina.Enabled = false;
            this.cbxTipoVacina.FormattingEnabled = true;
            this.cbxTipoVacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxTipoVacina.Location = new System.Drawing.Point(498, 32);
            this.cbxTipoVacina.Name = "cbxTipoVacina";
            this.cbxTipoVacina.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoVacina.TabIndex = 21;
            // 
            // txtEndVacina
            // 
            this.txtEndVacina.Enabled = false;
            this.txtEndVacina.Location = new System.Drawing.Point(200, 137);
            this.txtEndVacina.MaxLength = 100;
            this.txtEndVacina.Name = "txtEndVacina";
            this.txtEndVacina.Size = new System.Drawing.Size(100, 20);
            this.txtEndVacina.TabIndex = 18;
            // 
            // dtVacina
            // 
            this.dtVacina.CustomFormat = "dd/MM/yyyy";
            this.dtVacina.Enabled = false;
            this.dtVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVacina.Location = new System.Drawing.Point(200, 239);
            this.dtVacina.Name = "dtVacina";
            this.dtVacina.Size = new System.Drawing.Size(111, 20);
            this.dtVacina.TabIndex = 17;
            // 
            // dtNascVacina
            // 
            this.dtNascVacina.CustomFormat = "dd/MM/yyyy";
            this.dtNascVacina.Enabled = false;
            this.dtNascVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNascVacina.Location = new System.Drawing.Point(200, 99);
            this.dtNascVacina.Name = "dtNascVacina";
            this.dtNascVacina.Size = new System.Drawing.Size(111, 20);
            this.dtNascVacina.TabIndex = 16;
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Enabled = false;
            this.txtNomeVacina.Location = new System.Drawing.Point(200, 67);
            this.txtNomeVacina.MaxLength = 50;
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(100, 20);
            this.txtNomeVacina.TabIndex = 13;
            this.txtNomeVacina.TextChanged += new System.EventHandler(this.txtNomeVacina_TextChanged);
            // 
            // txtIDVacina
            // 
            this.txtIDVacina.Enabled = false;
            this.txtIDVacina.Location = new System.Drawing.Point(200, 32);
            this.txtIDVacina.Name = "txtIDVacina";
            this.txtIDVacina.Size = new System.Drawing.Size(100, 20);
            this.txtIDVacina.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Enfermeiro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(356, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Grupo Prioritário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Comorbidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo da Vacina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data da Vacinação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(43, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(43, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Enabled = false;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(498, 170);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(121, 21);
            this.cbxCidade.TabIndex = 27;
            // 
            // cbxEnfermeiro
            // 
            this.cbxEnfermeiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnfermeiro.Enabled = false;
            this.cbxEnfermeiro.FormattingEnabled = true;
            this.cbxEnfermeiro.Location = new System.Drawing.Point(498, 137);
            this.cbxEnfermeiro.Name = "cbxEnfermeiro";
            this.cbxEnfermeiro.Size = new System.Drawing.Size(121, 21);
            this.cbxEnfermeiro.TabIndex = 28;
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.tbVacina);
            this.Controls.Add(this.bnvVacina);
            this.Name = "frmVacina";
            this.Text = "Cadastro da Vacinação";
            this.Load += new System.EventHandler(this.frmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvVacina)).EndInit();
            this.bnvVacina.ResumeLayout(false);
            this.bnvVacina.PerformLayout();
            this.tbVacina.ResumeLayout(false);
            this.tbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacina)).EndInit();
            this.tbDetalhes.ResumeLayout(false);
            this.tbDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvVacina;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbVacina;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.DataGridView dgvVacina;
        private System.Windows.Forms.TabPage tbDetalhes;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.MaskedTextBox mskbxRGVacina;
        private System.Windows.Forms.MaskedTextBox mskbxCPFVacina;
        private System.Windows.Forms.ComboBox cbxComorbidadeVacina;
        private System.Windows.Forms.ComboBox cbxTipoVacina;
        private System.Windows.Forms.TextBox txtEndVacina;
        private System.Windows.Forms.DateTimePicker dtVacina;
        private System.Windows.Forms.DateTimePicker dtNascVacina;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.TextBox txtIDVacina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbxGrupoPrioritarioVacina;
        private System.Windows.Forms.ComboBox cbxEnfermeiro;
        private System.Windows.Forms.ComboBox cbxCidade;
    }
}