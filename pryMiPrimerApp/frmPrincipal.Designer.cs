namespace pryMiPrimerApp
{
    partial class frmPrincipal
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
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.cmdfinanzas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlacena.Location = new System.Drawing.Point(31, 24);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(115, 50);
            this.cmdAlacena.TabIndex = 0;
            this.cmdAlacena.Text = "Alacena ";
            this.cmdAlacena.UseVisualStyleBackColor = false;
            this.cmdAlacena.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdfinanzas
            // 
            this.cmdfinanzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdfinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdfinanzas.Location = new System.Drawing.Point(31, 101);
            this.cmdfinanzas.Name = "cmdfinanzas";
            this.cmdfinanzas.Size = new System.Drawing.Size(115, 50);
            this.cmdfinanzas.TabIndex = 1;
            this.cmdfinanzas.Text = "Finanzas";
            this.cmdfinanzas.UseVisualStyleBackColor = false;
            this.cmdfinanzas.Click += new System.EventHandler(this.cmdfinanzas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 172);
            this.Controls.Add(this.cmdfinanzas);
            this.Controls.Add(this.cmdAlacena);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAlacena;
        private System.Windows.Forms.Button cmdfinanzas;
    }
}