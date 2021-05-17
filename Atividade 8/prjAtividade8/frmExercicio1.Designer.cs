
namespace prjAtividade8
{
    partial class frmExercicio1
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
            this.btnInvers1 = new System.Windows.Forms.Button();
            this.btnInvers2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvers1
            // 
            this.btnInvers1.Location = new System.Drawing.Point(48, 60);
            this.btnInvers1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvers1.Name = "btnInvers1";
            this.btnInvers1.Size = new System.Drawing.Size(218, 143);
            this.btnInvers1.TabIndex = 0;
            this.btnInvers1.Text = "Ordem Inversa";
            this.btnInvers1.UseVisualStyleBackColor = true;
            this.btnInvers1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInvers2
            // 
            this.btnInvers2.Location = new System.Drawing.Point(324, 60);
            this.btnInvers2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvers2.Name = "btnInvers2";
            this.btnInvers2.Size = new System.Drawing.Size(218, 143);
            this.btnInvers2.TabIndex = 1;
            this.btnInvers2.Text = "Ordem Inversa (maneira diferente)";
            this.btnInvers2.UseVisualStyleBackColor = true;
            this.btnInvers2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 285);
            this.Controls.Add(this.btnInvers2);
            this.Controls.Add(this.btnInvers1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvers1;
        private System.Windows.Forms.Button btnInvers2;
    }
}