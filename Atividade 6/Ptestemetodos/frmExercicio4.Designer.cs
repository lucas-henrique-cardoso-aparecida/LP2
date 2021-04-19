
namespace Ptestemetodos
{
    partial class frmExercicio4
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
            this.rtxtbx = new System.Windows.Forms.RichTextBox();
            this.btnQuantiaCar = new System.Windows.Forms.Button();
            this.btnQuantiaLetras = new System.Windows.Forms.Button();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtbx
            // 
            this.rtxtbx.Location = new System.Drawing.Point(13, 14);
            this.rtxtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtbx.Name = "rtxtbx";
            this.rtxtbx.Size = new System.Drawing.Size(659, 221);
            this.rtxtbx.TabIndex = 0;
            this.rtxtbx.Text = "";
            // 
            // btnQuantiaCar
            // 
            this.btnQuantiaCar.Location = new System.Drawing.Point(34, 259);
            this.btnQuantiaCar.Name = "btnQuantiaCar";
            this.btnQuantiaCar.Size = new System.Drawing.Size(170, 91);
            this.btnQuantiaCar.TabIndex = 1;
            this.btnQuantiaCar.Text = "Quantia de Números";
            this.btnQuantiaCar.UseVisualStyleBackColor = true;
            this.btnQuantiaCar.Click += new System.EventHandler(this.btnQuantiaCar_Click);
            // 
            // btnQuantiaLetras
            // 
            this.btnQuantiaLetras.Location = new System.Drawing.Point(474, 259);
            this.btnQuantiaLetras.Name = "btnQuantiaLetras";
            this.btnQuantiaLetras.Size = new System.Drawing.Size(171, 91);
            this.btnQuantiaLetras.TabIndex = 2;
            this.btnQuantiaLetras.Text = "Quantia de Letras";
            this.btnQuantiaLetras.UseVisualStyleBackColor = true;
            this.btnQuantiaLetras.Click += new System.EventHandler(this.btnQuantiaLetras_Click);
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(260, 259);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(168, 91);
            this.btnEspacoBranco.TabIndex = 3;
            this.btnEspacoBranco.Text = "Primeiro Espaço em Branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 380);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.btnQuantiaLetras);
            this.Controls.Add(this.btnQuantiaCar);
            this.Controls.Add(this.rtxtbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbx;
        private System.Windows.Forms.Button btnQuantiaCar;
        private System.Windows.Forms.Button btnQuantiaLetras;
        private System.Windows.Forms.Button btnEspacoBranco;
    }
}