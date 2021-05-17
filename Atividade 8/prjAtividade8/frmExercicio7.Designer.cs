
namespace prjAtividade8
{
    partial class frmExercicio7
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
            this.btnNomes = new System.Windows.Forms.Button();
            this.ltbxEx7 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNomes
            // 
            this.btnNomes.Location = new System.Drawing.Point(95, 53);
            this.btnNomes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNomes.Name = "btnNomes";
            this.btnNomes.Size = new System.Drawing.Size(173, 143);
            this.btnNomes.TabIndex = 0;
            this.btnNomes.Text = "Executar";
            this.btnNomes.UseVisualStyleBackColor = true;
            this.btnNomes.Click += new System.EventHandler(this.button1_Click);
            // 
            // ltbxEx7
            // 
            this.ltbxEx7.FormattingEnabled = true;
            this.ltbxEx7.ItemHeight = 20;
            this.ltbxEx7.Location = new System.Drawing.Point(367, 14);
            this.ltbxEx7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbxEx7.Name = "ltbxEx7";
            this.ltbxEx7.Size = new System.Drawing.Size(283, 364);
            this.ltbxEx7.TabIndex = 1;
            // 
            // frmExercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.ltbxEx7);
            this.Controls.Add(this.btnNomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio7";
            this.Text = "frmExercicio7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNomes;
        private System.Windows.Forms.ListBox ltbxEx7;
    }
}