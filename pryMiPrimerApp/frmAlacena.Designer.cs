namespace pryMiPrimerApp
{
    partial class frmAlacena
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.optComida = new System.Windows.Forms.RadioButton();
            this.optProductoDeLipieza = new System.Windows.Forms.RadioButton();
            this.optMedicamentos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // optComida
            // 
            this.optComida.AutoSize = true;
            this.optComida.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optComida.Location = new System.Drawing.Point(12, 22);
            this.optComida.Name = "optComida";
            this.optComida.Size = new System.Drawing.Size(66, 19);
            this.optComida.TabIndex = 0;
            this.optComida.TabStop = true;
            this.optComida.Text = "Comida";
            this.optComida.UseVisualStyleBackColor = true;
            // 
            // optProductoDeLipieza
            // 
            this.optProductoDeLipieza.AutoSize = true;
            this.optProductoDeLipieza.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optProductoDeLipieza.Location = new System.Drawing.Point(104, 22);
            this.optProductoDeLipieza.Name = "optProductoDeLipieza";
            this.optProductoDeLipieza.Size = new System.Drawing.Size(131, 19);
            this.optProductoDeLipieza.TabIndex = 1;
            this.optProductoDeLipieza.TabStop = true;
            this.optProductoDeLipieza.Text = "Producto de lipieza ";
            this.optProductoDeLipieza.UseVisualStyleBackColor = true;
            // 
            // optMedicamentos
            // 
            this.optMedicamentos.AutoSize = true;
            this.optMedicamentos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMedicamentos.Location = new System.Drawing.Point(252, 22);
            this.optMedicamentos.Name = "optMedicamentos";
            this.optMedicamentos.Size = new System.Drawing.Size(103, 19);
            this.optMedicamentos.TabIndex = 2;
            this.optMedicamentos.TabStop = true;
            this.optMedicamentos.Text = "Medicamentos";
            this.optMedicamentos.UseVisualStyleBackColor = true;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 396);
            this.Controls.Add(this.optMedicamentos);
            this.Controls.Add(this.optProductoDeLipieza);
            this.Controls.Add(this.optComida);
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton optMedicamentos;
        private System.Windows.Forms.RadioButton optProductoDeLipieza;
        private System.Windows.Forms.RadioButton optComida;
    }
}