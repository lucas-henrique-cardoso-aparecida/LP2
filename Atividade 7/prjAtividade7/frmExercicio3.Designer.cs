
namespace Atividade7
{
    partial class frmExercicio3
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
            this.lblPalindromo = new System.Windows.Forms.Label();
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.brnPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalindromo
            // 
            this.lblPalindromo.AutoSize = true;
            this.lblPalindromo.Location = new System.Drawing.Point(32, 87);
            this.lblPalindromo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalindromo.Name = "lblPalindromo";
            this.lblPalindromo.Size = new System.Drawing.Size(115, 18);
            this.lblPalindromo.TabIndex = 0;
            this.lblPalindromo.Text = "Escreva o texto:";
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Location = new System.Drawing.Point(172, 87);
            this.txtPalindromo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalindromo.MaxLength = 50;
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(330, 24);
            this.txtPalindromo.TabIndex = 1;
            // 
            // brnPalindromo
            // 
            this.brnPalindromo.Location = new System.Drawing.Point(149, 155);
            this.brnPalindromo.Margin = new System.Windows.Forms.Padding(4);
            this.brnPalindromo.Name = "brnPalindromo";
            this.brnPalindromo.Size = new System.Drawing.Size(221, 70);
            this.brnPalindromo.TabIndex = 2;
            this.brnPalindromo.Text = "Verificar Palindromo";
            this.brnPalindromo.UseVisualStyleBackColor = true;
            this.brnPalindromo.Click += new System.EventHandler(this.brnPalindromo_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 274);
            this.Controls.Add(this.brnPalindromo);
            this.Controls.Add(this.txtPalindromo);
            this.Controls.Add(this.lblPalindromo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalindromo;
        private System.Windows.Forms.TextBox txtPalindromo;
        private System.Windows.Forms.Button brnPalindromo;
    }
}