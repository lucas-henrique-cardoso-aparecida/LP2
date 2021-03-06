
namespace PrjTriangulo
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
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.mskbxLadoA = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLadoB = new System.Windows.Forms.MaskedTextBox();
            this.mskbxLadoC = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(50, 40);
            this.lblLadoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(58, 18);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Lado A:";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(50, 94);
            this.lblLadoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(59, 18);
            this.lblLadoB.TabIndex = 1;
            this.lblLadoB.Text = "Lado B:";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(50, 145);
            this.lblLadoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(60, 18);
            this.lblLadoC.TabIndex = 2;
            this.lblLadoC.Text = "Lado C:";
            // 
            // mskbxLadoA
            // 
            this.mskbxLadoA.Location = new System.Drawing.Point(122, 40);
            this.mskbxLadoA.Name = "mskbxLadoA";
            this.mskbxLadoA.Size = new System.Drawing.Size(100, 24);
            this.mskbxLadoA.TabIndex = 3;
            // 
            // mskbxLadoB
            // 
            this.mskbxLadoB.Location = new System.Drawing.Point(122, 91);
            this.mskbxLadoB.Name = "mskbxLadoB";
            this.mskbxLadoB.Size = new System.Drawing.Size(100, 24);
            this.mskbxLadoB.TabIndex = 4;
            // 
            // mskbxLadoC
            // 
            this.mskbxLadoC.Location = new System.Drawing.Point(122, 142);
            this.mskbxLadoC.Name = "mskbxLadoC";
            this.mskbxLadoC.Size = new System.Drawing.Size(100, 24);
            this.mskbxLadoC.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(273, 95);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(140, 71);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 220);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.mskbxLadoC);
            this.Controls.Add(this.mskbxLadoB);
            this.Controls.Add(this.mskbxLadoA);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.MaskedTextBox mskbxLadoA;
        private System.Windows.Forms.MaskedTextBox mskbxLadoB;
        private System.Windows.Forms.MaskedTextBox mskbxLadoC;
        private System.Windows.Forms.Button btnVerificar;
    }
}

