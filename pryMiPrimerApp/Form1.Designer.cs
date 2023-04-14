
namespace pryMiPrimerApp
{
    partial class fmrPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labe1 = new System.Windows.Forms.Label();
            this.texdeposito = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblalquileres = new System.Windows.Forms.Label();
            this.texalquleres = new System.Windows.Forms.TextBox();
            this.lblimpuestos = new System.Windows.Forms.Label();
            this.textimpuestos = new System.Windows.Forms.TextBox();
            this.textcomida = new System.Windows.Forms.TextBox();
            this.lblcomida = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.texdeposito);
            this.groupBox1.Controls.Add(this.labe1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iNGRESOS ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(46, 54);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(88, 24);
            this.labe1.TabIndex = 0;
            this.labe1.Text = "Deposito";
            // 
            // texdeposito
            // 
            this.texdeposito.Location = new System.Drawing.Point(178, 46);
            this.texdeposito.Name = "texdeposito";
            this.texdeposito.Size = new System.Drawing.Size(100, 32);
            this.texdeposito.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcomida);
            this.groupBox2.Controls.Add(this.textcomida);
            this.groupBox2.Controls.Add(this.textimpuestos);
            this.groupBox2.Controls.Add(this.lblimpuestos);
            this.groupBox2.Controls.Add(this.texalquleres);
            this.groupBox2.Controls.Add(this.lblalquileres);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 216);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GASTOS FIJOS ";
            // 
            // lblalquileres
            // 
            this.lblalquileres.AutoSize = true;
            this.lblalquileres.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalquileres.Location = new System.Drawing.Point(46, 54);
            this.lblalquileres.Name = "lblalquileres";
            this.lblalquileres.Size = new System.Drawing.Size(97, 22);
            this.lblalquileres.TabIndex = 0;
            this.lblalquileres.Text = "Alquileres ";
            // 
            // texalquleres
            // 
            this.texalquleres.Location = new System.Drawing.Point(178, 54);
            this.texalquleres.Name = "texalquleres";
            this.texalquleres.Size = new System.Drawing.Size(100, 32);
            this.texalquleres.TabIndex = 1;
            // 
            // lblimpuestos
            // 
            this.lblimpuestos.AutoSize = true;
            this.lblimpuestos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimpuestos.Location = new System.Drawing.Point(46, 112);
            this.lblimpuestos.Name = "lblimpuestos";
            this.lblimpuestos.Size = new System.Drawing.Size(98, 22);
            this.lblimpuestos.TabIndex = 2;
            this.lblimpuestos.Text = "Impuestos ";
            this.lblimpuestos.Click += new System.EventHandler(this.label3_Click);
            // 
            // textimpuestos
            // 
            this.textimpuestos.Location = new System.Drawing.Point(178, 112);
            this.textimpuestos.Name = "textimpuestos";
            this.textimpuestos.Size = new System.Drawing.Size(100, 32);
            this.textimpuestos.TabIndex = 3;
            // 
            // textcomida
            // 
            this.textcomida.Location = new System.Drawing.Point(178, 170);
            this.textcomida.Name = "textcomida";
            this.textcomida.Size = new System.Drawing.Size(100, 32);
            this.textcomida.TabIndex = 4;
            // 
            // lblcomida
            // 
            this.lblcomida.AutoSize = true;
            this.lblcomida.Location = new System.Drawing.Point(46, 170);
            this.lblcomida.Name = "lblcomida";
            this.lblcomida.Size = new System.Drawing.Size(75, 24);
            this.lblcomida.TabIndex = 5;
            this.lblcomida.Text = "comida";
            this.lblcomida.Click += new System.EventHandler(this.label4_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "fmrPrincipal";
            this.Text = "Gestiòn De Gastos Mensuales ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.TextBox texdeposito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textimpuestos;
        private System.Windows.Forms.Label lblimpuestos;
        private System.Windows.Forms.TextBox texalquleres;
        private System.Windows.Forms.Label lblalquileres;
        private System.Windows.Forms.Label lblcomida;
        private System.Windows.Forms.TextBox textcomida;
    }
}

